namespace WindowsFormDolgozo
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
            this.listBox_Dolgozok = new System.Windows.Forms.ListBox();
            this.button_Insert = new System.Windows.Forms.Button();
            this.button_Update = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_Frissit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox_Dolgozok
            // 
            this.listBox_Dolgozok.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBox_Dolgozok.FormattingEnabled = true;
            this.listBox_Dolgozok.Location = new System.Drawing.Point(0, 0);
            this.listBox_Dolgozok.Name = "listBox_Dolgozok";
            this.listBox_Dolgozok.Size = new System.Drawing.Size(194, 220);
            this.listBox_Dolgozok.TabIndex = 0;
            // 
            // button_Insert
            // 
            this.button_Insert.Location = new System.Drawing.Point(240, 8);
            this.button_Insert.Name = "button_Insert";
            this.button_Insert.Size = new System.Drawing.Size(142, 36);
            this.button_Insert.TabIndex = 1;
            this.button_Insert.Text = "Új dolgozó";
            this.button_Insert.UseVisualStyleBackColor = true;
            this.button_Insert.Click += new System.EventHandler(this.button_Insert_Click);
            // 
            // button_Update
            // 
            this.button_Update.Location = new System.Drawing.Point(240, 53);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(142, 37);
            this.button_Update.TabIndex = 1;
            this.button_Update.Text = "Adatok módosítása";
            this.button_Update.UseVisualStyleBackColor = true;
            this.button_Update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(240, 99);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(142, 37);
            this.button_Delete.TabIndex = 1;
            this.button_Delete.Text = "Dolgozó törlése";
            this.button_Delete.UseVisualStyleBackColor = true;
            // 
            // button_Frissit
            // 
            this.button_Frissit.Location = new System.Drawing.Point(240, 142);
            this.button_Frissit.Name = "button_Frissit";
            this.button_Frissit.Size = new System.Drawing.Size(142, 37);
            this.button_Frissit.TabIndex = 1;
            this.button_Frissit.Text = "Listát frissít";
            this.button_Frissit.UseVisualStyleBackColor = true;
            this.button_Frissit.Click += new System.EventHandler(this.button_Frissit_Click);
            // 
            // FormNyito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 220);
            this.Controls.Add(this.button_Frissit);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.button_Update);
            this.Controls.Add(this.button_Insert);
            this.Controls.Add(this.listBox_Dolgozok);
            this.Name = "FormNyito";
            this.Text = "Dolgozók nyilvántartása";
            this.Activated += new System.EventHandler(this.FormNyito_Activated);
            this.Load += new System.EventHandler(this.FormNyito_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_Insert;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_Frissit;
        public System.Windows.Forms.ListBox listBox_Dolgozok;
    }
}

