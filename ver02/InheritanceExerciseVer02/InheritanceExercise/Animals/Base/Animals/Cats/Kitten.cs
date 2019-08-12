using System;
using System.Collections.Generic;
using System.Text;

namespace Animals.Base.Animals.Cats
{
    public class Kitten : Animal
    {
        public Kitten(string name, int age, string gender = "Female") : base(name, age, gender)
        {
            
        }

        public override string ProduceSound()
        {
            return "Meow";
        }
    }
}
