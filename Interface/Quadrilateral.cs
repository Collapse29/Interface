using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Quadrilateral : IGeometryFunctions
    {
        public Quadrilateral(Line a, Line b, Line c, Line d)
        {
            A = a;
            B = b;
            C = c;
            D = d;
        }
        public Line A { get; set; }
        public Line B { get; set; }
        public Line C { get; set; }
        public Line D { get; set; }

        public bool IsFigure()
        {
            if (A.End.X == B.Start.X && A.End.Y == B.Start.Y &&
            B.End.X == C.Start.X && B.End.Y == C.Start.Y &&
            C.End.X == D.Start.X && C.End.Y == D.Start.Y &&
            D.End.X == A.Start.X && D.End.Y == A.Start.Y)
            {
                return true;
            }
            return false;
        }

        public double Perimeter()
        {
            return A.Length() + B.Length() + C.Length() + D.Length();
        }

        public double Square()
        {
            Line y = new Line(B.End,A.Start);
            Triangle first = new Triangle(A,B,y);
            Triangle second = new Triangle(new Line(A.Start, B.End),C,D);
            double square = first.Square() + second.Square();
            return square;
        }
        public override string ToString()
        {
            return "Линия 1 - " + A.ToString() + " Линия 2 - " + B.ToString() + " Линия 3 - " + C.ToString() + " Линия 4 - " + D.ToString();
        }
    }
}
