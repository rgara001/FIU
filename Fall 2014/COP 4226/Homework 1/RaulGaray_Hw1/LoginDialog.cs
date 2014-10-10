using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaulGaray_Hw1
{
    public partial class LoginDialog : Form
    {
        public LoginDialog()
        {
            InitializeComponent();
            this.ControlBox = false;
        }

        private void yesButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void noButton_Clicked(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }

        private void checkBox_Checked(object sender, EventArgs e)
        {
            Properties.Settings.Default.SkipLogin = !Properties.Settings.Default.SkipLogin;
        }

        private void formClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Save();
        }
    }
}
