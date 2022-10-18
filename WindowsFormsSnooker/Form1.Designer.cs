namespace WindowsFormsSnooker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView_Versenyzok = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_Update = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown_Nyeremeny = new System.Windows.Forms.NumericUpDown();
            this.comboBox_Orszag = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_helyezes = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNev = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Versenyzok)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Nyeremeny)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Versenyzok
            // 
            this.dataGridView_Versenyzok.AllowUserToAddRows = false;
            this.dataGridView_Versenyzok.AllowUserToDeleteRows = false;
            this.dataGridView_Versenyzok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Versenyzok.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView_Versenyzok.Location = new System.Drawing.Point(0, 89);
            this.dataGridView_Versenyzok.Name = "dataGridView_Versenyzok";
            this.dataGridView_Versenyzok.ReadOnly = true;
            this.dataGridView_Versenyzok.Size = new System.Drawing.Size(662, 361);
            this.dataGridView_Versenyzok.TabIndex = 0;
            this.dataGridView_Versenyzok.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_Versenyzok_ColumnHeaderMouseClick);
            this.dataGridView_Versenyzok.SelectionChanged += new System.EventHandler(this.dataGridView_Versenyzok_SelectionChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(239)))), ((int)(((byte)(206)))));
            this.groupBox1.Controls.Add(this.button_Update);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.numericUpDown_Nyeremeny);
            this.groupBox1.Controls.Add(this.comboBox_Orszag);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox_helyezes);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxNev);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(97)))), ((int)(((byte)(0)))));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(662, 91);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Versenyző adatai";
            // 
            // button_Update
            // 
            this.button_Update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(97)))), ((int)(((byte)(0)))));
            this.button_Update.ForeColor = System.Drawing.Color.White;
            this.button_Update.Location = new System.Drawing.Point(545, 37);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(103, 38);
            this.button_Update.TabIndex = 8;
            this.button_Update.Text = "Módosít";
            this.button_Update.UseVisualStyleBackColor = false;
            this.button_Update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(405, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nyeremény";
            // 
            // numericUpDown_Nyeremeny
            // 
            this.numericUpDown_Nyeremeny.Location = new System.Drawing.Point(397, 48);
            this.numericUpDown_Nyeremeny.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numericUpDown_Nyeremeny.Name = "numericUpDown_Nyeremeny";
            this.numericUpDown_Nyeremeny.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_Nyeremeny.TabIndex = 6;
            this.numericUpDown_Nyeremeny.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown_Nyeremeny.ThousandsSeparator = true;
            // 
            // comboBox_Orszag
            // 
            this.comboBox_Orszag.FormattingEnabled = true;
            this.comboBox_Orszag.Items.AddRange(new object[] {
            "Anglia\t",
            "Ausztrália\t",
            "Belgium\t",
            "Ciprus\t",
            "Észak-Írország\t",
            "Hong Kong\t",
            "Irán\t",
            "Írország\t",
            "Kína\t",
            "Lengyelország\t",
            "Malajzia\t",
            "Norvégia\t",
            "Skócia\t",
            "Svájc\t",
            "Thaiföld\t",
            "Wales\t"});
            this.comboBox_Orszag.Location = new System.Drawing.Point(248, 47);
            this.comboBox_Orszag.Name = "comboBox_Orszag";
            this.comboBox_Orszag.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Orszag.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(253, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ország";
            // 
            // textBox_helyezes
            // 
            this.textBox_helyezes.Location = new System.Drawing.Point(9, 48);
            this.textBox_helyezes.Name = "textBox_helyezes";
            this.textBox_helyezes.ReadOnly = true;
            this.textBox_helyezes.Size = new System.Drawing.Size(100, 20);
            this.textBox_helyezes.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Helyezés";
            // 
            // textBoxNev
            // 
            this.textBoxNev.Location = new System.Drawing.Point(131, 48);
            this.textBoxNev.Name = "textBoxNev";
            this.textBoxNev.ReadOnly = true;
            this.textBoxNev.Size = new System.Drawing.Size(100, 20);
            this.textBoxNev.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Név";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView_Versenyzok);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Snooker top 100";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Versenyzok)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Nyeremeny)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Versenyzok;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown_Nyeremeny;
        private System.Windows.Forms.ComboBox comboBox_Orszag;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_helyezes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNev;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Update;
    }
}

