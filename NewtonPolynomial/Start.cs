using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace NewtonPolynomial
{
    public partial class Start : Form
    {
        List<Node> initialNodes = new List<Node>();
        
        public Start()
        {
            InitializeComponent();
        }

        private void butNext_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(nTextBox.Value);
            double a = Convert.ToDouble(aTextBox.Value),
                   b = Convert.ToDouble(bTextBox.Value),
                   equidistantGrid;


            if (n <= 0)
                MessageBox.Show("N should be a greather than zero", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (a >= b)
                MessageBox.Show("A should be a lower than B", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {

                Node node = new Node();
                equidistantGrid = (b - a) / n; // SIATKA ROWNOODLEGŁA 
                n++; //ZWIEKSZAMY N PO TO ABY MIEC ILOSC WEZLOW


                while (a <= b)
                {
                    node = new Node();
                    node.X = a;
                    initialNodes.Add(node);
                    a += equidistantGrid;

                }

                this.Hide();
                Form init = new InitializingY(initialNodes);
                init.ShowDialog();
                this.Close();



            }
        }
    }
}
