using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.animals.mammals
{
    public abstract class Mammal : Animal
    {
        private string livingRegion;

        public Mammal(string livingRegion, string name, double weight, int foodEaten) : base(name, weight, foodEaten)
        {
            LivingRegion = livingRegion;
        }

        public string LivingRegion { get => livingRegion; set => livingRegion = value; }
    }
}
