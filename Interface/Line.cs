using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Line : ILine
    {
        public Line(Point a, Point b)
        {
            Start = a;
            End = b;
        }
        public Line(int x1, int y1, int x2, int y2)
        {
            Start = new Point(x1, y1);
            End = new Point(x2, y2);
        }
        public Point Start { get; set; }
        public Point End { get; set; }

        public double Length()
        {
            double q = Math.Pow((End.X - Start.X),2);
            double w = Math.Pow((End.Y - Start.Y), 2);
            double e = q + w;
            double r = Math.Sqrt(e);
            return r;
        }

        public override string ToString()
        {
            return Start.ToString() + " " + End.ToString();
        }
    }

}
