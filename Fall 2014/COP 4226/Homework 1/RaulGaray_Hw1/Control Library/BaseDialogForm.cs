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
    public partial class BaseDialogForm : Form
    {
        public BaseDialogForm()
        {
            InitializeComponent();
        }

        public BaseDialogForm(Color parentBackColor, Image parentBackImage)
        {
            InitializeComponent();
            this.BackColor = parentBackColor;
            this.BackgroundImage = parentBackImage;
        }
        /*
        public Panel middlePanel
        {
            get { return this.MiddlePanel; }
            set { this.MiddlePanel = value; }
        }
        */
        private void courseInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
