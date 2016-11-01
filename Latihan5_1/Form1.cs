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
    public partial class Form1 : Form
    {
        private bool text;
        public Form1()
        {
            InitializeComponent();
            text = false;
        }
        public Color RTparent
        {
            get { return this.RT.BackColor; }
            set { this.RT.BackColor = value; }
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

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (text)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*|Rich Textbox Format (*.rtf)|*.rtf";
                save.FilterIndex = 3;
                save.RestoreDirectory = true;

                DialogResult result = MessageBox.Show("Save changes ?", "My Application", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    if (save.ShowDialog() == System.Windows.Forms.DialogResult.OK && save.FileName.Length > 0)
                    {
                       RT.SaveFile(save.FileName, RichTextBoxStreamType.PlainText);
                    }
                }
                else if (result == DialogResult.No)
                {
                    Application.ExitThread();
                }
            }
            else
            {
                Application.Exit();
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (text)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*|Rich Textbox Format (*.rtf)|*.rtf";
                save.FilterIndex = 3;
                save.RestoreDirectory = true;

                DialogResult result = MessageBox.Show("Save changes ?", "My Application", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    if (save.ShowDialog() == System.Windows.Forms.DialogResult.OK && save.FileName.Length > 0)
                    {
                        RT.SaveFile(save.FileName, RichTextBoxStreamType.PlainText);
                    }
                    RT.Clear();
                }
                else if (result == DialogResult.No)
                {
                   RT.Clear();
                }
            }
            else
            {
                RT.Clear();
            }
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*|Rich Textbox Format (*.rtf)|*.rtf";
            save.FilterIndex = 3;
            save.RestoreDirectory = true;

            if (save.ShowDialog() == System.Windows.Forms.DialogResult.OK && save.FileName.Length > 0)
            {
                RT.SaveFile(save.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void editorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 theme = new Form2(this);
            theme.MdiParent = this.ParentForm;
            theme.Show();
        }

        private void RT_TextChanged(object sender, EventArgs e)
        {
            text = true;
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.InitialDirectory = "c:\\";
            open.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*|Rich Textbox Format (*.rtf)|*.rtf";
            open.FilterIndex = 3;
            open.RestoreDirectory = true;

            if (open.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                RT.LoadFile(open.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void style_SelectedIndexChanged(object sender, EventArgs e)
        {
            RT.SelectionFont = new System.Drawing.Font(style.Text, RT.SelectionFont.Size, RT.SelectionFont.Style);
        }

        private void size_SelectedIndexChanged(object sender, EventArgs e)
        {
            RT.SelectionFont = new System.Drawing.Font(RT.SelectionFont.FontFamily, Convert.ToInt32(size.Text.Split(' ')[0]), RT.SelectionFont.Style);
        }

        private void color_SelectedIndexChanged(object sender, EventArgs e)
        {
            RT.SelectionColor = Color.FromName(color.Text);
        }
    }
    }

