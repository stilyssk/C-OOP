using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.animals.birds
{
    public abstract class Bird : Animal
    {
        private double wingSize;

        public Bird(string name, double weight, double wingSize) : base(name, weight)
        {
            WingSize = wingSize;
        }

        public double WingSize { get => wingSize; set => wingSize = value; }


        public override string ToString()
        {
            return  $"{GetType().Name} [{this.Name}, {this.wingSize}, {this.Weight}, {this.FoodEaten}]";
        }
    }
}
