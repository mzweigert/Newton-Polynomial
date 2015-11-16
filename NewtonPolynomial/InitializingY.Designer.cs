using System.Collections.Generic;

namespace NewtonPolynomial
{
    partial class InitializingY
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
            this.yLabel = new System.Windows.Forms.Label();
            this.next = new System.Windows.Forms.Button();
            this.previous = new System.Windows.Forms.Button();
            this.yTextBox = new System.Windows.Forms.NumericUpDown();
            this.wypisz = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.yTextBox)).BeginInit();
            this.SuspendLayout();
            // 
            // yLabel
            // 
            this.yLabel.AutoSize = true;
            this.yLabel.Location = new System.Drawing.Point(28, 44);
            this.yLabel.Name = "yLabel";
            this.yLabel.Size = new System.Drawing.Size(14, 13);
            this.yLabel.TabIndex = 1;
            this.yLabel.Text = "Y";
            // 
            // next
            // 
            this.next.Location = new System.Drawing.Point(206, 114);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(77, 23);
            this.next.TabIndex = 2;
            this.next.Text = "Następny >";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // previous
            // 
            this.previous.Location = new System.Drawing.Point(12, 114);
            this.previous.Name = "previous";
            this.previous.Size = new System.Drawing.Size(75, 23);
            this.previous.TabIndex = 3;
            this.previous.Text = "< Poprzedni";
            this.previous.UseVisualStyleBackColor = true;
            this.previous.Click += new System.EventHandler(this.previous_Click);
            // 
            // yTextBox
            // 
            this.yTextBox.DecimalPlaces = 2;
            this.yTextBox.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.yTextBox.Location = new System.Drawing.Point(63, 44);
            this.yTextBox.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.yTextBox.Name = "yTextBox";
            this.yTextBox.Size = new System.Drawing.Size(200, 20);
            this.yTextBox.TabIndex = 9;
            // 
            // wypisz
            // 
            this.wypisz.Location = new System.Drawing.Point(63, 12);
            this.wypisz.Name = "wypisz";
            this.wypisz.Size = new System.Drawing.Size(198, 23);
            this.wypisz.TabIndex = 10;
            this.wypisz.Text = "Wypisz w konsoli";
            this.wypisz.UseVisualStyleBackColor = true;
            this.wypisz.Click += new System.EventHandler(this.wypisz_Click);
            // 
            // InitializingY
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 143);
            this.Controls.Add(this.wypisz);
            this.Controls.Add(this.yTextBox);
            this.Controls.Add(this.previous);
            this.Controls.Add(this.next);
            this.Controls.Add(this.yLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "InitializingY";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nwton polynomial";
            ((System.ComponentModel.ISupportInitialize)(this.yTextBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label yLabel;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Button previous;
        private System.Windows.Forms.NumericUpDown yTextBox;
        private System.Windows.Forms.Button wypisz;
    }
}