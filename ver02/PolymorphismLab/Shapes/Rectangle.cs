using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class Rectangle : Shape
    {
        private double height;
        private double width;

        public Rectangle(double height, double width)
        {
            Height = height;
            Width = width;
        }

        private double Height
        {
            get { return height; }
            set
            {
                height = value;
            }
        }
        private double Width
        {
            get { return width; }
            set
            {
                width = value;
            }
        }

        public override double CalculateArea()
        {
            return Width * Height;
        }

        public override double CalculatePerimeter()
        {
            return 2 * (Width + Height);
        }

        public override string Draw()
        {
            return base.Draw() + "Rectangle";
        }
    }
}
