namespace P04_HotelReservation
{
    using System;

    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] inputCommand = Console.ReadLine()
                .Split();
            PriceCalculator priceCalculator = new PriceCalculator(inputCommand);
            Console.WriteLine($"{priceCalculator.Print():f2}");
        }
    }
}
