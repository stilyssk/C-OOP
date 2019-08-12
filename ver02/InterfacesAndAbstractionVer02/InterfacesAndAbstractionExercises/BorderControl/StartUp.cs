using BorderControl.Classes;
using BorderControl.Classes.Chird;
using BorderControl.Interfaces;
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
            do
            {
                var inputCommand = Console.ReadLine();
                if (inputCommand == "End")
                {
                    break;
                }
                var inputData = inputCommand
                    .Split(new[] { ' ' });
                Townsman townsman;
                switch (inputData.Length)
                {
                    case 2:
                        var model = inputData[1];
                        townsman = new Townsman(inputData[1]);
                        IRobot robot = new Robot(model, townsman);
                        townsmenList.Add(robot);
                        break;
                    case 3:
                        var name = inputData[0];
                        var age = int.Parse(inputData[1]);
                        townsman = new Townsman(inputData[2]);
                        ICitizen citizen = new Citizen(name, age, townsman);
                        townsmenList.Add(citizen);
                        break;
                    default:
                        break;
                }

            } while (true);
            var inputFilter = Console.ReadLine();
            foreach (var item in townsmenList)
            {

                if (item.ID.EndsWith(inputFilter))
                {
                    Console.WriteLine(item.ID);
                }
            }
        }
    }
}
