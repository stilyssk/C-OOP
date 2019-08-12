namespace P01_RawData.Cars
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class Tire : ITire
    {
        private double pressure;
        private int age;

        public Tire(
            double pressure,
            int age
            )
        {
            Pressure = pressure;
            Age = age;
        }

        public double Pressure { get => pressure; set => pressure = value; }
        public int Age { get => age; set => age = value; }
    }
}
