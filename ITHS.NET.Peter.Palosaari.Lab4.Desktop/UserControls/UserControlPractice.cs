using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITHS.NET.Peter.Palosaari.Lab4.Desktop.UserControls
{
    public partial class UserControlPractice : UserControl
    {
        private readonly UserControlButtons userControlButtons;
        private WordList wordList;
        public UserControlPractice(UserControlButtons userControlButtons)
        {
            InitializeComponent();
            this.userControlButtons = userControlButtons;

            this.userControlButtons.button1.Click += Button1_Click;
            this.userControlButtons.button2.Click += Button2_Click;
        }

        private Word Word { get; set; }

        private int nrOfQuestions;
        private int correctAnswers;

        public void SetWordList(WordList wordList)
        {
            this.wordList = wordList;
        }

        private async void Button2_Click(object sender, EventArgs e)
        {
            if (userControlButtons.button2.Text != "End practice") return;
            if (nrOfQuestions == 0) await ShowInfoTextAsync("You didn't answer any questions.", Color.DarkRed);
            else
            {

                userControlButtons.button1.Enabled = true;
                userControlButtons.button2.Enabled = false;
                textBoxAnswer.Enabled = false;
                labelQuestion.Enabled = false;
                labelDivider.Visible = true;
                labelResult.Visible = true;
                labelResult2.Visible = true;

                labelResult.Text = $"You practiced {nrOfQuestions} word(s).";
                labelResult2.Text = $"\n{((float)correctAnswers) / nrOfQuestions * 100:0.0}% of your answers were correct!";
                textBoxAnswer.Enabled = false;
            }
        }

        public void InitializeControls()
        {
            userControlButtons.button1.Enabled = true;
            userControlButtons.button2.Enabled = false;
            labelInfo.Text = string.Empty;
            labelInfo.Visible = true;
            textBoxAnswer.Visible = false;
            textBoxAnswer.Enabled = true;
            labelDivider.Visible = false;
            labelQuestion.Visible = false;
            labelResult.Text = string.Empty;
            labelResult2.Text = string.Empty;
            labelResult.Visible = false;
            labelResult2.Visible = false;
            labelDivider.Visible = false;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (userControlButtons.button1.Text != "Start practice") return;
            Word = wordList.GetWordToPractice();
            if (Word == null)
            {
                MessageBox.Show("Please add words to the list first!");
                return;
            }

            labelDivider.Visible = false;
            labelResult.Visible = false;
            labelResult2.Visible = false;
            userControlButtons.button1.Enabled = false;
            userControlButtons.button2.Enabled = false;
            labelQuestion.Enabled = true;
            labelQuestion.Visible = true;
            textBoxAnswer.Enabled = true;
            textBoxAnswer.Visible = true;

            labelQuestion.Text = $"Translate the {wordList.Languages[Word.FromLanguage]} word " +
                                 $"'{Word.Translations[Word.FromLanguage]}' to {wordList.Languages[Word.ToLanguage]}: ";

            nrOfQuestions = 0;
            correctAnswers = 0;
        }

        private async void TextBoxAnswer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 13) return;
            userControlButtons.button2.Enabled = true;
            string input = textBoxAnswer.Text?.Trim().ToLower();

            if (input == Word.Translations[Word.ToLanguage].Trim().ToLower())
            {
                await ShowInfoTextAsync($"Correct answer!", Color.Green);
                correctAnswers += 1;
            }
            else await ShowInfoTextAsync($"Wrong answer!", Color.DarkRed);

            nrOfQuestions++;
            Word = wordList.GetWordToPractice();
            labelQuestion.Text = $"Translate the {wordList.Languages[Word.FromLanguage]} word " +
                                 $"'{Word.Translations[Word.FromLanguage]}' to {wordList.Languages[Word.ToLanguage]}: ";
            textBoxAnswer.Text = string.Empty;
        }

        private async Task ShowInfoTextAsync(string infoText, Color color)
        {
            labelInfo.Text = infoText;
            labelInfo.ForeColor = color;
            labelInfo.Visible = true;
            await Task.Delay(1000);
            labelInfo.Visible = false;
        }

        private void TextBoxAnswer_KeyDown(object sender, KeyEventArgs e)
        {
            userControlButtons.button2.Enabled = false;
        }
    }
}
