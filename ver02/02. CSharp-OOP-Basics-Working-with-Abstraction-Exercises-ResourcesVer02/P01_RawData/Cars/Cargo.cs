namespace P01_RawData.Cars
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Cargo : ICargo
    {
        int cargoWeight;
        string cargoType;

        public Cargo(int cargoWeight, string cargoType)
        {
            CargoWeight = cargoWeight;
            CargoType = cargoType;
        }

        public int CargoWeight { get => cargoWeight; set => cargoWeight = value; }
        public string CargoType { get => cargoType; set => cargoType = value; }
    }
}
