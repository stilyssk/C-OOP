using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.foods
{
    public class Vegetable : Food
    {
        public Vegetable(int quantity) : base(quantity)
        {
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
