using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.animals.mammals.felines
{
    public class Tiger : Feline
    {
        public Tiger(string name, double weight, string livingRegion, string breed) : base(name, weight, livingRegion, breed)
        {
            this.WeightIncrease = 1.00;
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
            return "ROAR!!!";
        }
    }
}
