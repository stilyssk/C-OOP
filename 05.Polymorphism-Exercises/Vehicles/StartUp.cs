using System;
using System.Linq;

namespace Vehicles
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string inputCarInformation = Console.ReadLine();
            var listOfCarInformation = inputCarInformation
                .Split(new[] { ' ' })
                .ToList();
            Car car = new Car(double.Parse(listOfCarInformation[1]), double.Parse(listOfCarInformation[2]));
            string inputTruckInformation = Console.ReadLine();
            var listOfTruckInformation = inputTruckInformation
                .Split(new[] { ' ' })
                .ToList();
            Truck truck = new Truck(double.Parse(listOfTruckInformation[1]), double.Parse(listOfTruckInformation[2]));
            int repeat = int.Parse(Console.ReadLine());
            for (int i = 0; i < repeat; i++)
            {
                string inputCommand = Console.ReadLine();
                var vehicleCommand = inputCommand
                    .Split(new[] { ' ' })
                    .ToList();

                switch (vehicleCommand[0])
                {
                    case "Drive":
                        if (vehicleCommand[1]== "Car")
                        {
                            Console.WriteLine(car.Drive(double.Parse(vehicleCommand[2]))); ;
                        }
                        else if (vehicleCommand[1] == "Truck")
                        {
                            Console.WriteLine(truck.Drive(double.Parse(vehicleCommand[2]))); ;
                        }
                        break;
                    case "Refuel":
                        if (vehicleCommand[1] == "Car")
                        {
                            car.Refuel(double.Parse(vehicleCommand[2])); 
                        }
                        else if (vehicleCommand[1] == "Truck")
                        {
                            truck.Refuel(double.Parse(vehicleCommand[2])); 
                        }
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine($"{car:f2}");
            Console.WriteLine($"{truck:f2}");
        }
    }
}
