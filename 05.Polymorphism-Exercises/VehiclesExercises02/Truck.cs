using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Truck : Vehicle
    {

        private double airConditionerConsumtion = 1.6;

        public Truck(double fuelQuantity, double fuelConsumtionInLiterPerKm, double tankCapacity) : base(fuelQuantity, fuelConsumtionInLiterPerKm, tankCapacity)
        {
        }

        public override double AirConditionerConsumtion => this.airConditionerConsumtion;

        public override string Drive(double distance)
        {
            return base.Drive(distance);
        }

        public override void Refuel(double refuel)
        {
            double oldRefuel = refuel;
            try
            {
                refuel *= 0.95;
                base.Refuel(refuel);
            }
            catch (ArithmeticException ex)
            {

                throw new ArgumentException($"Cannot fit {oldRefuel} fuel in the tank");
                
            }
        }
    }
}
