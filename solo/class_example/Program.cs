using System;
using Shapes;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle(8,4);
            Console.WriteLine($"area: {r1.Area()},perimeter: {r1.Perimeter()}");
            Square s1 = new Square(4);
            Console.WriteLine($"{s1.Area()}");
            Cube c1 = new Cube(6);
            Console.WriteLine($"Volume {c1.Volume()}");
        }
    }
}
