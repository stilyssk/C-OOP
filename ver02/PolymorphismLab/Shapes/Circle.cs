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
            Radius = radius;
        }

        private double Radius
        {
            get { return radius; }
            set
            {
                radius = value;
            }
        }

        public override double CalculateArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public override double CalculatePerimeter()
        {
            return Math.PI * 2 * Radius;
        }

        public override string Draw()
        {
            return base.Draw() + "Circle";
        }
    }
}
