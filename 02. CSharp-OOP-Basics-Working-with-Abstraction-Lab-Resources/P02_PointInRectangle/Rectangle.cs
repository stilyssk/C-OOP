using System;
using System.Collections.Generic;
using System.Text;

namespace P02_PointInRectangle
{
    public class Rectangle : IRectangle
    {
        private IPoint topLeft;
        private IPoint bottomRight;

        public Rectangle(IPoint topLeft, IPoint bottomRight)
        {
            TopLeft = topLeft;
            BottomRight = bottomRight;
        }

        private IPoint TopLeft { get => topLeft; set => topLeft = value; }
        private IPoint BottomRight { get => bottomRight; set => bottomRight = value; }

        public bool Contains(IPoint currentPoint)
        {
            IPoint minLimit = new Point();
            IPoint maxLimit = new Point();
            if (topLeft.XCoordinate<BottomRight.XCoordinate)
            {
                minLimit.XCoordinate = TopLeft.XCoordinate;
                maxLimit.XCoordinate = BottomRight.XCoordinate;
            }
            else
            {
                minLimit.XCoordinate = BottomRight.XCoordinate;
                maxLimit.XCoordinate = TopLeft.XCoordinate;
            }

            if (topLeft.YCoordinate<BottomRight.YCoordinate)
            {
                minLimit.YCoordinate = TopLeft.YCoordinate;
                maxLimit.YCoordinate = BottomRight.YCoordinate;
            }
            else
            {
                minLimit.YCoordinate = BottomRight.YCoordinate;
                maxLimit.YCoordinate = TopLeft.YCoordinate;
            }

            if (currentPoint.XCoordinate>=minLimit.XCoordinate&&currentPoint.XCoordinate<=maxLimit.XCoordinate)
            {
                if (currentPoint.YCoordinate >= minLimit.YCoordinate && currentPoint.YCoordinate <= maxLimit.YCoordinate)
                {
                    return true;
                }

            }

            return false;
        }
    }
}
