using System;

namespace Shapes
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var circle = new Circle(10);
            var rectangle = new Rectangle(3.5, 2.6);
            Console.WriteLine(circle.CalculateArea());
            Console.WriteLine(circle.CalculatePerimeter());
            Console.WriteLine(circle.Draw());

            Console.WriteLine(rectangle.CalculateArea());
            Console.WriteLine(rectangle.CalculatePerimeter());
            Console.WriteLine(rectangle.Draw());
        }
    }
}
