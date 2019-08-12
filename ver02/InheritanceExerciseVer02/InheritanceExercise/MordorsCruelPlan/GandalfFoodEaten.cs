using MordorsCruelPlan.Factorys;
using MordorsCruelPlan.Factorys.BaseType;
using System;
using System.Collections.Generic;
using System.Text;

namespace MordorsCruelPlan
{
    public class GandalfFoodEaten
    {
        private Food food;
        public GandalfFoodEaten(string currentFood)
        {
            this.CurrentFood = currentFood;
            
        }

        private string CurrentFood
        {
            set
            {
                FoodFactory foodFactory = new FoodFactory();
                foodFactory.CheckFood(value);
                this.food = foodFactory.GetFood();
            }
        }

        public Food GetCurrentFood
        {
            get => this.food;
        }

    }
}
