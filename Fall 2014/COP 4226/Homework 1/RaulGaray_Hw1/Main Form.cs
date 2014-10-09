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
            Control_Library.BaseWindowsForm form = new Control_Library.BaseWindowsForm();
            form.MdiParent = this;
            form.Show();

            runAboutDialog();

            
        }

        private void runAboutDialog()
        {
            using (Control_Library.BaseDialogForm dlg = new Control_Library.BaseDialogForm())
            {
                Label description = new Label();
                description.Text = "This app opens child windows that are either ellipses or rectangles. One dimension ";
                description.Text += "(height or width) of each will be determined by a ratio that is set by the user. ";
                description.Text += "The child windows can have different colors and can be moved by the mouse.";
                description.AutoSize = false;
                description.Dock = DockStyle.Fill;
                description.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
                dlg.middlePanel.Controls.Add(description);
                dlg.ShowDialog();
            }
        }



    }
}
