using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace RaulGaray_Hw1
{
    public partial class EllipticChild : Control_Library.BaseWindowsForm, IChildShapes
    {
        public EllipticChild()
        {
            InitializeComponent();
        }

        public EllipticChild(int width, float ratio)
        {
            InitializeComponent();
            prepareWindow(width, ratio);
        }

        public void prepareWindow(int width, float ratio)
        {
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.FormBorderStyle = FormBorderStyle.None;
            this.ClientSize = new System.Drawing.Size(width, Convert.ToInt32(width * ratio));
            this.BackColor = System.Drawing.Color.Aqua;
        }

        public void child_Paint(object sender, PaintEventArgs e)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(this.ClientRectangle);
            Region region = new Region(path);
            this.Region = region;
        }
    }
}
