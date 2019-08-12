using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P03_JediGalaxy
{
    public class DoMagic : IDoMagic
    {

        private int[,] matrix;
        private long sum;
        private ICoordinate enemyCoordinate;
        private ICoordinate ivoCoordinate ;

        public DoMagic(int rowCount, int columnCount)
        {
            LoadMatrixWhitData(rowCount, columnCount);
            this.Sum = 0;
            this.Main();
        }

        private int[,] Matrix { get => this.matrix; set => this.matrix = value; }
        private long Sum { get => this.sum; set => this.sum = value; }
        public ICoordinate EnemyCoordinate { get => enemyCoordinate; set => enemyCoordinate = value; }
        public ICoordinate IvoCoordinate { get => ivoCoordinate; set => ivoCoordinate = value; }

        private void Main()
        {
            string command = Console.ReadLine();

            while (command != "Let the Force be with you")
            {
                int[] ivoInpuCoordinate = SplitStringToArray(command);
                int[] evilInputCoordinate = SplitStringToArray(Console.ReadLine());
                EnemyCoordinate = new Coordinate(evilInputCoordinate);
                MoveEnemyCalculate(enemyCoordinate);

                IvoCoordinate = new Coordinate(ivoInpuCoordinate);
                MoveIvoCoordinate(ivoCoordinate);
                command = Console.ReadLine();
            }
        }

        private void LoadMatrixWhitData(int rowCount, int columnCount)
        {
            this.Matrix = new int[rowCount, columnCount];
            int value = 0;
            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < columnCount; j++)
                {
                    this.Matrix[i, j] = value++;
                }
            }
        }

        private int[] SplitStringToArray(string inputString)
        {
            int[] result = inputString
                .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            return result;
        }

        private bool CheckInsideInMatrix(ICoordinate coordinate)
        {
            return coordinate.X >= 0 
                && coordinate.X < Matrix.GetLength(0) 
                && coordinate.Y >= 0 
                && coordinate.Y < Matrix.GetLength(1);
        }

        private void MoveEnemyCalculate(ICoordinate coordinate)
        {
            while (coordinate.X >= 0 && coordinate.Y >= 0)
            {
                if (CheckInsideInMatrix(coordinate))
                {
                    Matrix[coordinate.X, coordinate.Y] = 0;
                }
                coordinate.X--;
                coordinate.Y--;
            }
        }

        private void MoveIvoCoordinate(ICoordinate ivoCoordinate)
        {
            while (ivoCoordinate.X >= 0 && ivoCoordinate.Y < matrix.GetLength(1))
            {
                if (CheckInsideInMatrix(ivoCoordinate))
                {
                    this.Sum += Matrix[ivoCoordinate.X, ivoCoordinate.Y];
                }

                ivoCoordinate.Y++;
                ivoCoordinate.X--;
            }
        }

        public override string ToString()
        {
            return this.Sum.ToString();
        }
    }
}
