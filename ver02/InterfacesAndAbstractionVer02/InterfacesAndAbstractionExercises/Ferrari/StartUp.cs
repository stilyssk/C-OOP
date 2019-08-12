using System;

namespace Ferrari
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var inputDriverName = Console.ReadLine();
            IFerrari ferrari = new Ferrari(inputDriverName);
            Console.WriteLine(ferrari);
        }
    }
}
