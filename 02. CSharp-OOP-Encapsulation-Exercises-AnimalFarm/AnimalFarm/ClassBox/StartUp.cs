using System;

namespace ClassBox
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            double leght = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            try
            {
                Box box = new Box(height, width, leght);
                Console.WriteLine(box.CalculateSurfaceArea());
                Console.WriteLine(box.CalculateLateralSurfaceArea());
                Console.WriteLine(box.CalculateVolume());
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message); 
            }



        }
    }
}
