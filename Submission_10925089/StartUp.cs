namespace P03_JediGalaxy
{
    using System;
    using System.Linq;
    public class StartUp
    {
        static void Main()
        {
            int[] dimestions = Console.ReadLine()
                .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int rowCount = dimestions[0];
            int columnCount = dimestions[1];
            IDoMagic doMagic = new DoMagic(rowCount, rowCount);

            Console.WriteLine(doMagic);

        }

        
    }
}
