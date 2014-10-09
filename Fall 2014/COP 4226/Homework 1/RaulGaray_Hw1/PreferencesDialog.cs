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
    public partial class PreferencesDialog : Control_Library.BaseDialogForm
    {
        public PreferencesDialog()
        {
            InitializeComponent();
            this.cancelButton.CausesValidation = false;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            applySettings();
            this.Close();
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            applySettings();
        }

        private void applySettings()
        {
            if(widthTextBox.Text.Length > 0)
                Properties.Settings.Default.EllipticChildWidth = Convert.ToInt32(this.widthTextBox.Text);
            if(ellipcticRatioTextBox.Text.Length > 0)
                Properties.Settings.Default.EllipticChildRatio = Convert.ToInt32(this.ellipcticRatioTextBox.Text);
            if(heightTextBox.Text.Length > 0)
                Properties.Settings.Default.RectChildHeight = Convert.ToInt32(this.heightTextBox.Text);
            if (rectRatioTextBox.Text.Length > 0)
                Properties.Settings.Default.RectChildRatio = Convert.ToInt32(this.rectRatioTextBox.Text);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxNumeric_Validating(object sender, CancelEventArgs e)
        {
            if (((Control)sender).Text.Length > 0)
            {
                int input = 0;
                bool res = int.TryParse(((Control)sender).Text, out input);
                if (!res)
                {
                    MessageBox.Show("Only numeric values accepted. Please correct the error.");
                    e.Cancel = true;
                }
            }
        }
    }
}
