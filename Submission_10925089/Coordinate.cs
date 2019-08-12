namespace P03_JediGalaxy
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Coordinate : ICoordinate
    {
        private int x;
        private int y;

        public Coordinate(int[] inputCoordinate)
        {
            X = inputCoordinate[0];
            Y = inputCoordinate[1];
        }

        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
    }
}
