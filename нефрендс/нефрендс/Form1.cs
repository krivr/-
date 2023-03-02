using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace нефрендс
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int scroll = 0;
        private void vScrollBar1_Scroll_1(object sender, ScrollEventArgs e)
        {
            if (scroll == vScrollBar1.Value)
            {


                tabPage1.Location = new Point(tabPage1.Location.Y + 2);
            }
            else if (scroll < vScrollBar1.Value)
            {


                tabPage1.Location = new Point(tabPage1.Location.Y - 2);
            }
            else if (scroll > vScrollBar1.Value)
            {


                tabPage1.Location = new Point(tabPage1.Location.Y + 2);
            }
            scroll = vScrollBar1.Value;
        }

        private void vScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            
        }

        private void vScrollBar3_Scroll(object sender, ScrollEventArgs e)
        {
            
        }

        private void vScrollBar4_Scroll(object sender, ScrollEventArgs e)
        {
            
        }
        //
    }
}
