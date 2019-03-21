using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Car : Vehicle
    {
        private double airConditionerConsumtion = 0.9;

        public Car(double fuelQuantity, double fuelConsumtionInLiterPerKm, double tankCapacity) : base(fuelQuantity, fuelConsumtionInLiterPerKm, tankCapacity)
        {
        }

        public override double AirConditionerConsumtion  => this.airConditionerConsumtion; 

        public override string Drive(double distance)
        {
            return base.Drive(distance);
        }

        public override void Refuel(double refuel)
        {
            base.Refuel(refuel);
        }


    }
}
