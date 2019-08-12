using Cars.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cars.Classes
{
    public class Car : ICar
    {
        private string model;
        private string collor;

        public Car(string model, string collor)
        {
            Model = model;
            Collor = collor;
        }

        public string Model { get => model; set => model = value; }
        public string Collor { get => collor; set => collor = value; }

        public override string ToString()
        {

            return $"Engine start\nBreaaak!";
        }
    }
}
