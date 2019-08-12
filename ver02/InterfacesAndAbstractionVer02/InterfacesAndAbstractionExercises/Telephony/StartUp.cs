using System;

namespace Telephony
{
    public class Program
    {
        static void Main(string[] args)
        {
            var inputNumbers = Console.ReadLine()
                .Split(new[] { ' ' });
            var inputSites = Console.ReadLine()
                .Split(new[] { ' ' });
            Smartphone smartphone = new Smartphone(inputNumbers, inputSites);
            foreach (var number in smartphone.Numbers)
            {
                Console.WriteLine(smartphone.Calling(number));
            }

            foreach (var site in smartphone.Sites)
            {
                Console.WriteLine(smartphone.Browsing(site));
            }
        }
    }
}
