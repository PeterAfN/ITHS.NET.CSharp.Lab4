using System;
using System.Windows.Forms;

namespace ITHS.NET.Peter.Palosaari.Lab4.Desktop.UserControls
{
    public partial class UserControlEdit : UserControl
    {
        private WordList wordList;
        private readonly UserControlButtons userControlButtons;

        public UserControlEdit(UserControlButtons userControlButtons)
        {
            InitializeComponent();
            this.userControlButtons = userControlButtons;
        }

        public void ReadDataFromWordListToDataGrid(WordList wordList)
        {
            this.wordList = wordList;
            AddColumns();
            dataGridViewTranslations.Rows.Clear();
            wordList.List(0, p => dataGridViewTranslations.Rows.Add(p));
            SetColumnHeaders();
        }

        private void AddColumns()
        {
            int columnsAmount = wordList.Languages.Length;

            DataGridViewColumn[] c;
            c = CreateColumns(columnsAmount);
            dataGridViewTranslations.Columns.Clear();
            dataGridViewTranslations.Columns.AddRange(c);
        }

        private DataGridViewTextBoxColumn[] CreateColumns(int columnsAmount)
        {
            var output = new DataGridViewTextBoxColumn[columnsAmount];

            for (int i = 0; i < columnsAmount; i++)
            {
                output[i] = (new DataGridViewTextBoxColumn());
            }

            return output;
        }

        private void SetColumnHeaders()
        {
            for (int i = 0; i < dataGridViewTranslations.Columns.Count; i++)
            {
                dataGridViewTranslations.Columns[i].HeaderText = wordList.Languages[i].ToUpper();
            }
        }

        private void DataGridViewTranslations_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewTranslations.SelectedCells.Count == 0)
                userControlButtons.button2.Enabled = false;
            else
                userControlButtons.button2.Enabled = true;
        }

        private void UserControlEdit_Load(object sender, EventArgs e)
        {
            dataGridViewTranslations.ClearSelection();
            dataGridViewTranslations.CurrentCell = null;
        }
    }
}
