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
    public partial class MainForm : Form
    {
        public MainForm()
        {
                InitializeComponent();
        }

        private void openPreferencesModally_Click(object sender, EventArgs e)
        {
            PreferencesDialog dlg = new PreferencesDialog();
            dlg.hideApplyButton();
            dlg.ShowDialog();
            dlg.Dispose();
        }

        private void openPreferencesModelessly_Click(object sender, EventArgs e)
        {
            bool formOpen = false;
            foreach (Form form in Application.OpenForms)
                if (form is PreferencesDialog)
                    formOpen = true;
            if (!formOpen)
            {
                PreferencesDialog dlg = new PreferencesDialog();
                dlg.Show(this);
            }
            else
                MessageBox.Show("Error: Cannot open. A Preferences dialog is already open.");
            

        }

        private void openEllipticChild_Click(object sender, EventArgs e)
        {
            EllipticChild dlg = new EllipticChild(Properties.Settings.Default.EllipticChildWidth, Properties.Settings.Default.EllipticChildRatio);
            dlg.MdiParent = this;
            dlg.Show();
        }

        private void openRectChild_Click(object sender, EventArgs e)
        {
            RectangularChild dlg = new RectangularChild(Properties.Settings.Default.RectChildHeight, Properties.Settings.Default.RectChildRatio);
            dlg.MdiParent = this;
            dlg.Show();
        }



        private void MainForm_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = false;
        }

        private void oathToolStripItem_Click(object sender, EventArgs e)
        {
            Control_Library.OathDialog dlg = new Control_Library.OathDialog();
            int xLoc = this.Location.X + this.Size.Width;
            int yLoc = this.Location.Y;
            dlg.Location = new Point(xLoc, yLoc);
            dlg.ShowDialog(this);
        }

        private void aboutToolStripItem_Click(object sender, EventArgs e)
        {

            bool formOpen = false;
            foreach (Form form in Application.OpenForms)
                if (form is AboutDialog)
                    formOpen = true;
            if (!formOpen)
            {
                AboutDialog dlg = new AboutDialog();
                int xLoc = this.Location.X;
                int yLoc = this.Location.Y + this.Size.Height;
                dlg.Location = new Point(xLoc, yLoc);
                dlg.Show();
            }
            else
                MessageBox.Show("Error: Cannot open. An About dialog is already open.");
        }

        private void mainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to exit?", "Exit Program?", MessageBoxButtons.YesNo);
            if (res == DialogResult.No)
                e.Cancel = true;
        }

        private void statusBar_Activate(object sender, EventArgs e)
        {
            if (ActiveMdiChild is EllipticChild)
                this.toolStripStatusLabel.Text = "Ellipse";
            if (ActiveMdiChild is RectangularChild)
                this.toolStripStatusLabel.Text = "Rectangle";
        }

        private void savePreferences_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
        }

        private void reloadPreferences_Clicked(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reload();
        }

        private void resetPreferences_Clicked(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reset();
        }

        private void closeApplication_Clicked(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
