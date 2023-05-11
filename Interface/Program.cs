
namespace Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point a = new Point(1,3);
            Point b = new Point(4, 6);

            Line q = new Line(a,b);
            Console.WriteLine(q.ToString());
            Console.WriteLine(q.Length());

        }
    }
}