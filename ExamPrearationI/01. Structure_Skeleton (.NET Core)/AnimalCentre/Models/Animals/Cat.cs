namespace AnimalCentre.Models.Animals
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using global::AnimalCentre.Models.Contracts;

    public class Cat : Animal
    {
        public Cat(string name, int energy, int happiness, int procedureTime) : base(name, energy, happiness, procedureTime)
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
