using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.animals.mammals
{
    public class Dog : Mammal
    {
        public Dog(string name, double weight, string livingRegion) : base(name, weight, livingRegion)
        {
            this.WeightIncrease = 0.40;
        }

        public override double WeightIncrease { get => base.WeightIncrease; set => base.WeightIncrease = value; }

        public override string AddFood(string food, int count)
        {
            if (food == "Meat")
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
            return "Woof!";
        }

        public override string ToString()
        {
            return $"{GetType().Name} [{this.Name}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}
