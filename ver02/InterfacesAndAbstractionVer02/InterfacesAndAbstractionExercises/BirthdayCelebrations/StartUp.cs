using BirthdayCelebrations.Classes;
using BirthdayCelebrations.Classes.Child;
using BirthdayCelebrations.Interfaces;
using BirthdayCelebrations.Interfaces.Child;
using BorderControl.Classes.Chird;
using BorderControl.Interfaces.Child;
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
            do
            {
                var inputCommand = Console.ReadLine();
                if (inputCommand == "End")
                {
                    break;
                }
                var inputData = inputCommand
                    .Split(new[] { ' ' });
                ITownsman townsman;
                string birthdate;
                switch (inputData[0])
                {
                    case "Robot":
                        var model = inputData[1];
                        townsman = new Townsman(inputData[2]);
                        IRobot robot = new Robot(model, townsman);
                        townsmenList.Add(robot);
                        break;
                    case "Pet":
                        var petName = inputData[1];
                        birthdate = inputData[2];
                        Pet pet = new Pet(petName, birthdate);
                        birthdatesList.Add(pet);
                        break;

                    case "Citizen":
                        var name = inputData[1];
                        var age = int.Parse(inputData[2]);
                        townsman = new Townsman(inputData[3]);
                        birthdate = inputData[4];
                        Citizen citizen = new Citizen(name, age, townsman,birthdate);
                        townsmenList.Add(citizen);
                        birthdatesList.Add(citizen);
                        break;
                    default:
                        break;
                }

            } while (true);
            var inputFilter = Console.ReadLine();
            //foreach (var item in townsmenList)
            //{

            //    if (item.ID.EndsWith(inputFilter))
            //    {
            //        Console.WriteLine(item.ID);
            //    }
            //}

            foreach (var birthdate in birthdatesList)
            {
                if (birthdate.Date.EndsWith(inputFilter))
                {
                    Console.WriteLine(birthdate.Date); 
                }
            }
        }
    }
}
