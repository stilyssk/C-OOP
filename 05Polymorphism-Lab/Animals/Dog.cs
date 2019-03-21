﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Dog : Animal
    {
        public Dog(string name, string favouriteFood) : base(name, favouriteFood)
        {

        }

        public override string ExplainSelf()
        {
            StringBuilder result = new StringBuilder();
            result.Append($"I am {this.Name} and my fovourite food is {this.FavouriteFood} DJAAF");
            return result.ToString();
        }
    }
}
