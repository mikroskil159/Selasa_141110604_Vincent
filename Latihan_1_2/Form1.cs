using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_1_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            vScrollBar1.Value = ((VScrollBar)sender).Value;
            label1.Text = ((VScrollBar)sender).Value.ToString(); 
        }

        private void vScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            vScrollBar2.Value = ((VScrollBar)sender).Value;
            label2.Text = ((VScrollBar)sender).Value.ToString();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(label1.Text);
            int y = Convert.ToInt32(label2.Text);

            int z = Math.Abs(x - y);

            if (z != 0)
            {
                dateTimePicker1.MinDate = DateTime.Now.AddYears(-(z));
                dateTimePicker1.MaxDate = DateTime.Now.AddYears(z);


            }
            else {
                dateTimePicker1.MinDate = DateTime.Now;
                dateTimePicker1.MaxDate = DateTime.Now;

            }
        }
    }
}
