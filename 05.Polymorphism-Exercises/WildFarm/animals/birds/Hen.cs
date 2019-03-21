using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.animals.birds
{
    public class Hen : Bird
    {
        public Hen(string name, double weight, double wingSize) : base(name, weight, wingSize)
        {
            this.WeightIncrease = 0.35;
        }

        public override double WeightIncrease { get => base.WeightIncrease; set => base.WeightIncrease = value; }

        public override string AddFood(string food, int count)
        {

            this.FoodEaten += count;
            this.Weight += count * this.WeightIncrease;
            //return this.ToString();
            return null;

        }

        public override string Speak()
        {
            return "Cluck";
        }

        public override string ToString()
        {
            return "Cluck";
        }
    }
}
