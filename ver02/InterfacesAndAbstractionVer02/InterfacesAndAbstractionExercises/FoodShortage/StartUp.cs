using FoodShortage.Classes;
using FoodShortage.Classes.Child;
using FoodShortage.Interfaces;
using FoodShortage.Interfaces.Child;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BorderControl
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<ITownsman> townsmenList = new List<ITownsman>();
            List<IBirthdate> birthdatesList = new List<IBirthdate>();
            List<IBuyer> buyers = new List<IBuyer>();
            var repeat = int.Parse(Console.ReadLine());
            for (int i = 0; i < repeat; i++)

            {
                var inputCommand = Console.ReadLine();
                var inputData = inputCommand
                    .Split(new[] { ' ' });
                string iD;
                string birthdate;
                switch (inputData.Length)
                {

                    case 4:
                        var name = inputData[0];
                        var age = int.Parse(inputData[1]);
                        iD = inputData[2];
                        birthdate = inputData[3];
                        Citizen citizen = new Citizen(name, age, iD,birthdate);
                        townsmenList.Add(citizen);
                        birthdatesList.Add(citizen);
                        buyers.Add(citizen);
                        break;
                    case 3:
                        var rebelName = inputData[0];
                        var rabelAge = int.Parse(inputData[1]);
                        var group = inputData[2];
                        Rebel rebel = new Rebel(rebelName, rabelAge, group);
                        buyers.Add(rebel);

                        break;
                    default:
                        break;
                }

            }

            do
            {
                var inputCommand = Console.ReadLine();
                if (inputCommand == "End")
                {
                    break;
                }

                if (buyers.Any(x=>x.Name==inputCommand))
                {
                    var index =buyers.FindIndex(x => x.Name == inputCommand);
                    buyers[index].BuyFood(); 
                }

            } while (true);

            Console.WriteLine(buyers.Sum(x => x.Food));

        }
    }
}
