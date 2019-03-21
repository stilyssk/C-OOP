using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Truck : Vehicle
    {

        private double airConditionerConsumtion = 1.6;

        public Truck(double fuelQuantity, double fuelConsumtionInLiterPerKm) : base(fuelQuantity, fuelConsumtionInLiterPerKm)
        {
        }

        public override double AirConditionerConsumtion => this.airConditionerConsumtion;

        public override string Drive(double distance)
        {
            return base.Drive(distance);
        }

        public override void Refuel(double refuel)
        {
            refuel *= 0.95;
             base.Refuel(refuel);
        }
    }
}
