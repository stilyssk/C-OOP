using Cars.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cars.Classes
{
    public class Seat : Car
    {
        public Seat(string model, string collor) : base(model, collor)
        {
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine($"{this.Collor} {this.GetType().Name} {this.Model}");
            result.AppendLine(base.ToString());
            return result.ToString().TrimEnd();
        }
    }
}
