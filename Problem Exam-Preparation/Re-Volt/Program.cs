using System;
using System.Collections.Generic;
using System.Linq;

namespace Re_Volt
{
    internal class Program
    {
        private static int playerRow;
        private static int playerCol;
        private static string lastDirection;
        private static char[,] matrix;

        static void Main(string[] args)
        {


            int size = int.Parse(Console.ReadLine());
            int commandsToRead = int.Parse(Console.ReadLine());

            var won = new List<string>();

            matrix = new char[size, size];
            playerRow = 0;
            playerCol = 0;

            for (int i = 0; i < size; i++)
            {
                char[] input = Console.ReadLine().ToCharArray();

                for (int j = 0; j < size; j++)
                {
                    matrix[i, j] = input[j];

                    if (matrix[i, j] == 'f')
                    {
                        playerRow = i;
                        playerCol = j;
                    }
                }
            }


            for (int i = 0; i <= commandsToRead; i++)
            {
                string cmd = Console.ReadLine();
                lastDirection = cmd;


                if (cmd == "up")
                {
                    move(-1, 0, won);
                    if (won.Any())
                    {
                        break;
                    }
                }
                else if (cmd == "down")
                {
                    move(1, 0, won);
                    if (won.Any())
                    {
                        break;
                    }
                }
                else if (cmd == "right")
                {
                    move(0, 1, won);
                    if (won.Any())
                    {
                        break;
                    }
                }
                else if (cmd == "left")
                {
                    move(0, -1, won);
                    if (won.Any())
                    {
                        break;
                    }
                }
            }
            if (commandsToRead > 0 && !won.Any())
            {
                Console.WriteLine("Player lost!");
                PrintingMatix(matrix);
            }

        }

        static void PrintingMatix(char[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }
        }

        static void move(int row, int col, List<string> won)
        {
            if (!hasValidCordinates(playerRow + row, playerCol + col))
            {
                
                matrix[playerRow, playerCol] = '-';
                if (lastDirection == "up")
                {
                    playerRow = matrix.GetLength(0) - 1;
                    hasHewon(matrix, won);
                    matrix[matrix.GetLength(0) - 1, playerCol] = 'f';
                    return;
                }
                else if (lastDirection == "down")
                {
                    playerRow = 0;
                    hasHewon(matrix, won);
                    matrix[0, playerCol] = 'f';
                    return;
                }
                else if (lastDirection == "right")
                {
                    playerCol = 0;
                    hasHewon(matrix, won);
                    matrix[playerRow, 0] = 'f';
                    return;
                }
                else if (lastDirection == "left")
                {
                    playerCol = matrix.GetLength(1) - 1;
                    hasHewon(matrix, won);
                    matrix[playerRow, matrix.GetLength(1) - 1] = 'f';
                    return;

                }

            }
            matrix[playerRow, playerCol] = '-';
            playerRow += row;
            playerCol += col;
            hasHewon(matrix, won);

            if (lastDirection == "up")
            {
                ;
                if (matrix[playerRow, playerCol] == 'B')
                {
                    playerRow--;
                    if (!hasValidCordinates(playerRow, playerCol))
                    {
                        playerRow = matrix.GetLength(0) - 1;
                    }

                }
                else if (matrix[playerRow, playerCol] == 'T')
                {
                    playerRow++;
                    if (!hasValidCordinates(playerRow, playerCol))
                    {
                        playerRow = 0;
                    }

                }
            }
            else if (lastDirection == "down")
            {

                if (matrix[playerRow, playerCol] == 'B')
                {
                    playerRow++;
                    if (!hasValidCordinates(playerRow, playerCol))
                    {
                        playerRow = 0;
                    }

                }
                else if (matrix[playerRow, playerCol] == 'T')
                {
                    playerRow--;
                    if (!hasValidCordinates(playerRow, playerCol))
                    {
                        playerRow = matrix.GetLength(0) - 1;
                    }

                }

            }
            else if (lastDirection == "right")
            {
                if (matrix[playerRow, playerCol] == 'B')
                {
                    playerCol++;
                    if (!hasValidCordinates(playerRow, playerCol))
                    {
                        playerCol = 0;
                    }


                }
                else if (matrix[playerRow, playerCol] == 'T')
                {
                    playerCol--;
                    if (!hasValidCordinates(playerRow, playerCol))
                    {
                        playerCol = matrix.GetLength(1) - 1;
                    }

                }
            }
            else if (lastDirection == "left")
            {

                if (matrix[playerRow, playerCol] == 'B')
                {
                    playerCol--;
                    if (!hasValidCordinates(playerRow, playerCol))
                    {
                        playerCol = matrix.GetLength(1) - 1;
                    }

                }
                else if (matrix[playerRow, playerCol] == 'T')
                {
                    playerCol++;
                    if (!hasValidCordinates(playerRow, playerCol))
                    {
                        playerCol = 0;
                    }
                }

            }
            hasHewon(matrix, won);
            matrix[playerRow, playerCol] = 'f';
        }

        static void hasHewon(char[,] matrix, List<string> won)
        {
            if (matrix[playerRow, playerCol] == 'F')
            {
                Console.WriteLine("Player won!");
                matrix[playerRow, playerCol] = 'f';
                PrintingMatix(matrix);
                won.Add("won");
                return;
            }
        }

        static bool hasValidCordinates(int row, int col)
        {
            return row >= 0 && row < matrix.GetLength(0) &&
                  col >= 0 && col < matrix.GetLength(1);
        }

    }
}
