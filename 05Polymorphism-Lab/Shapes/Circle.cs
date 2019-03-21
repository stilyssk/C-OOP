using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class Circle : Shape
    {
        private double radius;

        public Circle(double radius)
        {
            this.Radius = radius;
        }

        private double Radius
        {
            get
            {
                return this.radius;
            }
            set
            {
                this.radius = value;
            }
        }

        public override double CalculateArea()
        {
            return Math.Pow(this.Radius,2)*Math.PI;
        }

        public override double CalculatePerimeter()
        {
            return this.Radius*2*Math.PI;
        }

        public override string Draw()
        {
            return $"{this.GetType().Name}";
        }
    }
}
