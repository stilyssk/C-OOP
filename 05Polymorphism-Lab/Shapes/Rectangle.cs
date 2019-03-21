﻿using System;
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
            this.Height = height;
            this.Width = width;
        }

        private double Height
        {
            get
            {
                return this.height;
            }
            set
            {
                this.height = value;
            }
        }

        private double Width
        {
            get
            {
                return this.height;
            }
            set
            {
                this.height = value;
            }
        }

        public override double CalculateArea()
        {
            return this.Height*this.Width;
        }

        public override double CalculatePerimeter()
        {
            return 2*(this.Height+this.Width);
        }

        public override string Draw()
        {
            return $"{this.GetType().Name}";
        }
    }
}
