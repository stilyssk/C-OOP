using System;
using System.Linq;

namespace P03_JediGalaxy
{
    class Program
    {
        static void Main()
        {
            int[] dimestions = Console.ReadLine()
                .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int dimentionX = dimestions[0];
            int dimentionY = dimestions[1];
            JedyGalaxyMatrix galaxyMatrix = new JedyGalaxyMatrix(dimentionX, dimentionY);
            string command = Console.ReadLine();

            while (command != "Let the Force be with you")
            {
                int[] ivoStartCoordinate = ReadCoordinate(command);
                int[] evilStartCoordinate = ReadCoordinate(Console.ReadLine());

                int enemyXCoordiante = evilStartCoordinate[0];
                int enemyYCoordinate = evilStartCoordinate[1];
                int ivoXCoordinate = ivoStartCoordinate[0];
                int ivoYCoordiante = ivoStartCoordinate[1];
                galaxyMatrix.setIvoCoordinate(ivoXCoordinate, ivoYCoordiante);
                galaxyMatrix.setEnemyCoordinate(enemyXCoordiante, enemyYCoordinate);

                galaxyMatrix.RemoveEnemyPath();

                galaxyMatrix.CalculateSumPathIvo();


                command = Console.ReadLine();
            }

            Console.WriteLine(galaxyMatrix.GetResult());
        }
        static int[] ReadCoordinate(string inputCommand)
        {

            int[] result = inputCommand
                .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            return result;
        }
    }

}
