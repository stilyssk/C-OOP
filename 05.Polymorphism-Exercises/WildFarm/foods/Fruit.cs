using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.foods
{
    public class Fruit : Food
    {
        public Fruit(int quantity) : base(quantity)
        {
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
