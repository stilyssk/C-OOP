using System;
using System.Linq;

namespace PizzaCalories
{
    public class Program
    {
        static void Main(string[] args)
        {
            Pizza pizza = new Pizza();
            var inputPizzaName = Console.ReadLine()
                .Split(new[] { ' '})
                .ToList();
            var inputDoughCommand = Console.ReadLine()
                .Split(new[] { ' ' })
                .ToList();
            var doughType = inputDoughCommand[0];
            var dough = inputDoughCommand[1];
            var addition = inputDoughCommand[2];
            var doughWeight = double.Parse(inputDoughCommand[3]);
            try
            {
                pizza.Name = inputPizzaName[1];
                pizza.AddDough(doughWeight, dough, addition);

                while (true)
                {
                    var inputCommand = Console.ReadLine();
                    if (inputCommand == "END")
                    {
                        break;
                    }
                    else
                    {
                        var inputToppic = inputCommand
                            .Split(new[] { ' ' })
                            .ToList();
                        var name = inputToppic[0];
                        var toppingName = inputToppic[1];
                        var toppingWeight = double.Parse(inputToppic[2]);
                        try
                        {
                            pizza.AddTopping(toppingWeight, toppingName);
                        }
                        catch (Exception ex)
                        {
                            throw new ArgumentException(ex.Message);
                        }
                    }

                }
                Console.WriteLine(pizza);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
