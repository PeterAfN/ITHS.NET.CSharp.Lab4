using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ITHS.NET.Peter.Palosaari.Lab4.Desktop.Forms
{
    public partial class FormNewWordList : Form
    {
        public FormNewWordList()
        {
            InitializeComponent();
            buttonCreate.Enabled = false;
        }

        private void TextBoxNameList_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControlCharacters(sender, e);
        }

        private void TextBoxLanguages_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControlCharacters(sender, e);
        }

        private static void ControlCharacters(object sender, KeyPressEventArgs e)
        {
            var regex = new Regex(@"[^a-öA-Ö0-9\\s]");
            if (!regex.IsMatch(e.KeyChar.ToString())) return;
            if (e.KeyChar == '\b' || e.KeyChar == '\r')
            {
                e.Handled = false;
            }
            else e.Handled = true;
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TextBoxNameList_TextChanged(object sender, EventArgs e)
        {
            if (textBoxNameList.Text.Length == 0 ||
                textBoxLanguages.Text.Length == 0 || !textBoxLanguages.Text.Contains("\r\n"))
            {
                buttonCreate.Enabled = false;
            }
            else buttonCreate.Enabled = true;
        }

        private void TextBoxLanguages_TextChanged(object sender, EventArgs e)
        {
            if (textBoxLanguages.Text.Length == 0 ||
                textBoxNameList.Text.Length == 0 || !textBoxLanguages.Text.Contains("\r\n"))
            {
                buttonCreate.Enabled = false;
            }
            else buttonCreate.Enabled = true;
        }
    }
}
