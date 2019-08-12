namespace P02_CarsSalesman
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class Car : ICar
    {
        private const string offset = "  ";

        private string model;
        private IEngine engine;
        private int weight;
        private string color;

        public Car(string model, IEngine engine)
        {
            this.Model = model;
            this.Engine = engine;
            this.Weight = -1;
            this.Color = "n/a";
        }

        public Car(string model, IEngine engine, int weight) : this(model, engine)
        {
            this.Weight = weight;
        }

        public Car(string model, IEngine engine, string color)
        {
            this.Model = model;
            this.Engine = engine;
            this.Weight = -1;
            this.Color = color;
        }

        public Car(string model, IEngine engine, int weight, string color)
        {
            this.Model = model;
            this.Engine = engine;
            this.Weight = weight;
            this.Color = color;
        }

        private string Model { get => model; set => model = value; }
        private IEngine Engine { get => engine; set => engine = value; }
        private int Weight { get => weight; set => weight = value; }
        private string Color { get => color; set => color = value; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0}:\n", this.Model);
            sb.Append(this.Engine.ToString());
            sb.AppendFormat("{0}Weight: {1}\n", offset, this.Weight == -1 ? "n/a" : this.Weight.ToString());
            sb.AppendFormat("{0}Color: {1}", offset, this.Color);

            return sb.ToString();
        }
    }
}
