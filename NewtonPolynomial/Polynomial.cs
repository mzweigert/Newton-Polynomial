using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace NewtonPolynomial
{
    public partial class Polynomial : Form
    {
        List<Node> nodesList = new List<Node>();
        List<double> resultList = new List<double>();
        int nodesCount;

        public Polynomial(List<Node> nodesList)
        {

            this.nodesList = nodesList;
            this.nodesCount = this.nodesList.Count;
            InitializeComponent();

            Newton newton = new Newton();
            resultList = newton.count(this.nodesList, nodesCount);

            Series series = new Series("function");
            Series nodesSeries = new Series("Nodes");

            series.ChartType = SeriesChartType.Spline;
            series.Color = Color.Blue;
            series.BorderWidth = 5;
      

            nodesSeries.ChartType = SeriesChartType.FastPoint;
            nodesSeries.Color = Color.OrangeRed;
            nodesSeries.MarkerSize = 10;

            for (int i = 0; i < this.nodesCount; i++)
            {
                series.Points.AddXY(this.nodesList[i].X, this.nodesList[i].Y);
                nodesSeries.Points.AddXY(this.nodesList[i].X, this.nodesList[i].Y);
            }

            this.polynomialChart.ChartAreas[0].AxisY.Minimum = nodesList.Min(node => node.Y) -5;
            this.polynomialChart.ChartAreas[0].AxisY.Maximum = nodesList.Max(node => node.Y) +5;
            this.polynomialChart.ChartAreas[0].AxisX.Minimum = nodesList.Min(node => node.X);
            this.polynomialChart.ChartAreas[0].AxisX.Maximum = nodesList.Max(node => node.X);

            this.polynomialChart.Legends.Add(new Legend());

            this.polynomialChart.Series.Add(series);
            
            this.polynomialChart.Series.Add(nodesSeries);
        }

        private void Polynomial_Resize(object sender, EventArgs e)
        {
            polynomialChart.Size = this.ClientSize;
        }
    }
}
