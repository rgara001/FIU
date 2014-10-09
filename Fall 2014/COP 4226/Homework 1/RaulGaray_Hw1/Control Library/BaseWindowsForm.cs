using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_Library
{
    public partial class BaseWindowsForm : Form
    {
        public BaseWindowsForm()
        {
            InitializeComponent();
        }

        Point downPoint = Point.Empty;
        void BaseForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            downPoint = new Point(e.X, e.Y);
        }
        void BaseForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (downPoint == Point.Empty) return;
            Point location =
            new Point(
            this.Left + e.X - downPoint.X,
            this.Top + e.Y - downPoint.Y);
            this.Location = location;
        }
        void BaseForm_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            downPoint = Point.Empty;
        }

        private void color_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            dlg.ShowDialog();
            this.BackColor = dlg.Color;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
