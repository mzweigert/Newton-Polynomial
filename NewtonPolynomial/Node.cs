using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewtonPolynomial
{
    public class Node : IComparable<Node>
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Node(){ }

        public Node(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }

        public int CompareTo(Node other)
        {
            throw new NotImplementedException();
        }
    }
}
