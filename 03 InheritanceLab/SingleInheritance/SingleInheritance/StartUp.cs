using System;

namespace Farm
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            Console.WriteLine(dog.Eat());
            Console.WriteLine(dog.Bark()); 
        }
    }
}
