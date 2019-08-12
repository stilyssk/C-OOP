using System;
using System.Linq;

namespace P03_JediGalaxy
{
    class Program
    {
        static void Main()
        {
            int[] dimestions = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rowLengh = dimestions[0];
            int columntLenght = dimestions[1];
            
            int[,] matrix = LoadNumberInMatrix( rowLengh, columntLenght);

            string command = Console.ReadLine();
            long sum = 0;
            while (command != "Let the Force be with you")
            {
                int[] ivoInputData = command.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                int[] evilInputData = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                ICoordinate coordinateEvil = new Coordinate(evilInputData[0], evilInputData[1]);

                while (coordinateEvil.X >= 0 && coordinateEvil.Y >= 0)
                {
                    if (CoordinateInsideInMatrix(coordinateEvil.X,coordinateEvil.Y,matrix))
                    {
                        matrix[coordinateEvil.X, coordinateEvil.Y] = 0;
                    }
                    coordinateEvil.X--;
                    coordinateEvil.Y--;
                }
                ICoordinate coordinateIvo = new Coordinate(ivoInputData[0], ivoInputData[1]);

                while (coordinateIvo.X >= 0 && coordinateIvo.Y < matrix.GetLength(1))
                {
                    if (CoordinateInsideInMatrix(coordinateIvo.X,coordinateIvo.Y,matrix))
                    {
                        sum += matrix[coordinateIvo.X, coordinateIvo.Y];
                    }

                    coordinateIvo.Y++;
                    coordinateIvo.X--;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(sum);

        }

        static int[,] LoadNumberInMatrix(int rowLengh, int columntLenght)
        {
            int[,] matrix = new int[rowLengh, columntLenght];
            int value = 0;
            for (int i = 0; i < rowLengh; i++)
            {
                for (int j = 0; j < columntLenght; j++)
                {
                    matrix[i, j] = value++;
                }
            }
            return matrix;
        }

        static bool CoordinateInsideInMatrix(int coordinateX,int CoordinateY,int[,] matrix)
        {
            return coordinateX >= 0 && coordinateX < matrix.GetLength(0) && CoordinateY >= 0 && CoordinateY < matrix.GetLength(1);
        }
    }
}
