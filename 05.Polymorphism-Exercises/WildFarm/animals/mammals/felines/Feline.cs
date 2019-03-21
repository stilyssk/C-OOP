using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.animals.mammals.felines
{
    public abstract class Feline : Mammal
    {
        private string breed;
        public Feline(string breed,string livingRegion, string name, double weight, int foodEaten) : base(livingRegion, name, weight, foodEaten)
        {
            Breed = breed;
        }

        public string Breed { get => breed; set => breed = value; }
    }
}
