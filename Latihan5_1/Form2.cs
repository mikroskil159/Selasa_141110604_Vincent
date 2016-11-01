using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan5_1
{
    public partial class Form2 : Form
    {
        Form1 parentform;
        public Form2(Form1 pf)
        {
            InitializeComponent();
            parentform = pf;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
            foreach (KnownColor bg_color in Enum.GetValues(typeof(KnownColor)))
            {
                bgcolor.Items.Add(bg_color);
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            parentform.RTparent = Color.FromName(bgcolor.SelectedItem.ToString());
        }
    }
}
