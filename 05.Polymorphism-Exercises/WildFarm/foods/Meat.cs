﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.foods
{
    public class Meat : Food
    {
        public Meat(int quantity) : base(quantity)
        {
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
