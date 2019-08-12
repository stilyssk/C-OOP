using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public class Dough
    {
        private const int baseCalories = 2;
        private enum DoughType
        {
            white = 15,
            wholegrain = 10
        }
        private enum Addition
        {
            crispy = 9,
            chewy = 11,
            homemade = 10
        }

        private double weight;
        private string currentDouh;
        private string currentAddition;
        private double calories;

        public Dough(double weight, string dough, string addition)
        {
            this.CurrentDouh = dough;
            this.CurrentAddition = addition;
            this.Weight = weight;
            CalculateCalories();
        }

        private double Weight
        {
            get => weight;
            set
            {
                if (value < 1 || value > 200)
                {
                    throw new ArgumentException("Dough weight should be in the range [1..200].");
                }
                weight = value;
            }
        }
        public double Calories
        {
            get => calories;
            private set => calories = value;
        }
        private string CurrentDouh
        {
            get => currentDouh;
            set
            {
                try
                {
                    Enum.Parse(typeof(DoughType), value.ToLower());

                }
                catch (Exception)
                {

                    throw new ArgumentException("Invalid type of dough.");
                }
                this.currentDouh = value;
            }
        }

        private string CurrentAddition
        {
            get => currentAddition;
            set
            {
                try
                {
                    Enum.Parse(typeof(Addition), value.ToLower());

                }
                catch (Exception)
                {

                    throw new ArgumentException("Invalid type of dough.");
                }
                this.currentAddition = value;
            }

        }

        private void CalculateCalories()
        {
            var doughMultilpy = (int)System.Enum.Parse(typeof(DoughType), this.CurrentDouh.ToLower()) / 10.0;
            var additionMultilpy = (int)System.Enum.Parse(typeof(Addition), this.CurrentAddition.ToLower()) / 10.0;
            this.Calories = this.Weight * baseCalories * doughMultilpy * additionMultilpy;
        }

        public override string ToString()
        {
            return $"{this.Calories:f2}";
        }
    }
}
