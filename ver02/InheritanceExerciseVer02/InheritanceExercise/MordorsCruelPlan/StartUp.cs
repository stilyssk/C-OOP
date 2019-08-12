using MordorsCruelPlan.Factorys;
using MordorsCruelPlan.Factorys.BaseType;
using System;
using System.Collections.Generic;

namespace MordorsCruelPlan
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<GandalfFoodEaten> gandalfFoodEatens = new List<GandalfFoodEaten>();
            var inputGandalsFood = Console.ReadLine()
                .Split(new[] { ' ' });
            foreach (var currentFood in inputGandalsFood)
            {
                GandalfFoodEaten gandalfFood = new GandalfFoodEaten(currentFood);
                gandalfFoodEatens.Add(gandalfFood);

            }
            int result = 0;
            foreach (var currentFood in gandalfFoodEatens)
            {
                result += currentFood.GetCurrentFood.happines;
            }
            Console.WriteLine(result);
            MoodFactory moodFactory = new MoodFactory();
            moodFactory.ChechMood(result);
            Mood moodResult = moodFactory.GetMood();
            Console.WriteLine(moodResult);

        }
    }
}
