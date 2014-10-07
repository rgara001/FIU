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
            Control_Library.BaseDialogForm form = new Control_Library.BaseDialogForm();
            form.MdiParent = this;
            form.Show();
            
        }

    }
}
