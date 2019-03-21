using System;
using System.Collections.Generic;
using System.Linq;

namespace P04_Hospital
{
    public class Program
    {
        public static void Main()
        {
            //Dictionary<string, List<string>> doktori = new Dictionary<string, List<string>>();
            //Dictionary<string, List<List<string>>> departments = new Dictionary<string, List<List<string>>>();

            List<Doctor> doctori = new List<Doctor>();
            List<Department> departments = new List<Department>();

            string command = Console.ReadLine();
            while (command != "Output")
            {
                string[] jetoni = command.Split();
                var departament = jetoni[0];
                var purvoIme = jetoni[1];
                var vtoroIme = jetoni[2];
                var pacient = jetoni[3];
                var cqloIme = purvoIme + vtoroIme;
                //bool test =doctori.Find(x => x.Name == "sss")!= null;
                doctori.Exists(x => x.Name == purvoIme + vtoroIme);
                //if (!doktori.ContainsKey(purvoIme + vtoroIme))
                if (!doctori.Exists(x => x.Name == (purvoIme + vtoroIme)))
                {
                    //Console.WriteLine("test");
                    Doctor newDoctor = new Doctor();
                    newDoctor.Name = purvoIme + vtoroIme;
                    newDoctor.NewPatient = pacient;
                    doctori.Add(newDoctor);
                    //doktori[cqloIme] = new List<string>();
                }
                else
                {
                    int indexOfDoctori = doctori.FindIndex(x => x.Name == (purvoIme + vtoroIme));
                    doctori[indexOfDoctori].AddPatient(pacient);

                }



                //if (!departments.ContainsKey(departament))
                if (!departments.Exists(x => x.Name == departament))
                {
                    
                    //departments[departament] = new List<List<string>>();
                    departments.Add(new Department(departament));
                    int indexOfDepartment = departments.FindIndex(x => x.Name == departament);
                    departments[indexOfDepartment].AddPatient(pacient);
                    //for (int stai = 0; stai < 20; stai++)
                    //{
                    //    departments[departament].Add(new List<string>());
                    //}
                }
                else
                {
                    int indexOfDepartment = departments.FindIndex(x => x.Name == departament);
                    departments[indexOfDepartment].AddPatient(pacient);
                }

                //bool imaMqsto = departments[departament].SelectMany(x => x).Count() < 60;
                //if (imaMqsto)
                //{
                //    int staq = 0;
                //    doktori[cqloIme].Add(pacient);
                //    for (int st = 0; st < departments[departament].Count; st++)
                //    {
                //        if (departments[departament][st].Count < 3)
                //        {
                //            staq = st;
                //            break;
                //        }
                //    }
                //    departments[departament][staq].Add(pacient);
                //}

                command = Console.ReadLine();
            }

            command = Console.ReadLine();

            while (command != "End")
            {
                string[] args = command.Split();

                if (args.Length == 1)
                {
                    List<string> printAllPacientInDepartment = new List<string>();
                    foreach (var currentDepartment in departments)
                    {
                        if (currentDepartment.Name == args[0])
                        {
                            printAllPacientInDepartment = currentDepartment.printAllPacient();
                        }
                    }
                    foreach (var patient in printAllPacientInDepartment)
                    {
                        Console.WriteLine(patient);
                    }
                    //Console.WriteLine(string.Join("\n", departments[args[0]].Where(x => x.Count > 0).SelectMany(x => x)));
                }
                else if (args.Length == 2 && int.TryParse(args[1], out int staq))
                {
                    List<string> printPacientInRoom = new List<string>();

                    foreach (var currentDepartment in departments)
                    {
                        if (currentDepartment.Name == args[0])
                        {
                            printPacientInRoom = currentDepartment.PrintPatientInRoom(int.Parse(args[1]));
                        }
                    }
                    printPacientInRoom = printPacientInRoom.OrderBy(x => x).ToList();
                    foreach (var patient in printPacientInRoom)
                    {
                        Console.WriteLine(patient);
                    }
                    //Console.WriteLine(string.Join("\n", departments[args[0]][staq - 1].OrderBy(x => x)));
                }
                else
                {
                    List<string> result = new List<string>();
                    foreach (var currenDoctor in doctori)
                    {
                        if (currenDoctor.Name == args[0] + args[1])
                        {
                            result = currenDoctor.PrintAllPatient();
                        }
                    }
                    result = result.OrderBy(x => x).ToList();
                    foreach (var patientName in result)
                    {
                        Console.WriteLine(patientName);
                    }
                    //Console.WriteLine(string.Join("\n", doktori[args[0] + args[1]].OrderBy(x => x)));
                }
                command = Console.ReadLine();
            }
        }
    }
}
