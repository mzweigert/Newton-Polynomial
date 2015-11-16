namespace NewtonPolynomial
{
    partial class Polynomial
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            this.polynomialChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.polynomialChart)).BeginInit();
            this.SuspendLayout();
            // 
            // polynomialChart
            // 
            chartArea1.Name = "ChartArea1";
            this.polynomialChart.ChartAreas.Add(chartArea1);
            this.polynomialChart.Location = new System.Drawing.Point(1, 0);
            this.polynomialChart.Name = "polynomialChart";
            this.polynomialChart.Size = new System.Drawing.Size(743, 440);
            this.polynomialChart.TabIndex = 0;
            this.polynomialChart.Text = "polynomial";
            // 
            // Polynomial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 441);
            this.Controls.Add(this.polynomialChart);
            this.Name = "Polynomial";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Polynomial";
            this.Resize += new System.EventHandler(this.Polynomial_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.polynomialChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart polynomialChart;
    }
}