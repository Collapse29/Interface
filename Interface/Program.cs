
namespace Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point a = new Point(1,3);
            Point b = new Point(2,6);
            Point c = new Point(3,3);
            Point d = new Point(2,1);

            Line q = new Line(a,b);
            Console.WriteLine(q.ToString());
            Console.WriteLine(q.Length());

            Line w = new Line(a,b);
            Line e = new Line(b,c);
            Line r = new Line(c, d);
            Line t = new Line(d,a);
            Triangle v = new Triangle(w,e,r);
           
            Quadrilateral f = new Quadrilateral(w,e,r,t);
            
            Method(v);
            Method(f);
            Method(f);
            Method(f);
            Method(f);
            Method(f);
            Method(f);
            Method(f);
            Method(f);
            Method(f);
            
        }

        static void Method(IGeometryFunctions geometryFunctions)
        {
            Console.WriteLine(geometryFunctions.Square());
            if (geometryFunctions is Quadrilateral)// проверка на тип
            {
                Console.WriteLine("Это четырехугольник");
                Quadrilateral h = geometryFunctions as Quadrilateral; // преобразование типа
                Console.WriteLine(h.A);
                Console.WriteLine(h.B);
                Console.WriteLine(h.C);
                Console.WriteLine(h.D);
                Console.WriteLine(h.ToString());
                Console.WriteLine("Это фигура или нет  " + h.IsFigure());
                Console.WriteLine("Площадь  " + h.Square());
                Console.WriteLine("Периметр  " + h.Perimeter());
            }
            else if (geometryFunctions is Triangle)
            {
                Console.WriteLine("Это треугольник");
                Triangle v = geometryFunctions as Triangle;
                Console.WriteLine(v.A);
                Console.WriteLine(v.B);
                Console.WriteLine(v.C);
                Console.WriteLine(v.ToString());
                Console.WriteLine("Это фигура или нет  " + v.IsFigure());
                Console.WriteLine("Площадь  " + v.Square());
                Console.WriteLine("Периметр  " + v.Perimeter());
            }
        } 
    }
}