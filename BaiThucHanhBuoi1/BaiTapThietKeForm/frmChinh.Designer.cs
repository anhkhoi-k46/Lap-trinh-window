namespace BaiTapThietKeForm
{
    partial class frmChinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChinh));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.họTênSinhViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btmlBai1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btmlBai2 = new System.Windows.Forms.ToolStripMenuItem();
            this.btmlBai3 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.họTênSinhViênToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // họTênSinhViênToolStripMenuItem
            // 
            this.họTênSinhViênToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btmlBai1,
            this.btmlBai2,
            this.btmlBai3});
            this.họTênSinhViênToolStripMenuItem.Name = "họTênSinhViênToolStripMenuItem";
            this.họTênSinhViênToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
            this.họTênSinhViênToolStripMenuItem.Text = "Họ tên sinh viên";
            // 
            // btmlBai1
            // 
            this.btmlBai1.Image = ((System.Drawing.Image)(resources.GetObject("btmlBai1.Image")));
            this.btmlBai1.Name = "btmlBai1";
            this.btmlBai1.Size = new System.Drawing.Size(180, 22);
            this.btmlBai1.Text = "Bài 1";
            this.btmlBai1.Click += new System.EventHandler(this.btmlBai1_Click);
            // 
            // btmlBai2
            // 
            this.btmlBai2.Image = ((System.Drawing.Image)(resources.GetObject("btmlBai2.Image")));
            this.btmlBai2.Name = "btmlBai2";
            this.btmlBai2.Size = new System.Drawing.Size(180, 22);
            this.btmlBai2.Text = "Bài 2";
            // 
            // btmlBai3
            // 
            this.btmlBai3.Image = ((System.Drawing.Image)(resources.GetObject("btmlBai3.Image")));
            this.btmlBai3.Name = "btmlBai3";
            this.btmlBai3.Size = new System.Drawing.Size(180, 22);
            this.btmlBai3.Text = "Bài 3";
            // 
            // frmChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmChinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Chương trình chính";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem họTênSinhViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btmlBai1;
        private System.Windows.Forms.ToolStripMenuItem btmlBai2;
        private System.Windows.Forms.ToolStripMenuItem btmlBai3;
    }
}

