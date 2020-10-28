using ITHS.NET.Peter.Palosaari.Lab4.Desktop.Forms;
using System;
using System.Windows.Forms;

namespace ITHS.NET.Peter.Palosaari.Lab4.Desktop
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
        }
    }
}
