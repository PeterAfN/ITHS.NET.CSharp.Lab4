using System;
using System.Windows.Forms;

namespace ITHS.NET.Peter.Palosaari.Lab4.Desktop.Forms
{
    public partial class FormSelectWordList : Form
    {

        public FormSelectWordList()
        {
            InitializeComponent();
            listBoxWordLists.Items.AddRange(WordList.GetLists());
        }

        public WordList WordList { get; set; }

        private void ButtonSelect_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ListBoxWordLists_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxWordLists?.SelectedItem == null) return;
            listBoxLanguages.Items.Clear();
            WordList = WordList.LoadList(listBoxWordLists?.SelectedItem?.ToString());
            listBoxLanguages.Items.AddRange(WordList.Languages);
            labelWordCount.Text = $"Word Count: {WordList.Count()}";
            buttonSelect.Enabled = true;
        }

        private void FormSelectWordList_Shown(object sender, EventArgs e)
        {
            listBoxWordLists.Items.Clear();
            listBoxWordLists.Items.AddRange(WordList.GetLists());
        }
    }
}
