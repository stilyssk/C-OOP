using System;
using System.Collections.Generic;
using System.Text;

namespace ClassBox
{
    public class Box
    {
        private double length;
        private double width;
        private double height;

        public Box(double height, double width, double length)
        {
            this.Height = height;
            this.Width = width;
            this.Length = length;
        }

        private double Height
        {
            get { return this.height; }
            set { this.height = value; }
        }

        private double Width
        {
            get { return this.width; }
            set { this.width = value; }
        }

        private double Length
        {
            get { return this.length; }
            set { this.length = value; }
        }

        public string CalculateSurfaceArea()
        {
            double result = 2 * this.Length * this.Width + 2 * this.Length * this.Height + 2 * this.Width * this.Height;
            return $"Surface Area - {result:f2}";
        }

        public string CalculateLateralSurfaceArea()
        {
            double result = 2 * this.Length * this.Height + 2 * this.Width * this.Height;
            return $"Lateral Surface Area - {result:f2}";
        }

        public string CalculateVolume()
        {
            double result = this.Length * this.Width * this.Height;
            return $"Volume - {result:f2}";
        }
    }
}
