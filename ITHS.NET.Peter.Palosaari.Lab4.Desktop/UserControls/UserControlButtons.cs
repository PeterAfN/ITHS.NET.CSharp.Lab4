using System.Windows.Forms;

namespace ITHS.NET.Peter.Palosaari.Lab4.Desktop.UserControls
{
    public partial class UserControlButtons : UserControl
    {
        public UserControlButtons()
        {
            InitializeComponent();
        }

        public void SetButtonStatus(bool button1Status, bool button2Status)
        {
            button1.Enabled = button1Status;
            button2.Enabled = button2Status;
        }

        public void SetButtonNames(string nameButton1, string nameButton2)
        {
            button1.Text = nameButton1;
            button2.Text = nameButton2;
        }
    }
}
