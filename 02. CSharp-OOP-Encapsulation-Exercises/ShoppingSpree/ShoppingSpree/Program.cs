using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingSpree
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> inputLineOne = Console.ReadLine()
                .Split(new[] { ";"}, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            List<Person> listOfPerson = new List<Person>();

            for (int i = 0; i < inputLineOne.Count; i++)
            {
                var currentPerson = inputLineOne[i]
                    .Split(new[] { "=" }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                string name = currentPerson[0];
                double money = double.Parse(currentPerson[1]);

                listOfPerson.Add(new Person(name, money));

            }


            List<string> inputProducts = Console.ReadLine()
                .Split(new[] { ";" }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            List<Product> listOfProduct = new List<Product>();

            for (int i = 0; i < inputProducts.Count; i++)
            {
                var currentProduct = inputProducts[i]
                    .Split(new[] { "=" }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                string name = currentProduct[0];
                double price = double.Parse(currentProduct[1]);

                listOfProduct.Add(new Product(name, price));

            }

            while (true)
            {
                var inputCommand = Console.ReadLine()
                    .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                if (inputCommand[0]== "END")
                {
                    break;
                }
                else
                {
                    var personName = inputCommand[0];
                    var productName = inputCommand[1];

                    var indexPerson  = listOfPerson.FindIndex(x => x.Name == personName);
                    var indexProduct = listOfProduct.FindIndex(x => x.Name == productName);


                }
            }

        }
    }
}
