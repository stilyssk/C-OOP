using System;
using System.Collections.Generic;
using System.Text;

namespace P02_PointInRectangle
{
    public class Point : IPoint
    {
        private int xCoordinate;
        private int yCoordinate;
        public int XCoordinate { get { return this.xCoordinate; } set { this.xCoordinate = value; } }
        public int YCoordinate { get { return this.yCoordinate; } set { this.yCoordinate = value; } }
    }
}
