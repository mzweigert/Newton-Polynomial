using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace NewtonPolynomial
{
    public partial class InitializingY : Form
    {
        List<Node> initialNodes = new List<Node>();

        int indexOfListNodes = 0,
            nodesCount;

        public InitializingY(List<Node> initialNodes)
        {
            this.initialNodes = initialNodes;
            this.nodesCount = this.initialNodes.Count;
           
            InitializeComponent();
            yLabel.Text = "y0: ";

        }

        private void previous_Click(object sender, EventArgs e)
        {
           
            if (indexOfListNodes > 0)
            {
                next.Text = "Następny >";
                initialNodes[indexOfListNodes].Y = Convert.ToDouble(yTextBox.Value);
                indexOfListNodes--;
                yLabel.Text = "y" + indexOfListNodes.ToString() + ":";
                yTextBox.Value = Convert.ToDecimal(initialNodes[indexOfListNodes].Y);
            }
        }

        private void wypisz_Click(object sender, EventArgs e)
        {

            foreach(Node i in this.initialNodes)
            {
                Console.Write("{0:0.00##}, ",i.X);
                Console.Write("{0:0.00##}", i.Y);
                Console.WriteLine();
            }
        }

        private void next_Click(object sender, EventArgs e)
        {
            

            if (indexOfListNodes < nodesCount - 1)
            {
                initialNodes[indexOfListNodes].Y = Convert.ToDouble(yTextBox.Value);
                indexOfListNodes++;
                yLabel.Text = "y" + indexOfListNodes.ToString() + ":";
                yTextBox.Value = Convert.ToDecimal(initialNodes[indexOfListNodes].Y);
                if (indexOfListNodes == nodesCount - 1)
                {
                    next.Text = "Wylicz!";
                }

            }
            else
            {
                initialNodes[indexOfListNodes].Y = Convert.ToDouble(yTextBox.Value);

                this.Hide();
                Form init = new Polynomial(initialNodes);
                init.ShowDialog();
                this.Close();
            }
            
            
            
        }
    }
}
