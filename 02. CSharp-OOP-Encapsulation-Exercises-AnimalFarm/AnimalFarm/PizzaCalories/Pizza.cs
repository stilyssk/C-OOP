using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public class Pizza
    {
        private string name;
        private Dough doughForPiza;
        private List<Toppings> toppingList;
        private double weight;
        private double calories;

        public string Name
        {
            get => name;
            set
            {
                if (value == string.Empty || value.Length<1||value.Length>15)
                {
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                }
                this.name=value;
            }
        }
        public List<Toppings> ToppingList { get => toppingList; set => toppingList = value; }
        public double Calories { get => calories; set => calories = value; }
        public Dough DoughForPiza { get => doughForPiza; set => doughForPiza = value; }

        public Pizza()
        {
            this.ToppingList = new List<Toppings>();
        }


        public bool AddDough(double weight, string dough, string addition)
        {
            this.DoughForPiza = new Dough(weight, dough, addition);
            this.Calories += this.DoughForPiza.Calories;
            return true;
        }

        public bool AddTopping(double weight, string topping)
        {
            if (this.ToppingList.Count >= 10)
            {
                throw new ArgumentException("Number of toppings should be in range [0..10].");
            }
            Toppings newToppings = new Toppings(weight, topping);
            this.ToppingList.Add(newToppings);
            this.Calories += newToppings.Calories;
            return true;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine($"{this.Name} - {this.Calories:f2} Calories.");
            return result.ToString();
        }
    }
}
