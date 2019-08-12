

namespace P01_RawData
{
    using P01_RawData.Cars;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Car
    {
        private IEngine engine;
        private ICargo cargo;
        private ITire[] tires;
        public Car(
            string model,
            IEngine engine,
            ICargo cargo,
            ITire[] tires
            )
        {
            this.model = model;
            this.Engine = engine;
            this.Cargo = cargo;
            this.Tires = tires;
        }


        public string model;

        public IEngine Engine { get => engine; set => engine = value; }
        public ICargo Cargo { get => cargo; set => cargo = value; }
        public ITire[] Tires { get => tires; set => tires = value; }
    }
}
