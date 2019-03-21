using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.animals.birds
{
    public abstract class Bird : Animal
    {
        public Bird(string name, double weight, int foodEaten) : base(name, weight, foodEaten)
        {
        }
    }
}
