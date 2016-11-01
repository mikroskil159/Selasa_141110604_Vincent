namespace Latihan_3_1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.style = new System.Windows.Forms.ComboBox();
            this.size = new System.Windows.Forms.ComboBox();
            this.color = new System.Windows.Forms.ComboBox();
            this.RT = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(27, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "B";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(87, 36);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 29);
            this.button2.TabIndex = 1;
            this.button2.Text = "I";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(148, 36);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(41, 29);
            this.button3.TabIndex = 2;
            this.button3.Text = "U";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // style
            // 
            this.style.FormattingEnabled = true;
            this.style.Location = new System.Drawing.Point(213, 37);
            this.style.Name = "style";
            this.style.Size = new System.Drawing.Size(193, 28);
            this.style.TabIndex = 3;
            this.style.Text = "Font";
            this.style.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // size
            // 
            this.size.FormattingEnabled = true;
            this.size.Location = new System.Drawing.Point(443, 36);
            this.size.Name = "size";
            this.size.Size = new System.Drawing.Size(88, 28);
            this.size.TabIndex = 4;
            this.size.Text = "2 px";
            this.size.SelectedIndexChanged += new System.EventHandler(this.size_SelectedIndexChanged_1);
            // 
            // color
            // 
            this.color.FormattingEnabled = true;
            this.color.Location = new System.Drawing.Point(567, 37);
            this.color.Name = "color";
            this.color.Size = new System.Drawing.Size(154, 28);
            this.color.TabIndex = 5;
            this.color.Text = "Color";
            this.color.SelectedIndexChanged += new System.EventHandler(this.color_SelectedIndexChanged_1);
            // 
            // RT
            // 
            this.RT.Location = new System.Drawing.Point(27, 98);
            this.RT.Name = "RT";
            this.RT.Size = new System.Drawing.Size(694, 306);
            this.RT.TabIndex = 6;
            this.RT.Text = "";
            this.RT.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 416);
            this.Controls.Add(this.RT);
            this.Controls.Add(this.color);
            this.Controls.Add(this.size);
            this.Controls.Add(this.style);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox style;
        private System.Windows.Forms.ComboBox size;
        private System.Windows.Forms.ComboBox color;
        private System.Windows.Forms.RichTextBox RT;
    }
}

