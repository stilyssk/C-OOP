using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.animals.mammals.felines
{
    public class Cat : Feline
    {
        public Cat(string name, double weight, string livingRegion, string breed) : base(name, weight, livingRegion, breed)
        {
            this.WeightIncrease = 0.30;
        }

        public override double WeightIncrease { get => base.WeightIncrease; set => base.WeightIncrease = value; }

        public override string AddFood(string food, int count)
        {
            if (food == "Vegetable"||food == "Meat")
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
            return "Meow";
        }
    }
}
