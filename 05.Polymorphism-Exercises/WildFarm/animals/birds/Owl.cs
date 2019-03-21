using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.animals.birds
{
    public class Owl : Bird
    {
        public Owl(string name, double weight, int foodEaten) : base(name, weight, foodEaten)
        {
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
