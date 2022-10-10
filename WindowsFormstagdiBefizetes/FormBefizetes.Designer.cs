namespace WindowsFormstagdiBefizetes
{
    partial class FormBefizetes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBefizetes));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_UgyfelNeve = new System.Windows.Forms.TextBox();
            this.numericUpDown_Befizetes = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.button_Insert = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Befizetes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ügyfé neve";
            // 
            // textBox_UgyfelNeve
            // 
            this.textBox_UgyfelNeve.Location = new System.Drawing.Point(98, 26);
            this.textBox_UgyfelNeve.Name = "textBox_UgyfelNeve";
            this.textBox_UgyfelNeve.ReadOnly = true;
            this.textBox_UgyfelNeve.Size = new System.Drawing.Size(139, 20);
            this.textBox_UgyfelNeve.TabIndex = 1;
            // 
            // numericUpDown_Befizetes
            // 
            this.numericUpDown_Befizetes.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDown_Befizetes.Location = new System.Drawing.Point(277, 26);
            this.numericUpDown_Befizetes.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDown_Befizetes.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDown_Befizetes.Name = "numericUpDown_Befizetes";
            this.numericUpDown_Befizetes.Size = new System.Drawing.Size(157, 20);
            this.numericUpDown_Befizetes.TabIndex = 2;
            this.numericUpDown_Befizetes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown_Befizetes.ThousandsSeparator = true;
            this.numericUpDown_Befizetes.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(441, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ft";
            // 
            // button_Insert
            // 
            this.button_Insert.Location = new System.Drawing.Point(490, 25);
            this.button_Insert.Name = "button_Insert";
            this.button_Insert.Size = new System.Drawing.Size(75, 23);
            this.button_Insert.TabIndex = 4;
            this.button_Insert.Text = "Befizetem";
            this.button_Insert.UseVisualStyleBackColor = true;
            this.button_Insert.Click += new System.EventHandler(this.button_Insert_Click);
            // 
            // FormBefizetes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 87);
            this.Controls.Add(this.button_Insert);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown_Befizetes);
            this.Controls.Add(this.textBox_UgyfelNeve);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormBefizetes";
            this.Load += new System.EventHandler(this.FormBefizetes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Befizetes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_UgyfelNeve;
        private System.Windows.Forms.NumericUpDown numericUpDown_Befizetes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_Insert;
    }
}