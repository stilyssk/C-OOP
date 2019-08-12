using System;
using System.Collections.Generic;
using System.Text;

namespace FoodShortage.Interfaces.Child
{
    public interface IBuyer:IPerson
    {
        int Food { get; set; }
        void BuyFood();
    }
}
