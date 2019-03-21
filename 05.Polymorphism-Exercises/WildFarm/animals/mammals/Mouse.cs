using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.animals.mammals
{
    public class Mouse : Mammal
    {
        public Mouse(string name, double weight, string livingRegion) : base(name, weight, livingRegion)
        {
            this.WeightIncrease = 0.10;
        }

        public override double WeightIncrease { get => base.WeightIncrease; set => base.WeightIncrease = value; }

        public override string AddFood(string food, int count)
        {
            if (food == "Vegetable" || food == "Fruit")
            {
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
            return "Squeak";
        }

        public override string ToString()
        {
            return $"{GetType().Name} [{this.Name}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}
