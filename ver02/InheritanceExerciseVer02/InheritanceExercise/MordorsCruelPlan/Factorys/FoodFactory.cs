using MordorsCruelPlan.Factorys.BaseType;
using System;
using System.Collections.Generic;
using System.Text;

namespace MordorsCruelPlan.Factorys
{
    public class FoodFactory
    {
        private enum listOfFood
        {
            cram = 2,
            lembas = 3,
            apple = 1,
            melon = 1,
            honeycake = 5,
            mushrooms = -10
        }

        private Food currentFood;

        public FoodFactory()
        {
            CurrentFood = new Food();
        }

        private Food CurrentFood
        {
            get => currentFood;
            set => currentFood = value;
        }

        public void CheckFood(string foodName)
        {
            object result = 0;
            var flagInList = Enum.TryParse(typeof(listOfFood), foodName.ToLower(), out result);
            if (flagInList)
            {
                CurrentFood.happines = (int)(listOfFood)result;
            }
            else
            {
                CurrentFood.happines = -1;
            }

        }

        public Food GetFood()
        {

            return CurrentFood;
        }
    }
}
