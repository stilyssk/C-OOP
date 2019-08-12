using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public class Toppings
    {
        private const int baseCalories = 2;

        private enum toppingType
        {
            meat = 12,
            veggies = 8,
            cheese = 11,
            sauce = 9
        }

        private double weight;
        private string currentTopping;
        private double calories;

        public Toppings(double weight, string topping)
        {
            this.CurrentTopping = topping;
            this.Weight = weight;
            CalculateCalories();
        }

        public double Calories { get => this.calories; set => this.calories = value; }
        public double Weight
        {
            get => weight;
            set
            {
                if (value < 1 || value > 50)
                {
                    throw new ArgumentException($"{this.CurrentTopping} weight should be in the range [1..50].");
                }
                weight = value;
            }
        }

        public string CurrentTopping
        {
            get => currentTopping;

            set
            {
                try
                {
                    Enum.Parse(typeof(toppingType), value.ToLower());

                }
                catch (Exception)
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");

                }
                this.currentTopping = value;
            }
        }

        private void CalculateCalories()
        {
            var topingMultilpy = (int)System.Enum.Parse(typeof(toppingType), this.CurrentTopping.ToLower()) / 10.0;
            this.Calories = this.Weight * baseCalories * topingMultilpy;
        }

        public override string ToString()
        {
            return $"{this.Calories:f2}";
        }
    }
}
