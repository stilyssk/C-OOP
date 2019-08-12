using Animals.Base;
using Animals.Base.Animals;
using Animals.Base.Animals.Cats;
using System;

namespace Animals
{
    public class Program
    {
        static void Main(string[] args)
        {
            var inputCommand = Console.ReadLine();
            while (inputCommand != "Beast!")
            {
                var inputAnimalData = Console.ReadLine()
                    .Split(new[] { ' ' });



                try
                {
                    var name = inputAnimalData[0];
                    if (!int.TryParse(inputAnimalData[1], out int age))
                    {
                        throw new ArgumentException("Invalid input!");
                    }
                    age = int.Parse(inputAnimalData[1]);
                    string gender = string.Empty;
                    if (inputAnimalData.Length == 3)
                    {
                        gender = inputAnimalData[2];
                    }

                    switch (inputCommand.ToLower())
                    {
                        case "cat":
                            Cat cat = new Cat(name, age, gender);
                            Console.WriteLine(cat);
                            break;
                        case "dog":
                            Dog dog = new Dog(name, age, gender);
                            Console.WriteLine(dog);
                            break;
                        case "frog":
                            Frog frog = new Frog(name, age, gender);
                            Console.WriteLine(frog);
                            break;
                        case "tomcat":
                            Tomcat tomcat = new Tomcat(name, age);
                            Console.WriteLine(tomcat);
                            break;
                        case "kitten":
                            Kitten kitten = new Kitten(name, age);
                            Console.WriteLine(kitten);
                            break;
                        default:
                            throw new ArgumentException("Invalid input!"); 
                    }
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }

                inputCommand = Console.ReadLine();
            }
        }
    }
}
