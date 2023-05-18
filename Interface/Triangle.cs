using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Triangle : IGeometryFunctions
    {
        public Triangle(Line a, Line b, Line c)
        {
            A = a;
            B = b;
            C = c;
        }
        public Line A { get; set; }
        public Line B { get; set; }
        public Line C { get; set; }

        public bool IsFigure()
        {
            if (A.End.X == B.Start.X && A.End.Y == B.Start.Y && 
                B.End.X == C.Start.X && B.End.Y == C.Start.Y &&
                C.End.X == A.Start.X && C.End.Y == A.Start.Y)
            {
                return true;
            }
            return false;
        }

        public double Perimeter()
        {
            return A.Length()+B.Length()+C.Length();
        }

        public double Square()
        {
            double cosA = (Math.Pow(B.Length(), 2) + Math.Pow(C.Length(), 2) - Math.Pow(A.Length(), 2)) / (2*B.Length()*C.Length());
            double sinA = Math.Sqrt(1 - Math.Pow(cosA,2));
            return 0.5 * A.Length() * C.Length() * (sinA);
        }
        public override string ToString()
        {
            return "Линия 1 - " + A.ToString() + " Линия 2 - " + B.ToString() + " Линия 3 - " + C.ToString();
        }
    }
}
