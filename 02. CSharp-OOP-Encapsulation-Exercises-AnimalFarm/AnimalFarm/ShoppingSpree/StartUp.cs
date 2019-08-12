using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingSpree
{
    public class StartUp

    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();
            List<Product> products = new List<Product>();
            var inputCommandFistLine = Console.ReadLine();
            var inputPeapleCommand = inputCommandFistLine
                .Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();


            try
            {
                persons = ReadListOfPersons(persons, inputPeapleCommand);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
            var inputProductCommand = Console.ReadLine()
                 .Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries)
                 .ToList();
            try
            {
                products = ReadListOfProduct(products, inputProductCommand);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
            while (true)
            {
                var inputCommand = Console.ReadLine();
                if (inputCommand == "END")
                {
                    break;
                }
                var inputPersonBay = inputCommand
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                var personName = inputPersonBay[0];
                var productName = inputPersonBay[1];
                var indexPerson = persons.FindIndex(x => x.Name == personName);
                var indexProduct = products.FindIndex(x => x.Name == productName);
                try
                {
                    var result = persons[indexPerson].AddProduct(products[indexProduct]);
                    Console.WriteLine(result);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            foreach (var currentPerrson in persons)
            {
                if (currentPerrson.getProductList().Count == 0)
                {
                    Console.WriteLine($"{currentPerrson.Name} - Nothing bought");
                }
                else
                {
                    Console.Write($"{currentPerrson.Name} - ");
                    Console.WriteLine(string.Join(", ", currentPerrson.getProductList().Select(x => x.Name)));
                }
            }

        }

        static List<Person> ReadListOfPersons(List<Person> persons, List<string> inputPeapleCommand)
        {
            for (int i = 0; i < inputPeapleCommand.Count; i++)
            {
                var personInputData = inputPeapleCommand[i]
                    .Split(new[] { '=' })
                    .ToList();
                var name = personInputData[0];
                var money = decimal.Parse(personInputData[1]);

                persons.Add(new Person(name, money));

            }
            return persons;

        }

        static List<Product> ReadListOfProduct(List<Product> products, List<string> inputProductCommand)
        {
            for (int i = 0; i < inputProductCommand.Count; i++)
            {
                var productInputData = inputProductCommand[i]
                    .Split(new[] { '=' })
                    .ToList();
                var name = productInputData[0];
                var cost = decimal.Parse(productInputData[1]);

                products.Add(new Product(name, cost));

            }
            return products;
        }
    }
}
