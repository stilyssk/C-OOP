using System;

namespace P06_Sneaking
{
    class Sneaking
    {

        static void Main()
        {
            char[][] room;
            int dimention = int.Parse(Console.ReadLine());
            room = new char[dimention][];

            Coordinate samCoordinate = new Coordinate();
            Coordinate enemyCoordinate = new Coordinate();
            room = loadRoomData(room, dimention);
            var moves = Console.ReadLine().ToCharArray();
            samCoordinate = CalculateSamCoordinate(room, samCoordinate);
            for (int i = 0; i < moves.Length; i++)
            {
                room = MoveEnemy(room);
                enemyCoordinate = CaclulateEnemyCoordiante(room, samCoordinate, enemyCoordinate);
                PrintResult(samCoordinate, enemyCoordinate, room);
                room[samCoordinate.X][samCoordinate.Y] = '.';
                samCoordinate = readMoveCommand(moves, i, samCoordinate);
                room[samCoordinate.X][samCoordinate.Y] = 'S';
                enemyCoordinate = CaclulateEnemyCoordiante(room, samCoordinate, enemyCoordinate);
                PrintKillNikoladze(room, samCoordinate, enemyCoordinate);

            }
        }

        public static char[][] MoveEnemy(char[][] room)
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

        public static void PrintKillNikoladze(char[][] room,Coordinate samCoordinate, Coordinate enemyCoordinate)
        {
            if (room[enemyCoordinate.X][enemyCoordinate.Y] == 'N' && samCoordinate.X == enemyCoordinate.X)
            {
                room[enemyCoordinate.X][enemyCoordinate.Y] = 'X';
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

        public static Coordinate CaclulateEnemyCoordiante(char[][] room, Coordinate samCoordinate,Coordinate enemyCoordinate)
        {
            for (int j = 0; j < room[samCoordinate.X].Length; j++)
            {
                if (room[samCoordinate.X][j] != '.' && room[samCoordinate.X][j] != 'S')
                {
                    enemyCoordinate.X = samCoordinate.X;
                    enemyCoordinate.Y = j;
                }
            }
            return enemyCoordinate;
        }

        public static Coordinate CalculateSamCoordinate(char[][] room,Coordinate samCoordinate)
        {
            for (int row = 0; row < room.Length; row++)
            {
                for (int col = 0; col < room[row].Length; col++)
                {
                    if (room[row][col] == 'S')
                    {
                        samCoordinate.X = row;
                        samCoordinate.Y = col;
                    }
                }
            }
            return samCoordinate;
        }

        public static char[][] loadRoomData(char[][] room, int dimmention)
        {
            for (int row = 0; row < dimmention; row++)
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

        public static Coordinate readMoveCommand(char[] moves, int i, Coordinate samCoordinate)
        {
            switch (moves[i])
            {
                case 'U':
                    samCoordinate.X--;
                    break;
                case 'D':
                    samCoordinate.X++;
                    break;
                case 'L':
                    samCoordinate.Y--;
                    break;
                case 'R':
                    samCoordinate.Y++;
                    break;
                default:
                    break;
            }
            return samCoordinate;
        }

        public static void PrintResult(Coordinate samCoordinate, Coordinate enemyCoordinate, char[][] room)
        {
            if (samCoordinate.Y < enemyCoordinate.Y && room[enemyCoordinate.X][enemyCoordinate.Y] == 'd' && enemyCoordinate.X == samCoordinate.X)
            {
                room[samCoordinate.X][samCoordinate.Y] = 'X';
                Console.WriteLine($"Sam died at {samCoordinate.X}, {samCoordinate.Y}");
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
            else if (enemyCoordinate.Y < samCoordinate.X && room[enemyCoordinate.X][enemyCoordinate.Y] == 'b' && enemyCoordinate.X == samCoordinate.X)
            {
                room[samCoordinate.X][samCoordinate.X] = 'X';
                Console.WriteLine($"Sam died at {samCoordinate.X}, {samCoordinate.Y}");
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
    }
}
