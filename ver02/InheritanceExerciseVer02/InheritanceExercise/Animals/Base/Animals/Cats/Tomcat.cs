using System;
using System.Collections.Generic;
using System.Text;

namespace Animals.Base.Animals.Cats
{
    public class Tomcat : Animal
    {
        public Tomcat(string name, int age, string gender = "Male") : base(name, age, gender)
        {
        }

        public override string ProduceSound()
        {
            return "MEOW";
        }
    }
}
