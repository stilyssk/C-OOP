using System;
using System.Collections.Generic;
using System.Text;

namespace P06_Sneaking
{
    public class FightPlant
    {
        private Coordinate samCoorinate;
        private Coordinate nikoladzeCoordinate;
        private List<Coordinate> enemiCoordinate;
        private Char[] moveCommands;
        private char[][] fightPlant;

        public void SetPlantData(char[][] inputFightPlant)
        {

           

        }

        public void Run()
        {
            this.GetSamPosition();
            this.GetEnemyPositions();
            this.GetNicoladzePositions();
        }
        public Coordinate SamCoorinate
        {
            set
            {
                this.samCoorinate = value;

            }
        }


        public void ReadMoveCommand(char[] moveCommand)
        {
            this.moveCommands = moveCommand;
        }

        public void MoveCommand(char moveCommand)
        {
            fightPlant[samCoorinate.X][samCoorinate.Y] = '.';
            switch (moveCommand)
            {
                case 'U':
                    samCoorinate.X--;
                    break;
                case 'D':
                    samCoorinate.X++;
                    break;
                case 'L':
                    samCoorinate.Y--;
                    break;
                case 'R':
                    samCoorinate.Y++;
                    break;
                default:
                    break;
            }
            fightPlant[samCoorinate.X][samCoorinate.Y] = 'S';
        }
        public void GetEnemyPositions()
        {
            int[] getEnemy = new int[2];
            for (int j = 0; j < fightPlant[samCoorinate.X].Length; j++)
            {
                if (fightPlant[samCoorinate.X][j] != '.' && fightPlant[samCoorinate.X][j] != 'S')
                {
                    getEnemy[0] = samCoorinate.X;
                    getEnemy[1] = j;
                }
            }
        }

        private void GetSamPosition()
        {
            for (int row = 0; row < fightPlant.Length; row++)
            {
                for (int col = 0; col < fightPlant[row].Length; col++)
                {
                    if (fightPlant[row][col] == 'S')
                    {
                        samCoorinate.X = row;
                        samCoorinate.Y = col;
                    }
                }
            }
        }

        private void GetNicoladzePositions()
        {

        }
        private void MoveEnemy()
        {
            for (int i = 0; i < moveCommands.Length; i++)
            {
                for (int row = 0; row < fightPlant.Length; row++)
                {
                    for (int col = 0; col < fightPlant[row].Length; col++)
                    {
                        if (fightPlant[row][col] == 'b')
                        {
                            if (row >= 0 && row < fightPlant.Length && col + 1 >= 0 && col + 1 < fightPlant[row].Length)
                            {
                                fightPlant[row][col] = '.';
                                fightPlant[row][col + 1] = 'b';
                                col++;
                            }
                            else
                            {
                                fightPlant[row][col] = 'd';
                            }
                        }
                        else if (fightPlant[row][col] == 'd')
                        {
                            if (row >= 0 && row < fightPlant.Length && col - 1 >= 0 && col - 1 < fightPlant[row].Length)
                            {
                                fightPlant[row][col] = '.';
                                fightPlant[row][col - 1] = 'd';
                            }
                            else
                            {
                                fightPlant[row][col] = 'b';
                            }
                        }
                    }
                }
            }
        }
        private void CheckKillSam()
        {

        }


        private void CheckKillNicoladze()
        {

        }


    }
}
