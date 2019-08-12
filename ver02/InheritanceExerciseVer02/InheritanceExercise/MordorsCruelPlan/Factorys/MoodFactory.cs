using MordorsCruelPlan.Factorys.BaseType;
using System;
using System.Collections.Generic;
using System.Text;

namespace MordorsCruelPlan.Factorys
{
    public class MoodFactory
    {
        private Mood mood;

        public MoodFactory()
        {
            mood = new Mood();
        }

        public void ChechMood(int happinesPoint)
        {
            if (happinesPoint < -5)
            {
                mood.mood = "Angry";
            }
            else if (happinesPoint <= 0)
            {
                mood.mood = "Sad";

            }
            else if (happinesPoint <= 15)
            {
                mood.mood = "Happy";
            }
            else
            {
                mood.mood = "JavaScript";
            }
        }

        public Mood GetMood()
        {
            return mood;
        }
    }
}
