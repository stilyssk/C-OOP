using Cars.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cars.Classes
{
    public class Tesla : Car, IElectricCar
    {
        private int batteryCount;
        public Tesla(string model, string collor, int batteryCount) : base(model, collor)
        {
            BatteryCount = batteryCount;
        }

        public int BatteryCount { get => batteryCount; set => batteryCount = value; }
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine($"{this.Collor} {this.GetType().Name} {this.Model} with {this.BatteryCount} Batteries");
            result.AppendLine(base.ToString());
            return result.ToString().TrimEnd();
        }
    }
}
