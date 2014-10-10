using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaulGaray_Hw1
{
    interface IChildShapes
    {
        void prepareWindow(int width, float ratio);
        void child_Paint(object sender, PaintEventArgs e);
    }
}
