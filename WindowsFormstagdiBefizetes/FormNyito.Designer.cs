namespace WindowsFormstagdiBefizetes
{
    partial class FormNyito
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNyito));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ügyfelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lekérdezésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.törlésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.újToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.módosításToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.befizetésekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.törlésToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.befizetésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox_Ugyfelek = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ügyfelToolStripMenuItem,
            this.befizetésekToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(290, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ügyfelToolStripMenuItem
            // 
            this.ügyfelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lekérdezésToolStripMenuItem,
            this.törlésToolStripMenuItem,
            this.újToolStripMenuItem,
            this.módosításToolStripMenuItem});
            this.ügyfelToolStripMenuItem.Name = "ügyfelToolStripMenuItem";
            this.ügyfelToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ügyfelToolStripMenuItem.Text = "Ügyfel";
            // 
            // lekérdezésToolStripMenuItem
            // 
            this.lekérdezésToolStripMenuItem.Name = "lekérdezésToolStripMenuItem";
            this.lekérdezésToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.lekérdezésToolStripMenuItem.Text = "Lekérdezés";
            // 
            // törlésToolStripMenuItem
            // 
            this.törlésToolStripMenuItem.Name = "törlésToolStripMenuItem";
            this.törlésToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.törlésToolStripMenuItem.Text = "Törlés";
            // 
            // újToolStripMenuItem
            // 
            this.újToolStripMenuItem.Name = "újToolStripMenuItem";
            this.újToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.újToolStripMenuItem.Text = "Új";
            // 
            // módosításToolStripMenuItem
            // 
            this.módosításToolStripMenuItem.Name = "módosításToolStripMenuItem";
            this.módosításToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.módosításToolStripMenuItem.Text = "Módosítás";
            // 
            // befizetésekToolStripMenuItem
            // 
            this.befizetésekToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.törlésToolStripMenuItem1,
            this.befizetésToolStripMenuItem});
            this.befizetésekToolStripMenuItem.Name = "befizetésekToolStripMenuItem";
            this.befizetésekToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.befizetésekToolStripMenuItem.Text = "Befizetések";
            // 
            // törlésToolStripMenuItem1
            // 
            this.törlésToolStripMenuItem1.Name = "törlésToolStripMenuItem1";
            this.törlésToolStripMenuItem1.Size = new System.Drawing.Size(120, 22);
            this.törlésToolStripMenuItem1.Text = "Törlés";
            // 
            // befizetésToolStripMenuItem
            // 
            this.befizetésToolStripMenuItem.Name = "befizetésToolStripMenuItem";
            this.befizetésToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.befizetésToolStripMenuItem.Text = "Befizetés";
            this.befizetésToolStripMenuItem.Click += new System.EventHandler(this.befizetésToolStripMenuItem_Click);
            // 
            // listBox_Ugyfelek
            // 
            this.listBox_Ugyfelek.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox_Ugyfelek.FormattingEnabled = true;
            this.listBox_Ugyfelek.Location = new System.Drawing.Point(0, 24);
            this.listBox_Ugyfelek.Name = "listBox_Ugyfelek";
            this.listBox_Ugyfelek.Size = new System.Drawing.Size(290, 261);
            this.listBox_Ugyfelek.TabIndex = 1;
            // 
            // FormNyito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 285);
            this.Controls.Add(this.listBox_Ugyfelek);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormNyito";
            this.Text = "Tagdíjak nyilvántartása";
            this.Load += new System.EventHandler(this.FormNyito_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ügyfelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lekérdezésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem törlésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem újToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem módosításToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem befizetésekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem törlésToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem befizetésToolStripMenuItem;
        public System.Windows.Forms.ListBox listBox_Ugyfelek;
    }
}

