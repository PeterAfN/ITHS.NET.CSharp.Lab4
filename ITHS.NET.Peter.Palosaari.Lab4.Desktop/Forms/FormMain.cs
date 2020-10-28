using ITHS.NET.Peter.Palosaari.Lab4.Desktop.UserControls;
using System;
using System.Windows.Forms;

namespace ITHS.NET.Peter.Palosaari.Lab4.Desktop.Forms
{
    public partial class FormMain : Form
    {
        private WordList wordList;
        private AboutBox aboutBox;
        private readonly FormSelectWordList formSelectWordList;
        private readonly FormNewWordList formNewWordList;
        private readonly FormAddWords formAddWords;
        private readonly UserControlEdit userControlEdit;
        private readonly UserControlPractice userControlPractice;
        private readonly UserControlButtons userControlButtons;


        public FormMain()
        {
            InitializeComponent();
            formSelectWordList = new FormSelectWordList();
            formNewWordList = new FormNewWordList();
            userControlButtons = new UserControlButtons() { Dock = DockStyle.Fill };
            formAddWords = new FormAddWords();
            userControlEdit = new UserControlEdit(userControlButtons) { Dock = DockStyle.Fill };
            userControlPractice = new UserControlPractice(userControlButtons) { Dock = DockStyle.Fill };

            formSelectWordList.buttonSelect.Click += FormSelectWordList_ButtonSelect_Click;
            formSelectWordList.buttonCancel.Click += FormSelectWordList_ButtonCancel_Click;
            formSelectWordList.Shown += FormSelectWordList_Shown;
            formNewWordList.buttonCreate.Click += FormNewWordList_ButtonCreate_Click;
            userControlButtons.button1.Click += UserControlButtons_ButtonAddWord_Click;
            userControlButtons.button2.Click += UserControlButtons_ButtonRemoveWord_Click;
            formAddWords.WordsAdded += FormAddWords_OnWordsAdded;

            comboBoxMode.Hide();
            labelMode.Hide();
            panelData.Hide();
            panelButtons.Hide();
            panelButtons.Controls.Add(userControlButtons);
            userControlButtons.SetButtonNames("Add words", "Remove words");
            Activate();
        }

        private void FormSelectWordList_Shown(object sender, EventArgs e) => panelButtons.Hide();

        private void FormMain_Shown(object sender, EventArgs e) => formSelectWordList.ShowDialog();

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (confirmExitingProgramToolStripMenuItem.Checked)
            {
                var result = MessageBox.Show("Do you want to exit the program?", "Glosor", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly, false);

                e.Cancel = (result == DialogResult.No);
            }
            Activate();
        }

        private void ToolStripMenuItemExit_MouseDown(object sender, MouseEventArgs e) => Application.Exit();

        private void ComboBoxMode_SelectionChangeCommitted(object sender, EventArgs e)
        {
            comboBoxMode.Show();
            if (comboBoxMode.SelectedItem.ToString() == $"Edit \"{wordList.Name}\"")
            {
                ShowEditMode(userControlEdit);
                panelButtons.Show();
            }
            else
            {
                ShowPracticeMode(userControlPractice);
            }
        }

        private void ToolStripMenuItemSetActiveWordList_Click(object sender, EventArgs e)
        {
            formSelectWordList.WordList = wordList;
            formSelectWordList.ShowDialog();
            MainFormButtonLogicHandle(sender, e);
        }

        private void MainFormButtonLogicHandle(object sender, EventArgs e)
        {
            if (panelData.Controls.Contains(userControlEdit))
            {
                userControlButtons.SetButtonNames("Add words", "Remove words");
                userControlButtons.SetButtonStatus(true, true);
                if (userControlEdit?.dataGridViewTranslations.SelectedCells.Count <= 0)
                    userControlButtons.SetButtonStatus(true, false);

            }
            else if (panelData.Controls.Contains(userControlPractice))
            {
                userControlButtons.SetButtonNames("Start practice", "End practice");
            }
            else
            {
                userControlButtons.SetButtonNames("Add words", "Remove words");
                userControlButtons.SetButtonStatus(false, false);
            }
        }

        private void CreateNewListToolStripMenuItem_Click(object sender, EventArgs e) => formNewWordList.ShowDialog();

        private void FormSelectWordList_ButtonSelect_Click(object sender, EventArgs e)
        {
            string nameSelected = formSelectWordList.listBoxWordLists.SelectedItem.ToString();
            wordList = WordList.LoadList(nameSelected);
            userControlEdit.ReadDataFromWordListToDataGrid(wordList);
            panelButtons.Show();
            ShowEditMode(userControlEdit);
            ShowAndSetComboBox(nameSelected);
        }

