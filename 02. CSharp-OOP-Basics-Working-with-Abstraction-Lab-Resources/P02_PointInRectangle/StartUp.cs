using System;
using System.Linq;
using System.Text;

namespace P02_PointInRectangle
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var inputCoordinate = Console.ReadLine()
                .Split(new[] { ' ' })
                .Select(int.Parse)
                .ToArray();
            IPoint topLeft = new Point();
            topLeft.XCoordinate = inputCoordinate[0];
            topLeft.YCoordinate = inputCoordinate[1];
            IPoint bottomRight = new Point();
            bottomRight.XCoordinate = inputCoordinate[2];
            bottomRight.YCoordinate = inputCoordinate[3];
            IRectangle rectangle = new Rectangle(topLeft,bottomRight);

            int repeat = int.Parse(Console.ReadLine());
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < repeat; i++)
            {
                IPoint point = new Point();
                var pointCoordinate = Console.ReadLine()
                    .Split(new[] { ' ' })
                    .Select(int.Parse)
                    .ToArray();
                point.XCoordinate = pointCoordinate[0];
                point.YCoordinate = pointCoordinate[1];
                result.AppendLine(rectangle.Contains(point).ToString());
            }

            Console.WriteLine(result);
        }
    }
}
