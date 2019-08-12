using System;
using System.Collections.Generic;
using System.Linq;

namespace P04_Hospital
{
    public class Program
    {
        public static void Main()
        {
            List<IDepartment> departments = new List<IDepartment>();
            List<IDoctor> doktori = new List<IDoctor>();

            string command = Console.ReadLine();
            while (command != "Output")
            {
                string[] inputHospitalData = command.Split();
                var departmentName = inputHospitalData[0];
                var firsName = inputHospitalData[1];
                var secondName = inputHospitalData[2];
                var patient = inputHospitalData[3];
                var fullName = firsName + secondName;
                var name = firsName + secondName;

                if (!doktori.Any(x => x.Name == name))
                {
                    doktori.Add(new Doctor(name));
                }
                if (!departments.Any(x => x.Name == departmentName))
                {
                    departments.Add(new Department(departmentName));
                }
                var indexDeartment = departments.FindIndex(x => x.Name == departmentName);
                bool imaMqsto = departments[indexDeartment].CountOcupate() < 60;
                if (imaMqsto)
                {
                    int staq = 0;
                    int index = doktori.FindIndex(x => x.Name == fullName);
                    doktori[index].AddPatient(patient);
                    for (int st = 0; st < departments[indexDeartment].Rooms.Count; st++)
                    {
                        if (departments[indexDeartment].Rooms[st].Patient.Count < 3)
                        {
                            staq = st;
                            break;
                        }
                    }
                    departments[indexDeartment].Rooms[staq].AddPatient(patient);
                }

                command = Console.ReadLine();
            }

            command = Console.ReadLine();

            while (command != "End")
            {
                string[] args = command.Split();
                int indexDepartment = departments.FindIndex(x => x.Name == args[0]);
                if (args.Length == 1)
                {
                    Console.WriteLine(string.Join("\n", departments[indexDepartment].ListAllPatientInDepartment()));
                }
                else if (args.Length == 2 && int.TryParse(args[1], out int staq))
                {
                    Console.WriteLine(string.Join("\n", departments[indexDepartment].Rooms[staq - 1].ListAllPatient().OrderBy(x=>x).ToList()));
                }
                else
                {
                    var name = args[0] + args[1];
                    var index = doktori.FindIndex(x => x.Name == name);
                    Console.WriteLine(string.Join("\n", doktori[index].OrderedListPatient()));
                }
                command = Console.ReadLine();
            }
        }
    }
}
