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
            Car car = new Car(double.Parse(listOfCarInformation[1]), double.Parse(listOfCarInformation[2]), double.Parse(listOfCarInformation[3]));
            string inputTruckInformation = Console.ReadLine();
            var listOfTruckInformation = inputTruckInformation
                .Split(new[] { ' ' })
                .ToList();

            Truck truck = new Truck(double.Parse(listOfTruckInformation[1]), double.Parse(listOfTruckInformation[2]), double.Parse(listOfTruckInformation[3]));
            string inputBusInformation = Console.ReadLine();
            var listOfBusInformation = inputBusInformation
                .Split(new[] { ' ' })
                .ToList();
            Bus bus = new Bus(double.Parse(listOfBusInformation[1]), double.Parse(listOfBusInformation[2]), double.Parse(listOfBusInformation[3]));
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
                            Console.WriteLine(car.Drive(double.Parse(vehicleCommand[2]))); 
                        }
                        else if (vehicleCommand[1] == "Truck")
                        {
                            Console.WriteLine(truck.Drive(double.Parse(vehicleCommand[2]))); 
                        }
                        else if (vehicleCommand[1] == "Bus")
                        {
                            Console.WriteLine(bus.Drive(double.Parse(vehicleCommand[2])));
                        }
                        break;
                    case "Refuel":
                        if (vehicleCommand[1] == "Car")
                        {
                            try
                            {
                                car.Refuel(double.Parse(vehicleCommand[2]));

                            }
                            catch (Exception ex)
                            {

                                Console.WriteLine(ex.Message);
                            }
                        }
                        else if (vehicleCommand[1] == "Truck")
                        {
                            try
                            {
                                truck.Refuel(double.Parse(vehicleCommand[2]));

                            }
                            catch (Exception ex)
                            {

                                Console.WriteLine(ex.Message);
                            }
                        }
                        else if (vehicleCommand[1] == "Bus")
                        {
                            try
                            {
                                bus.Refuel(double.Parse(vehicleCommand[2]));

                            }
                            catch (Exception ex)
                            {

                                Console.WriteLine(ex.Message);
                            }
                        }
                        break;
                    case "DriveEmpty":
                        Console.WriteLine(bus.DriveEmpty(double.Parse(vehicleCommand[2])));
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine($"{car:f2}");
            Console.WriteLine($"{truck:f2}");
            Console.WriteLine($"{bus:f2}");

        }
    }
}
