using ExplicitInterfaces.Interfacess;
using System;

namespace ExplicitInterfaces
{
    public class StartUp
    {
        static void Main(string[] args)
        {

            do
            {
                var inputPersonName = Console.ReadLine();
                if (inputPersonName == "End")
                {
                    break;
                }
                var inputName = inputPersonName.Split(new[] { ' ' })[0];
                IPerson person = new Citizen(inputName);
                IResident resident = new Citizen(inputName);
                Console.WriteLine(person.GetName());
                Console.WriteLine(resident.GetName());
            } while (true);

        }
    }
}
