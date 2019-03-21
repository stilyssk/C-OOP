﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.animals.mammals.felines
{
    public class Tiger : Feline
    {
        public Tiger(string breed, string livingRegion, string name, double weight, int foodEaten) : base(breed, livingRegion, name, weight, foodEaten)
        {
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}