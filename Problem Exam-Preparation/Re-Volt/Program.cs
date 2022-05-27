using System;
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
            string cmd = Console.ReadLine();
            while (commandsToRead > 0)
            {
                commandsToRead--;
                lastDirection = cmd;
                if (cmd == "up")
                {
                    move(-1, 0);
                }
                else if (cmd == "down")
                {
                    move(1, 0);
                }
                else if (cmd == "right")
                {
                    move(0, 1);
                }
                else if (cmd == "left")
                {
                    move(0, -1);
                }
                //if (hasHeWon(matrix) == true)
                //{
                //    Console.WriteLine("Player won");
                //    PrintingMatix(matrix);
                //    return;
                //}
            }
            Console.WriteLine("Player lost!");
            PrintingMatix(matrix);


        }

        static void PrintingMatix(char[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ", StringSplitOptions.RemoveEmptyEntries);
                }
                Console.WriteLine();
            }
        }

        static void move(int row, int col)
        {
            if (!hasValidCordinates(playerRow + row, playerCol + col))
            {
                matrix[playerRow, playerCol] = '-';
                if (lastDirection == "up")
                {
                    matrix[matrix.GetLength(0) - 1, playerCol] = 'f';
                    playerRow = matrix.GetLength(0);
                    return;
                }
                else if (lastDirection == "down")
                {
                    matrix[0, playerCol] = 'f';
                    playerRow = 0;
                    return;
                }
                else if (lastDirection == "right")
                {
                    matrix[playerRow, 0] = 'f';
                    playerCol = 0;
                    return;
                }
                else if (lastDirection == "left")
                {
                    matrix[playerRow, matrix.GetLength(1) - 1] = 'f';
                    playerCol = matrix.GetLength(1);
                    return;

                }
            }
          

            playerRow += row;
            playerCol += col;

            if (lastDirection == "up")
            {
                if (matrix[playerRow, playerCol] == 'B')
                {
                    matrix[playerRow - 1, playerCol] = 'f';
                    playerRow--;
                }
                else if (matrix[playerRow, playerCol] == 'T')
                {
                    matrix[playerRow + 1, playerCol] = 'f';
                    playerRow++;
                }
            }
            else if (lastDirection == "down")
            {
                if (matrix[playerRow, playerCol] == 'B')
                {
                    matrix[playerRow + 1, playerCol] = 'f';
                    playerRow++;
                }
                else if (matrix[playerRow, playerCol] == 'T')
                {
                    matrix[playerRow - 1, playerCol] = 'f';
                    playerRow--;
                }
            }
            else if (lastDirection == "right")
            {
                if (matrix[playerRow, playerCol] == 'B')
                {
                    matrix[playerRow, playerCol + 1] = 'f';
                    playerCol++;
                }
                else if (matrix[playerRow, playerCol] == 'T')
                {
                    matrix[playerRow, playerCol - 1] = 'F';
                    playerCol--;
                }
            }
            else if (lastDirection == "left")
            {
                if (matrix[playerRow, playerCol] == 'B')
                {
                    matrix[playerRow, playerCol - 1] = 'f';
                    playerCol--;
                }
                else if (matrix[playerRow, playerCol] == 'T')
                {
                    matrix[playerRow, playerCol + 1] = 'f';
                    playerCol++;
                }
            }
        }



        static bool hasValidCordinates(int row, int col)
        {
            return row >= 0 && row < matrix.GetLength(0) &&
                  col >= 0 && col < matrix.GetLength(1);
        }
        static bool hasHeWon(char[,] matrix)
        {
            return matrix[playerRow, playerCol] == 'F';
        }
    }
}
