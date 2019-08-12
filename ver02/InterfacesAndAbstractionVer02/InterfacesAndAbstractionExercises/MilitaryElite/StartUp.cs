using MilitaryElite.Class.Silders;
using MilitaryElite.Class.Silders.Privates;
using MilitaryElite.Class.Silders.Privates.SpecialisedSoldiers;
using MilitaryElite.Class.Silders.Privates.SpecialisedSoldiers.Commandos;
using MilitaryElite.Class.Silders.Privates.SpecialisedSoldiers.Engineers;
using MilitaryElite.Interfaces;
using MilitaryElite.Interfaces.Silders;
using MilitaryElite.Interfaces.Silders.Privates;
using MilitaryElite.Interfaces.Silders.Privates.SpecialisedSoldiers;
using MilitaryElite.Interfaces.Silders.Privates.SpecialisedSoldiers.Commandos;
using MilitaryElite.Interfaces.Silders.Privates.SpecialisedSoldiers.Engineers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MilitaryElite
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<ISoldier> soldiers = new List<ISoldier>();
            do
            {
                var inputCommand = Console.ReadLine();
                if (inputCommand == "End")
                {
                    break;
                }
                var inputData = inputCommand
                    .Split(new[] { ' ' });
                var id = inputData[1];
                var firstName = inputData[2];
                var lastName = inputData[3];
                decimal salary;
                ICorp corps;
                bool solderPressent = soldiers.Any(x => x.Id == id);
                switch (inputData[0])
                {
                    case "Private":
                        salary = decimal.Parse(inputData[4]);
                        if (solderPressent)
                        {
                            var index = soldiers.FindIndex(x => x.Id == id);
                            var tempPrivate = (IPrivate)soldiers[index];
                            tempPrivate.FirstName = firstName;
                            tempPrivate.LastName = lastName;
                            tempPrivate.FirstName = firstName;
                            tempPrivate.Salary = salary;
                            soldiers[index] = tempPrivate;
                            //Console.WriteLine(tempPrivate);

                        }
                        else
                        {
                            IPrivate privateSolder = new Private(id, firstName, lastName, salary);
                            soldiers.Add(privateSolder);
                            //Console.WriteLine(privateSolder);

                        }


                        break;
                    case "LieutenantGeneral":
                        salary = decimal.Parse(inputData[4]);
                        if (solderPressent)
                        {
                            var index = soldiers.FindIndex(x => x.Id == id);
                            var tempLieutenantGeneral = (ILieutenantGeneral)soldiers[index];
                            tempLieutenantGeneral.FirstName = firstName;
                            tempLieutenantGeneral.LastName = lastName;
                            tempLieutenantGeneral.FirstName = firstName;
                            tempLieutenantGeneral.Salary = salary;
                            for (int i = 4; i < inputData.Length; i++)
                            {
                                var currentId = inputData[i];

                                if (soldiers.Any(x => x.Id == currentId))
                                {
                                    var indexPrivate = soldiers.FindIndex(x => x.Id == currentId);
                                    tempLieutenantGeneral.AddPrivate((IPrivate)soldiers[indexPrivate]);
                                }
                            }
                            soldiers[index] = tempLieutenantGeneral;

                            //Console.WriteLine(tempLieutenantGeneral);
                        }
                        else
                        {
                            ILieutenantGeneral lieutenantGeneral = new LieutenantGeneral(id,firstName,lastName,salary);

                            for (int i = 4; i < inputData.Length; i++)
                            {
                                var currentId = inputData[i];

                                if (soldiers.Any(x => x.Id == currentId))
                                {
                                    //var result = soldiers.ToList();
                                    var index = soldiers.FindIndex(x => x.Id == currentId);
                                    lieutenantGeneral.AddPrivate((IPrivate)soldiers[index]);
                                }
                            }
                            //Console.WriteLine(lieutenantGeneral);
                            soldiers.Add(lieutenantGeneral);
                        }
                        break;
                    case "Engineer":
                        salary = decimal.Parse(inputData[4]);
                        try
                        {
                            corps = new Corp(inputData[5]);

                        }
                        catch (Exception)
                        {

                            continue;
                        }
                        IEngineer engineer = new Engineer(id, firstName, lastName, salary, corps);
                        HashSet<IRepair> repairList = new HashSet<IRepair>();
                        for (int i = 6; i < inputData.Length; i += 2)
                        {
                            IRepair repair = new Repair(inputData[i], int.Parse(inputData[i + 1]));
                            engineer.AddRepairs(repair);
                        }

                        //Console.WriteLine(engineer);
                        soldiers.Add(engineer);
                        break;
                    case "Commando":
                        salary = decimal.Parse(inputData[4]);
                        try
                        {
                            corps = new Corp(inputData[5]);

                        }
                        catch (Exception)
                        {

                            continue;
                        }
                        ICommando commando = new Commando(id,firstName,lastName,salary,corps);
                        List<IMission> missionList = new List<IMission>();
                        IMission mission;
                        for (int i = 6; i < inputData.Length; i += 2)
                        {
                            try
                            {
                                mission = new Mission(inputData[i], inputData[i + 1]);
                                commando.AddMission(mission);
                            }
                            catch (Exception)
                            {

                                continue;
                            }
                        }

                        //Console.WriteLine(commando);
                        soldiers.Add(commando);
                        break;
                    case "Spy":
                        var codeNumber = int.Parse(inputData[4]);
                        ISpy spy = new Spy(id, firstName, lastName, codeNumber);
                        //Console.WriteLine(spy);
                        soldiers.Add(spy);
                        break;

                    default:
                        break;
                }
            } while (true);

            foreach (var item in soldiers)
            {
                Console.WriteLine(item);
            }
        }
    }
}
