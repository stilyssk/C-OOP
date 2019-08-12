using System;

namespace P06_Sneaking
{
    public class Sneaking
    {
        static void Main()
        {
            char[][] room;

            int roomDimention = int.Parse(Console.ReadLine());
            room = new char[roomDimention][];
            room = LoadRoomData(room, roomDimention);
            var moves = Console.ReadLine().ToCharArray();
            int[] samPosition = new int[2];
            room = GetSamCoordinate(room, samPosition);
            for (int i = 0; i < moves.Length; i++)
            {                
                room = MoveEnemy(room, moves);
                int[] getEnemy = new int[2];
                getEnemy = GetEnemyPositon(room, getEnemy, samPosition);
                if (samPosition[1] < getEnemy[1] && room[getEnemy[0]][getEnemy[1]] == 'd' && getEnemy[0] == samPosition[0])
                {
                    PrintSamDead(room, samPosition);
                }
                else if (getEnemy[1] < samPosition[1] && room[getEnemy[0]][getEnemy[1]] == 'b' && getEnemy[0] == samPosition[0])
                {
                    PrintSamDead(room, samPosition);
                }
                room[samPosition[0]][samPosition[1]] = '.';
                samPosition = MoveSam(moves, samPosition,i);
                room[samPosition[0]][samPosition[1]] = 'S';
                getEnemy = GetEnemyPositon(room, getEnemy, samPosition);
                PrintSamWin(room, getEnemy, samPosition);
            }
        }

        static char[][] LoadRoomData(char[][] room, int roomDimention)
        {
            for (int row = 0; row < roomDimention; row++)
            {
                var input = Console.ReadLine().ToCharArray();
                room[row] = new char[input.Length];
                for (int col = 0; col < input.Length; col++)
                {
                    room[row][col] = input[col];
                }
            }
            return room;
        }

        static char[][] GetSamCoordinate(char[][] room, int[] samPosition)
        {
            for (int row = 0; row < room.Length; row++)
            {
                for (int col = 0; col < room[row].Length; col++)
                {
                    if (room[row][col] == 'S')
                    {
                        samPosition[0] = row;
                        samPosition[1] = col;
                    }
                }
            }
            return room;
        }

        static char[][] MoveEnemy(char[][] room, char[] moves)
        {
            for (int row = 0; row < room.Length; row++)
            {
                for (int col = 0; col < room[row].Length; col++)
                {
                    if (room[row][col] == 'b')
                    {
                        if (row >= 0 && row < room.Length && col + 1 >= 0 && col + 1 < room[row].Length)
                        {
                            room[row][col] = '.';
                            room[row][col + 1] = 'b';
                            col++;
                        }
                        else
                        {
                            room[row][col] = 'd';
                        }
                    }
                    else if (room[row][col] == 'd')
                    {
                        if (row >= 0 && row < room.Length && col - 1 >= 0 && col - 1 < room[row].Length)
                        {
                            room[row][col] = '.';
                            room[row][col - 1] = 'd';
                        }
                        else
                        {
                            room[row][col] = 'b';
                        }
                    }
                }
            }
            return room;
        }

        static int[] MoveSam(char[] moves,int[] samPosition,int i)
        {
            switch (moves[i])
            {
                case 'U':
                    samPosition[0]--;
                    break;
                case 'D':
                    samPosition[0]++;
                    break;
                case 'L':
                    samPosition[1]--;
                    break;
                case 'R':
                    samPosition[1]++;
                    break;
                default:
                    break;
            }
            return samPosition;
        }

        static void PrintSamWin(char[][] room,int[] getEnemy,int[] samPosition)
        {
            if (room[getEnemy[0]][getEnemy[1]] == 'N' && samPosition[0] == getEnemy[0])
            {
                room[getEnemy[0]][getEnemy[1]] = 'X';
                Console.WriteLine("Nikoladze killed!");
                for (int row = 0; row < room.Length; row++)
                {
                    for (int col = 0; col < room[row].Length; col++)
                    {
                        Console.Write(room[row][col]);
                    }
                    Console.WriteLine();
                }
                Environment.Exit(0);
            }
        }

        static void PrintSamDead(char[][] room, int[] samPosition)
        {
            room[samPosition[0]][samPosition[1]] = 'X';
            Console.WriteLine($"Sam died at {samPosition[0]}, {samPosition[1]}");
            for (int row = 0; row < room.Length; row++)
            {
                for (int col = 0; col < room[row].Length; col++)
                {
                    Console.Write(room[row][col]);
                }
                Console.WriteLine();
            }
            Environment.Exit(0);
        }

        static int[] GetEnemyPositon(char[][] room, int[] getEnemy, int[] samPosition)
        {
            for (int j = 0; j < room[samPosition[0]].Length; j++)
            {
                if (room[samPosition[0]][j] != '.' && room[samPosition[0]][j] != 'S')
                {
                    getEnemy[0] = samPosition[0];
                    getEnemy[1] = j;
                }
            }
            return getEnemy;
        }

    }
}
