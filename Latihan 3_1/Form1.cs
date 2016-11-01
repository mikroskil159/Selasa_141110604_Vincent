using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_3_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Font SelectedText_Font = RT.SelectionFont;
            if (SelectedText_Font != null)
                RT.SelectionFont = new Font(SelectedText_Font, SelectedText_Font.Style ^ FontStyle.Bold);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Font SelectedText_Font = RT.SelectionFont;
            if (SelectedText_Font != null)
                RT.SelectionFont = new Font(SelectedText_Font, SelectedText_Font.Style ^ FontStyle.Italic);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Font SelectedText_Font = RT.SelectionFont;
            if (SelectedText_Font != null)
                RT.SelectionFont = new Font(SelectedText_Font, SelectedText_Font.Style ^ FontStyle.Underline);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //fontfamily
            FontFamily[] fontfam = FontFamily.Families;
            foreach (FontFamily fam in fontfam)
                style.Items.Add(fam.Name);

            //fontcolor
            foreach (KnownColor fontcolor in Enum.GetValues(typeof(KnownColor)))
            {
                color.Items.Add(fontcolor);
            }

            //fontsize
            for (int i = 2; i <= 74; i += 2)
            {
                size.Items.Add(i + " px");
            }
        }
        

        private void color_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            RT.SelectionColor = Color.FromName(color.Text);
        }

        private void size_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            RT.SelectionFont = new System.Drawing.Font(RT.SelectionFont.FontFamily, Convert.ToInt32(size.Text.Split(' ')[0]), RT.SelectionFont.Style);
        }
    }
}
