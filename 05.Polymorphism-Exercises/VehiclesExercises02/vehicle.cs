using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Vehicle
    {
        private double fuelQuantity;
        private double fuelConsumptionInLiterPerKm;
        //private double airConditionerConsumtion;
        private double tankCapacity;

        public Vehicle(double fuelQuantity, double fuelConsumtionInLiterPerKm, double tankCapacity)
        {
            this.TankCapacity = tankCapacity;
            if (this.TankCapacity<fuelQuantity)
            {
                this.FuelQuantity = 0;
            }
            else
            {
                this.FuelQuantity = fuelQuantity;
            }
            this.FuelConsumtionInLiterPerKm = fuelConsumtionInLiterPerKm;
            
        }

        public double TankCapacity
        {
            get => this.tankCapacity;
            set
            {
                this.tankCapacity = value;
            }
        }

        public virtual double AirConditionerConsumtion
        {
            get;
        }

        public double FuelQuantity
        {
            get
            {
                return this.fuelQuantity;
            }
            private set
            {
                this.fuelQuantity = value;
            }
        }

        private double FuelConsumtionInLiterPerKm
        {
            get
            {
                return this.fuelConsumptionInLiterPerKm;
            }
            set
            {
                this.fuelConsumptionInLiterPerKm = value;
            }
        }

        public virtual string Drive(double distance)
        {
            string result = null;
            var expectDistance = (this.FuelQuantity / (this.FuelConsumtionInLiterPerKm+this.AirConditionerConsumtion));
            if (expectDistance>=distance)
            {
                double fuelConsumet = (distance * (this.fuelConsumptionInLiterPerKm+this.AirConditionerConsumtion));
                this.FuelQuantity -= fuelConsumet;
                result = $"{this.GetType().Name} travelled {distance} km";
            }
            else
            {
                result = $"{this.GetType().Name} needs refueling";
            }

            return result;
        }

        public virtual void Refuel(double refuel)
        {
            if (refuel<=0)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }
            if (refuel + this.FuelQuantity > this.tankCapacity)
            //if (refuel>this.tankCapacity)
            {
                throw new ArithmeticException($"Cannot fit {refuel} fuel in the tank");
            }
            this.fuelQuantity += refuel;
        }

        public override string ToString()
        {
            return $"{GetType().Name}: {this.FuelQuantity:f2}";
        }
    }
}
