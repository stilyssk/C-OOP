using Shapes.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes.Classes
{
    public class Rectangle : IDrawable
    {
        private int width;
        private int height;

        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public int Width
        {
            get => width;
            set => width = value;
        }
        public int Height
        {
            get => height;
            set => height = value;
        }

        public void Draw()
        {
            DrowLine(Width, '*', '*');
            for (int i = 1; i < Height-1; ++i)
            {
                DrowLine(Width, '*', ' ');
            }
            DrowLine(Width, '*', '*');

        }

        private void DrowLine(int width, char end, char mid)
        {
            Console.Write(end);
            for (int i = 1; i < Width-1; ++i)
            {
                Console.Write(mid);
            }
            Console.WriteLine(end);
        }
    }
}
