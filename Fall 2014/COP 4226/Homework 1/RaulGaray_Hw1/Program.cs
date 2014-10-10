using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaulGaray_Hw1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (Properties.Settings.Default.SkipLogin)
                Application.Run(new MainForm());
            else
            {
                LoginDialog dlg = new LoginDialog();
                dlg.ShowDialog();
                DialogResult res = dlg.DialogResult;
                if (res == DialogResult.Yes)
                    Application.Run(new MainForm());
            }
        }
    }
}