        private void ShowEditMode(UserControlEdit userControlEdit)
        {
            userControlButtons.SetButtonNames("Add words", "Remove words");
            panelData.Controls.Clear();
            panelData.Controls.Add(userControlEdit);
            panelData.Show();
            ShowAndSetComboBox(wordList.Name);
            MainFormButtonLogicHandle(this, EventArgs.Empty);
        }

        private void ShowAndSetComboBox(string nameTranslation)
        {
            labelMode.Show();
            comboBoxMode.Show();
            comboBoxMode.Items[0] = $"Edit \"{nameTranslation}\"";
            comboBoxMode.Items[1] = $"Practice \"{nameTranslation}\"";
            if (panelData.Controls.Contains(userControlEdit)) comboBoxMode.SelectedIndex = 0;
            else comboBoxMode.SelectedIndex = 1;
        }

        private void FormSelectWordList_ButtonCancel_Click(object sender, EventArgs e)
        {
            MainFormButtonLogicHandle(sender, e);
            panelButtons.Show();
        }

        private void FormNewWordList_ButtonCreate_Click(object sender, EventArgs e)
        {
            wordList = WordList.LoadList(formNewWordList.textBoxNameList.Text);

            if (wordList == null)
                wordList = new WordList(formNewWordList.textBoxNameList.Text, formNewWordList.textBoxLanguages.Lines);
            else MessageBox.Show("The word list exists already. Please add words to existing list instead.");
            formNewWordList.Close();
            wordList.Save();

            userControlEdit.ReadDataFromWordListToDataGrid(wordList);
            panelButtons.Show();
            ShowEditMode(userControlEdit);
            ShowAndSetComboBox(wordList.Name);
            MainFormButtonLogicHandle(sender, e);
            UserControlButtons_ButtonAddWord_Click(formNewWordList.buttonCreate, EventArgs.Empty);
        }

        private void UserControlButtons_ButtonRemoveWord_Click(object sender, EventArgs e)
        {
            if (userControlButtons.button2.Text != "Remove words") return;
            if (confirmRemovingWordsToolStripMenuItem.Checked)
            {
                var result = MessageBox.Show("Do you want to remove selected words?", "Confirmation", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK) RemoveWords(sender, e);
            }
            else RemoveWords(sender, e);
        }

        private void RemoveWords(object sender, EventArgs e)
        {
            if (userControlEdit.dataGridViewTranslations.SelectedCells.Count <= 0) return;
            foreach (DataGridViewCell cell in userControlEdit.dataGridViewTranslations.SelectedCells)
            {
                if (cell.ColumnIndex != 0) continue;
                if (wordList.Remove(0, cell.Value.ToString()))
                    wordList.Save();
            }
            userControlEdit.ReadDataFromWordListToDataGrid(wordList);
            panelButtons.Show();
            ShowEditMode(userControlEdit);
            MainFormButtonLogicHandle(sender, e);
        }

        private void UserControlButtons_ButtonAddWord_Click(object sender, EventArgs e)
        {
            if (userControlButtons.button1.Text != "Add words") return;
            formAddWords.ReadDataToDataGrid(wordList);
            formAddWords.ShowDialog();
        }

        private void FormAddWords_OnWordsAdded(object sender, EventArgs e)
        {
            userControlEdit.ReadDataFromWordListToDataGrid(wordList);
            panelButtons.Show();
            ShowEditMode(userControlEdit);
            labelMode.Show();
            comboBoxMode.Show();
            comboBoxMode.SelectedIndex = 0;
        }

        private void AboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            aboutBox = new AboutBox();
            aboutBox.ShowDialog();
        }

        private void ConfirmRemovingWordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (confirmRemovingWordsToolStripMenuItem.CheckState == CheckState.Checked)
                confirmRemovingWordsToolStripMenuItem.Checked = false;
            else confirmRemovingWordsToolStripMenuItem.Checked = true;
        }

        private void ConfirmExitingProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (confirmExitingProgramToolStripMenuItem.CheckState == CheckState.Checked)
                confirmExitingProgramToolStripMenuItem.Checked = false;
            else confirmExitingProgramToolStripMenuItem.Checked = true;
        }

        private void ShowPracticeMode(UserControlPractice userControlPractice)
        {
            userControlButtons.SetButtonStatus(true, true);
            userControlPractice.InitializeControls();
            userControlButtons.SetButtonNames("Start practice", "End practice");
            panelData.Controls.Clear();
            panelData.Controls.Add(userControlPractice);
            panelData.Show();
            ShowAndSetComboBox(wordList.Name);
            userControlPractice.SetWordList(wordList);
        }
    }
}
