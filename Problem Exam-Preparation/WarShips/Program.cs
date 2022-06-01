using System;
using System.Linq;

namespace WarShips
{
    internal class Program
    {
        //private static int playerRow1;
        //private static int playerCol1;
        //private static int playerRow2;
        //private static int playerCol2;
        private static char[,] matrix;
        private static int playerShips1;
        private static int playerShips2;
        private static int leftShips;
        private static int startingShips;
        static void Main(string[] args)
        {


            playerShips1 = 0;
            playerShips2 = 0;

            
            int size = int.Parse(Console.ReadLine());

            string[] input = Console.ReadLine().Split(',', StringSplitOptions.RemoveEmptyEntries);
            matrix = new char[size, size];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] input2 = Console.ReadLine().Split().Select(char.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input2[col];
                    if (matrix[row, col] == '<')
                    {
                        playerShips1++;

                    }
                    if (matrix[row, col] == '>')
                    {
                        playerShips2++;

                    }

                }
            }
            leftShips = playerShips1 + playerShips2;
            startingShips=leftShips;

            for (int i = 0; i < input.Length; i++)
            {
                int[] coordinate = input[i].Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                int row = coordinate[0];
                int col = coordinate[1];


                war(row, col);
            }
            if (playerShips1 <= 0)
            {
                Console.WriteLine($"Player Two has won the game! {startingShips - leftShips} ships have been sunk in the battle.");
                
                Environment.Exit(0);
            }
            if (playerShips2 <= 0)
            {
                Console.WriteLine($"Player One has won the game! {startingShips - leftShips} ships have been sunk in the battle.");
                
                Environment.Exit(0);
            }
            
                Console.WriteLine($"It's a draw! Player One has {playerShips1} ships left. Player Two has {playerShips2} ships left.");
               
            
           



        }

        static void printingMatrix(char[,] matrix)
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
        static bool hasValidCordinates(int row, int col)
        {
            return row >= 0 && row < matrix.GetLength(0) &&
                  col >= 0 && col < matrix.GetLength(1);
        }
        static void war(int row, int col)
        {

            if (!hasValidCordinates(row, col))
            {
                return;
            }
            if (playerShips1 <= 0)
            {
                Console.WriteLine($"Player Two has won the game! {startingShips-leftShips} ships have been sunk in the battle.");
                
                Environment.Exit(0);
            }
            if (playerShips2 <= 0)
            {
                Console.WriteLine($"Player One has won the game! {startingShips-leftShips} ships have been sunk in the battle.");
                
                Environment.Exit(0);
            }


            if (matrix[row, col] == '>')
            {
                playerShips2--;
                leftShips--;
                matrix[row, col] = 'X';
            }
            else if (matrix[row, col] == '<')
            {
                playerShips1--;
                leftShips--;
                matrix[row, col] = 'X';
            }
            else if (matrix[row, col] == '#')
            {
                explosion(row, col);
            }

        }
        static void explosion(int row, int col)
        {
            //up
            if (hasValidCordinates(row - 1, col))
            {
                if (matrix[row - 1, col] == '<')
                {
                    playerShips1--;
                    leftShips--;
                }
                else if (matrix[row - 1, col] == '>')
                {
                    playerShips2--;
                    leftShips--;
                }
                matrix[row - 1, col] = 'X';

            }
            //down
            if (hasValidCordinates(row + 1, col))
            {
                if (matrix[row + 1, col] == '<')
                {
                    playerShips1--;
                    leftShips--;
                }
                else if (matrix[row + 1, col] == '>')
                {
                    playerShips2--;
                    leftShips--;
                }
                matrix[row + 1, col] = 'X';
            }
            // right
            if (hasValidCordinates(row, col + 1))
            {
                if (matrix[row, col + 1] == '<')
                {
                    playerShips1--;
                    leftShips--;
                }
                else if (matrix[row, col + 1] == '>')
                {
                    playerShips2--;
                    leftShips--;
                }
                matrix[row, col + 1] = 'X';
            }
            // left
            if (hasValidCordinates(row, col - 1))
            {
                if (matrix[row, col - 1] == '<')
                {
                    playerShips1--;
                    leftShips--;
                }
                else if (matrix[row, col - 1] == '>')
                {
                    playerShips2--;
                    leftShips--;
                }
                matrix[row, col - 1] = 'X';
            }
            // up left
            if (hasValidCordinates(row - 1, col - 1))
            {
                if (matrix[row - 1, col - 1] == '<')
                {
                    playerShips1--;
                    leftShips--;
                }
                else if (matrix[row - 1, col - 1] == '>')
                {
                    playerShips2--;
                    leftShips--;
                }
                matrix[row - 1, col - 1] = 'X';
            }
            // up right
            if (hasValidCordinates(row - 1, col + 1))
            {
                if (matrix[row - 1, col + 1] == '<')
                {
                    playerShips1--;
                    leftShips--;
                }
                else if (matrix[row - 1, col + 1] == '>')
                {
                    playerShips2--;
                    leftShips--;
                }
                matrix[row - 1, col + 1] = 'X';
            }
            // down right
            if (hasValidCordinates(row + 1, col + 1))
            {
                if (matrix[row + 1, col + 1] == '<')
                {
                    playerShips1--;
                    leftShips--;
                }
                else if (matrix[row + 1, col + 1] == '>')
                {
                    playerShips2--;
                    leftShips--;
                }
                matrix[row + 1, col + 1] = 'X';
            }
            if (hasValidCordinates(row + 1, col - 1))
            {
                if (matrix[row + 1, col - 1] == '<')
                {
                    playerShips1--;
                    leftShips--;
                }
                else if (matrix[row + 1, col - 1] == '>')
                {
                    playerShips2--;
                    leftShips--;
                }
                matrix[row + 1, col - 1] = 'X';
            }


        }
    }


}
