using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITHS.NET.Peter.Palosaari.Lab4.Desktop.Forms
{
    public partial class FormAddWords : Form
    {
        private WordList wordList;

        public FormAddWords()
        {
            InitializeComponent();
            buttonAdd.Enabled = false;
        }

        public void ReadDataToDataGrid(WordList wordlist)
        {
            wordList = wordlist;
            AddRows();
            SetRowHeaders();
            buttonAdd.Enabled = false;
        }

        private void AddRows()
        {
            int rowAmount = wordList.Languages.Length;

            DataGridViewRow[] r = CreateRows(rowAmount);
            dataGridViewWords.Rows.Clear();
            dataGridViewWords.Rows.AddRange(r);
        }

        private static DataGridViewRow[] CreateRows(int rowAmount)
        {
            var output = new DataGridViewRow[rowAmount];

            for (int i = 0; i < rowAmount; i++)
            {
                output[i] = (new DataGridViewRow());
            }

            return output;
        }

        private void SetRowHeaders()
        {
            for (int i = 0; i < dataGridViewWords.Rows.Count; i++)
            {
                dataGridViewWords.Rows[i].Cells[0].Value = wordList.Languages[i].ToUpper();
            }
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async Task ShowInfoTextAsync(string infoText, Color color)
        {
            labelWordsAdded.Text = infoText;
            labelWordsAdded.ForeColor = color;
            labelWordsAdded.Visible = true;
            await Task.Delay(1000);
            labelWordsAdded.Visible = false;
        }

        private async void ButtonAdd_Click(object sender, EventArgs e)
        {
            string[] words = new string[dataGridViewWords.RowCount];

            for (int i = 0; i < dataGridViewWords.RowCount; i++)
            {
                words[i] = dataGridViewWords.Rows[i].Cells[1].Value.ToString();
            }

            int countWordsBefore = wordList.Count();
            wordList.Add(words);
            wordList.Save();
            int countWordsAfter = wordList.Count();

            if (countWordsAfter != countWordsBefore + 1) await ShowInfoTextAsync("Duplicate", Color.DarkRed);
            else await ShowInfoTextAsync("Added.", Color.Green);

            FormAddWorks_OnWordsAdded(this, new EventArgs());
        }

        public event EventHandler<EventArgs> WordsAdded;

        protected virtual void FormAddWorks_OnWordsAdded(object sender, EventArgs e)
        {
            EventHandler<EventArgs> handler = WordsAdded;
            handler?.Invoke(sender, e);
        }

        private void DataGridViewWords_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewWords.CurrentCell.ColumnIndex == 0)
                dataGridViewWords.CurrentCell.Selected = false;
        }

        private void DataGridViewWords_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewWords.CurrentCell.Value != null)
            {
                for (int i = 0; i < dataGridViewWords.RowCount; i++)
                {
                    if (!IsAllLettersOrDigits(dataGridViewWords?.Rows[i].Cells[1]?.Value?.ToString()))
                    {
                        buttonAdd.Enabled = false;
                        return;
                    }
                    else buttonAdd.Enabled = true;
                }
            }
            else buttonAdd.Enabled = false;
        }

        private static bool IsAllLettersOrDigits(string s)
        {
            if (s == null) return false;
            else
                foreach (char c in s)
                {
                    if (!char.IsLetterOrDigit(c))
                        return false;
                }
            return true;
        }

        private async void DataGridViewWords_MouseLeave(object sender, EventArgs e)
        {
            if (dataGridViewWords.CurrentCell.Value == null) return;
            for (int i = 0; i < dataGridViewWords.RowCount; i++)
            {
                if (IsAllLettersOrDigits(dataGridViewWords?.Rows[i].Cells[1]?.Value?.ToString())) continue;
                await ShowInfoTextAsync("Illegal characters", Color.DarkRed);
                return;
            }
        }
    }
}
