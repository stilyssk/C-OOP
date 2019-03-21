using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.animals.mammals.felines
{
    public abstract class Feline : Mammal
    {
        private string breed;

        public Feline(string name, double weight, string livingRegion, string breed) : base(name, weight, livingRegion)
        {
            Breed = breed;
        }

        public string Breed { get => breed; set => breed = value; }

        public override string ToString()
        {
            return $"{ GetType().Name} [{this.Name}, {this.Breed}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}
