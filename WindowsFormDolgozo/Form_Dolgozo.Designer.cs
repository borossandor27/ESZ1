namespace WindowsFormDolgozo
{
    partial class Form_Dolgozo
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.textBox_Nev = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerSzuletett = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown_Fizetes = new System.Windows.Forms.NumericUpDown();
            this.button_Muvelet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Fizetes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Azonosító";
            // 
            // textBox_ID
            // 
            this.textBox_ID.Location = new System.Drawing.Point(100, 23);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.ReadOnly = true;
            this.textBox_ID.Size = new System.Drawing.Size(118, 20);
            this.textBox_ID.TabIndex = 1;
            // 
            // textBox_Nev
            // 
            this.textBox_Nev.Location = new System.Drawing.Point(100, 80);
            this.textBox_Nev.Name = "textBox_Nev";
            this.textBox_Nev.Size = new System.Drawing.Size(118, 20);
            this.textBox_Nev.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Név";
            // 
            // dateTimePickerSzuletett
            // 
            this.dateTimePickerSzuletett.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerSzuletett.Location = new System.Drawing.Point(100, 143);
            this.dateTimePickerSzuletett.Name = "dateTimePickerSzuletett";
            this.dateTimePickerSzuletett.Size = new System.Drawing.Size(118, 20);
            this.dateTimePickerSzuletett.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Született";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fizetés";
            // 
            // numericUpDown_Fizetes
            // 
            this.numericUpDown_Fizetes.Location = new System.Drawing.Point(100, 209);
            this.numericUpDown_Fizetes.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.numericUpDown_Fizetes.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDown_Fizetes.Name = "numericUpDown_Fizetes";
            this.numericUpDown_Fizetes.Size = new System.Drawing.Size(118, 20);
            this.numericUpDown_Fizetes.TabIndex = 7;
            this.numericUpDown_Fizetes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown_Fizetes.ThousandsSeparator = true;
            this.numericUpDown_Fizetes.Value = new decimal(new int[] {
            240000,
            0,
            0,
            0});
            // 
            // button_Muvelet
            // 
            this.button_Muvelet.Location = new System.Drawing.Point(16, 263);
            this.button_Muvelet.Name = "button_Muvelet";
            this.button_Muvelet.Size = new System.Drawing.Size(202, 27);
            this.button_Muvelet.TabIndex = 8;
            this.button_Muvelet.Text = "button1";
            this.button_Muvelet.UseVisualStyleBackColor = true;
            this.button_Muvelet.Click += new System.EventHandler(this.button_Muvelet_Click);
            // 
            // Form_Dolgozo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 330);
            this.Controls.Add(this.button_Muvelet);
            this.Controls.Add(this.numericUpDown_Fizetes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePickerSzuletett);
            this.Controls.Add(this.textBox_Nev);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_ID);
            this.Controls.Add(this.label1);
            this.Name = "Form_Dolgozo";
            this.Text = "Form_Dolgozo";
            this.Load += new System.EventHandler(this.Form_Dolgozo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Fizetes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_ID;
        private System.Windows.Forms.TextBox textBox_Nev;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerSzuletett;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown_Fizetes;
        private System.Windows.Forms.Button button_Muvelet;
    }
}