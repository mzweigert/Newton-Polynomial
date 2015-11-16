namespace NewtonPolynomial
{
    partial class Main
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
            this.dalej = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bTextBox = new System.Windows.Forms.NumericUpDown();
            this.aTextBox = new System.Windows.Forms.NumericUpDown();
            this.nTextBox = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.bTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nTextBox)).BeginInit();
            this.SuspendLayout();
            // 
            // dalej
            // 
            this.dalej.Location = new System.Drawing.Point(83, 205);
            this.dalej.Name = "dalej";
            this.dalej.Size = new System.Drawing.Size(158, 23);
            this.dalej.TabIndex = 13;
            this.dalej.Text = "dalej";
            this.dalej.UseVisualStyleBackColor = true;
            this.dalej.Click += new System.EventHandler(this.dalej_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "b:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "a:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "N:";
            // 
            // bTextBox
            // 
            this.bTextBox.DecimalPlaces = 2;
            this.bTextBox.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.bTextBox.Location = new System.Drawing.Point(83, 137);
            this.bTextBox.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.bTextBox.Name = "bTextBox";
            this.bTextBox.Size = new System.Drawing.Size(158, 20);
            this.bTextBox.TabIndex = 9;
            this.bTextBox.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // aTextBox
            // 
            this.aTextBox.DecimalPlaces = 2;
            this.aTextBox.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.aTextBox.Location = new System.Drawing.Point(83, 83);
            this.aTextBox.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.aTextBox.Name = "aTextBox";
            this.aTextBox.Size = new System.Drawing.Size(158, 20);
            this.aTextBox.TabIndex = 8;
            // 
            // nTextBox
            // 
            this.nTextBox.Location = new System.Drawing.Point(83, 33);
            this.nTextBox.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nTextBox.Name = "nTextBox";
            this.nTextBox.Size = new System.Drawing.Size(158, 20);
            this.nTextBox.TabIndex = 7;
            this.nTextBox.Value = new decimal(new int[] {
            11,
            0,
            0,
            0});
            // 
            // NewtonPolynomial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.dalej);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bTextBox);
            this.Controls.Add(this.aTextBox);
            this.Controls.Add(this.nTextBox);
            this.Name = "NewtonPolynomial";
            this.Text = "Newton Polynomial";
            ((System.ComponentModel.ISupportInitialize)(this.bTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nTextBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button dalej;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown bTextBox;
        private System.Windows.Forms.NumericUpDown aTextBox;
        private System.Windows.Forms.NumericUpDown nTextBox;
    }
}

