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
                Properties.Settings.Default.EllipticChildWidth = int.Parse(this.widthTextBox.Text);
            if(ellipcticRatioTextBox.Text.Length > 0)
                Properties.Settings.Default.EllipticChildRatio = float.Parse(this.ellipcticRatioTextBox.Text);
            if(heightTextBox.Text.Length > 0)
                Properties.Settings.Default.RectChildHeight = int.Parse(this.heightTextBox.Text);
            if (rectRatioTextBox.Text.Length > 0)
                Properties.Settings.Default.RectChildRatio = float.Parse(this.rectRatioTextBox.Text);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxInt_Validating(object sender, CancelEventArgs e)
        {
            if (((Control)sender).Text.Length > 0)
            {
                int input = 0;
                bool res = int.TryParse(((Control)sender).Text, out input);
                String message = "";
                if (sender.Equals(this.widthTextBox))
                    message = "Elliptic Child Width must be an integer value. Please correct the error.";
                else
                    message = "Rectangular Child Height must be an integer value. Please correct the error.";
                if (!res)
                {
                    //MessageBox.Show(message);
                    e.Cancel = true;
                }
            }
        }

        private void textBoxFloat_Validating(object sender, CancelEventArgs e)
        {
            if (((Control)sender).Text.Length > 0)
            {
                float input = 0;
                bool res = float.TryParse(((Control)sender).Text, out input);
                String message = "";
                if (sender.Equals(this.ellipcticRatioTextBox))
                    message = "Elliptic Width-Height Ratio must be a float value. Please correct the error.";
                else
                    message = "Rectangular Width-Height Ratio must be a float value. Please correct the error.";
                if (!res)
                {
                    MessageBox.Show(message);
                    e.Cancel = true;
                }
            }
        }

        public void hideApplyButton()
        {
            this.applyButton.Hide();
        }

        private void preferences_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape || e.KeyCode == Keys.X)
                this.Close();
        }
    }
}
