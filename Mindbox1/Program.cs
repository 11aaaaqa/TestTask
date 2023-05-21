using System;

namespace Mindbox1
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(10);
            Console.WriteLine(circle.Square());

            Console.WriteLine(new string('-', 15));

            Triangle triangle = new Triangle(1,2,3);
            Console.WriteLine(triangle.Square());
            Console.WriteLine(triangle.IsRectangular());

            Console.WriteLine(new string('-', 15));

            Triangle triangle2 = new Triangle(5, 12, 13);
            Console.WriteLine(triangle2.Square());
            Console.WriteLine(triangle2.IsRectangular());

            Console.WriteLine(new string('-',15));

            Triangle triangle3 = new Triangle(2, 4, 5);
            Console.WriteLine(triangle3.Square());
            Console.WriteLine(triangle3.IsRectangular());

            Console.ReadLine();
        }
    }
}
