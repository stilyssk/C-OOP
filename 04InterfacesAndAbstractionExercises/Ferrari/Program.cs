namespace Ferrari
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            string inputDriverName = Console.ReadLine();
            Ferrari newFerrari = new Ferrari(inputDriverName);
            Console.WriteLine(newFerrari);
        }
    }
}
