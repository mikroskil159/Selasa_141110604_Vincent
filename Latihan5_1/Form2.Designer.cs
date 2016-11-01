namespace Latihan5_1
{
    partial class Form2
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
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Background color");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Theme", new System.Windows.Forms.TreeNode[] {
            treeNode3});
            this.tree = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.bgcolor = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tree
            // 
            this.tree.Location = new System.Drawing.Point(13, 13);
            this.tree.Name = "tree";
            treeNode3.Name = "Node1";
            treeNode3.Text = "Background color";
            treeNode4.Name = "Node0";
            treeNode4.Text = "Theme";
            this.tree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4});
            this.tree.Size = new System.Drawing.Size(209, 425);
            this.tree.TabIndex = 0;
            this.tree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(249, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Background Color :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // bgcolor
            // 
            this.bgcolor.FormattingEnabled = true;
            this.bgcolor.Location = new System.Drawing.Point(400, 44);
            this.bgcolor.Name = "bgcolor";
            this.bgcolor.Size = new System.Drawing.Size(157, 28);
            this.bgcolor.TabIndex = 2;
            this.bgcolor.Text = "Choose";
            this.bgcolor.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(469, 401);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 37);
            this.button1.TabIndex = 3;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 446);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bgcolor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tree);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tree;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox bgcolor;
        private System.Windows.Forms.Button button1;
    }
}