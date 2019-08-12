using AnimalCentre.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalCentre.Models.Animals
{
    public class Dog : Animal
    {
        public Dog(string name, int energy, int happiness, int procedureTime) : base(name, energy, happiness, procedureTime)
        {
        }
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append($"    Animal type: {this.GetType().Name} - {this.Name} - Happiness: {this.Happiness} - Energy: {this.Energy}");
            return result.ToString();
        }
    }
}
