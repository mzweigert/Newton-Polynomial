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
using System.IO;

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

            string python = PolyCount();
            


            Series series = new Series(ExecutePython(python));
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

        private string ExecutePython(string python)
        {
            string script = "from sympy import *\nx, y, z = symbols('x y z')\ninit_printing(use_unicode=True)\nwynik = expand(" + python + ")\nf = open( 'wynik.txt', 'w' )\nf.write( str(wynik) )\nf.close()";

            using (StreamWriter sw = new StreamWriter("skrypt.py"))
            {
                sw.Write(script);
            }

            string strCmdText = "/C python " + AppDomain.CurrentDomain.BaseDirectory + "skrypt.py";
            System.Diagnostics.Process.Start("CMD.exe", strCmdText);

            using (StreamReader sr = new StreamReader("wynik.txt"))
            {
                string line = string.Empty;

                line = sr.ReadLine();

                line = line.Replace("**", "^");

                return line;
            }
        }

        private string PolyCount()
        {
            List<double> listEnding = new List<double>();

            int n = 0;


            for (int i = 0; i < nodesList.Count; i++)
            {
              

                listEnding.Add(resultList[n]);
                n += nodesList.Count - i;
            }

            string python = String.Empty;

            for (int i = 0; i < listEnding.Count; i++)
            {
                if (listEnding[i] >= 0 && i != 0)
                    python += "+";
                python += listEnding[i];

                for (int j = 0; j < i; j++)
                {
                    if (nodesList[j].X < 0)
                        python += "*(x +";
                    else
                        python += "*(x -";
                    python += nodesList[j].X + ")";

                }

            }

            python = python.Replace(",", ".");

            return python;
        }

        private void Polynomial_Resize(object sender, EventArgs e)
        {
            polynomialChart.Size = this.ClientSize;
        }
    }
}
