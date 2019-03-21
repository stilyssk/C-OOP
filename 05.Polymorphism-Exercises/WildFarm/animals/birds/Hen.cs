using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.animals.birds
{
    public class Hen : Bird
    {
        public Hen(string name, double weight, int foodEaten) : base(name, weight, foodEaten)
        {
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
