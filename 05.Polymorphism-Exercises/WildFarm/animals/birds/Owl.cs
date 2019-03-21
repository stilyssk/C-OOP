using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.animals.birds
{
    public class Owl : Bird
    {
        private string result = null; 
        public Owl(string name, double weight, double wingSize) : base(name, weight, wingSize)
        {
            this.WeightIncrease = 0.25;
        }

        public override double WeightIncrease { get => base.WeightIncrease; set => base.WeightIncrease = value; }

        public override string AddFood(string food, int count)
        {
            if (food == "Meat")
            {
                //base.AddFood(food, count);
                this.FoodEaten += count;
                this.Weight += count * this.WeightIncrease;
                //return this.ToString();
                return null;
            }
            else
            {
                return $"{GetType().Name} does not eat {food}!\n";
            }
        }

        public override string Speak()
        {
            return "Hoot Hoot";
        }
    }
}
