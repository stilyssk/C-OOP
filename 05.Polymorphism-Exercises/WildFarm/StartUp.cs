namespace WildFarm
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using animals;
    using animals.birds;
    using animals.mammals;
    using animals.mammals.felines;

    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Animal> listAnimals = new List<Animal>();

            while (true)
            {
                string inputCommand = Console.ReadLine();
                if (inputCommand== "End")
                {
                    break;
                }
                else
                {
                    string[] inputAnimalData = inputCommand
                        .Split(new[] { ' ' })
                        .ToArray();
                    string animal = inputAnimalData[0];
                    string[] eatInformation = Console.ReadLine()
                        .Split(new[] { ' ' })
                        .ToArray();
                    switch (animal)
                    {
                        case "Hen":
                            Hen hen = new Hen(inputAnimalData[1], double.Parse(inputAnimalData[2]), int.Parse(inputAnimalData[3]));
                            Console.WriteLine(hen.Speak());
                            Console.Write(hen.AddFood(eatInformation[0], int.Parse(eatInformation[1])));
                            listAnimals.Add(hen);
                            //Console.WriteLine(hen);
                            break;
                        case "Owl":
                            Owl owl = new Owl(inputAnimalData[1], double.Parse(inputAnimalData[2]), int.Parse(inputAnimalData[3]));
                            Console.WriteLine(owl.Speak());
                            Console.Write(owl.AddFood(eatInformation[0], int.Parse(eatInformation[1])));
                            listAnimals.Add(owl);
                            //Console.WriteLine(owl);
                            break;
                        case "Mouse":
                            Mouse mouse = new Mouse(inputAnimalData[1],double.Parse(inputAnimalData[2]),inputAnimalData[3]);
                            Console.WriteLine(mouse.Speak());
                            Console.Write(mouse.AddFood(eatInformation[0], int.Parse(eatInformation[1])));
                            listAnimals.Add(mouse);
                            //Console.WriteLine(mouse);
                            break;
                        case "Dog":
                            Dog dog = new Dog(inputAnimalData[1], double.Parse(inputAnimalData[2]), inputAnimalData[3]);
                            Console.WriteLine(dog.Speak());
                            Console.Write(dog.AddFood(eatInformation[0], int.Parse(eatInformation[1])));
                            listAnimals.Add(dog);
                            //Console.WriteLine(dog);
                            break;
                        case "Cat":
                            Cat cat = new Cat(inputAnimalData[1], double.Parse(inputAnimalData[2]), inputAnimalData[3],inputAnimalData[4]);
                            Console.WriteLine(cat.Speak());
                            Console.Write(cat.AddFood(eatInformation[0], int.Parse(eatInformation[1])));
                            //Console.WriteLine(cat);
                            listAnimals.Add(cat);
                            break;
                        case "Tiger":
                            Tiger tiger = new Tiger(inputAnimalData[1], double.Parse(inputAnimalData[2]), inputAnimalData[3], inputAnimalData[4]);
                            Console.WriteLine(tiger.Speak());
                            Console.Write(tiger.AddFood(eatInformation[0], int.Parse(eatInformation[1])));
                            //Console.WriteLine(tiger);
                            listAnimals.Add(tiger);
                            break;
                        default:
                            break;
                    }



                }
            }

            foreach (var currentAnimal in listAnimals)
            {
                Console.WriteLine(currentAnimal);
            }
        }

        
    }
}
