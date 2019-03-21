using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Bus : Vehicle
    {
        private double airConditionerConsumtion;


        public Bus(double fuelQuantity, double fuelConsumtionInLiterPerKm, double tankCapacity) : base(fuelQuantity, fuelConsumtionInLiterPerKm, tankCapacity)
        {
        }

        public override double AirConditionerConsumtion => this.airConditionerConsumtion;

        public override string Drive(double distance)
        {
            this.airConditionerConsumtion = 1.4;
            return base.Drive(distance);
        }

        public string DriveEmpty(double distance)
        {
            this.airConditionerConsumtion = 0;
            return base.Drive(distance);
        }
    }
}
