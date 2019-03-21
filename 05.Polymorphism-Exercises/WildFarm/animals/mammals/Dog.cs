using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.animals.mammals
{
    public class Dog : Mammal
    {
        public Dog(string livingRegion, string name, double weight, int foodEaten) : base(livingRegion, name, weight, foodEaten)
        {
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
