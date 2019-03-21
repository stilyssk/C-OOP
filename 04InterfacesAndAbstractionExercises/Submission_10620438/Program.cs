namespace Telephony
{using System;

    public class Program
    {
        static void Main(string[] args)
        {
            string inputNumber = Console.ReadLine();
            string inputUrl = Console.ReadLine();

            Smartphone smartphone = new Smartphone(inputNumber, inputUrl);
            Console.Write(smartphone.PrintCalling());
            Console.Write(smartphone.PrintBrowsing());

        }
    }
}
