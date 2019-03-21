using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.foods
{
    public abstract class Food
    {
        private int quantity;

        public Food(int quantity)
        {
            Quantity = quantity;
        }

        public int Quantity { get => quantity; set => quantity = value; }
    }
}
