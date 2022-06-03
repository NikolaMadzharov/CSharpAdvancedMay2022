using System;

namespace examPreparation
{
    internal class Program
    {
        private static char[,] matrix;

        private static int playerRow;
        private static int playerCol;

        private static int firstMRow;
        private static int firstMCol;

        private static int secondMRow;
        private static int secondMCol;

        private static int totalCoins;

        private static string lastDirection;

        private static bool isExist;

        private static int mirrorCount;

        static void Main(string[] args)
        {
           
            int size = int.Parse(Console.ReadLine());
            matrix = new char[size,size];
             mirrorCount = 0;
            totalCoins = 0;
            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                char[] input = Console.ReadLine().ToCharArray();
                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    matrix[r, c] = input[c];
                    if (matrix[r,c]=='M')
                    {
                        if (mirrorCount==0)
                        {
                            firstMRow = r;
                            firstMCol = c;
                            mirrorCount++;
                        }
                        secondMRow = r;
                        secondMCol = c;
                       
                    }
                    if (matrix[r,c]=='A')
                    {
                        playerRow = r;
                        playerCol = c;
                    }
                }
            }
            while (!isExist)
            {
                string cmd = Console.ReadLine();
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

                
            }

        }
        static void printingMatrix(char[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int z = 0; z < matrix.GetLength(1); z++)
                {
                    Console.Write(matrix[i,z]);
                }
                Console.WriteLine();
            }
        }
        static void move(int row, int col)
        {
            
            matrix[playerRow, playerCol] = '-';
            playerRow += row;
            playerCol += col;

            if (lastDirection == "up")
            {
                if (hasValidCordinates(playerRow, playerCol))
                {
                    if (char.IsDigit(matrix[playerRow, playerCol]))
                    {
                        totalCoins += int.Parse(matrix[playerRow, playerCol].ToString());
                    }
                    if ( mirrorCount>0)
                    {
                        if (matrix[playerRow, playerCol] == matrix[firstMRow, firstMCol])
                        {

                            playerRow = secondMRow;
                            playerCol = secondMCol;
                            matrix[firstMRow, firstMCol] = '-';
                        }
                        else if (matrix[playerRow, playerCol] == matrix[secondMRow, secondMCol])
                        {

                            playerRow = firstMRow;
                            playerCol = firstMCol;
                            matrix[secondMRow, secondMCol] = '-';
                        }
                    }
                    
                }
                else
                {
                    Console.WriteLine("I do not need more swords!");
                    Console.WriteLine($"The king paid {totalCoins} gold coins.");
                    printingMatrix(matrix);
                    isExist = false;
                    Environment.Exit(0);

                }
            }
           else if (lastDirection == "down")
            {
                if (hasValidCordinates(playerRow, playerCol))
                {
                    if (char.IsDigit(matrix[playerRow, playerCol]))
                    {
                        totalCoins += int.Parse(matrix[playerRow, playerCol].ToString());
                    }
                    if ( mirrorCount>0)
                    {
                        if (matrix[playerRow, playerCol] == matrix[firstMRow, firstMCol])
                        {

                            playerRow = secondMRow;
                            playerCol = secondMCol;
                            matrix[firstMRow, firstMCol] = '-';
                        }
                        else if (matrix[playerRow, playerCol] == matrix[secondMRow, secondMCol])
                        {

                            playerRow = firstMRow;
                            playerCol = firstMCol;
                            matrix[secondMRow, secondMCol] = '-';
                        }
                    }
                   
                }
                else
                {
                    Console.WriteLine("I do not need more swords!");
                    Console.WriteLine($"The king paid {totalCoins} gold coins.");
                    printingMatrix(matrix);
                    isExist = false;
                    Environment.Exit(0);

                }
            }
           else if (lastDirection == "right")
            {
                if (hasValidCordinates(playerRow, playerCol))
                {
                    if (char.IsDigit(matrix[playerRow, playerCol]))
                    {
                        totalCoins += int.Parse(matrix[playerRow, playerCol].ToString());
                    }
                    if (mirrorCount > 0)
                    {
                        if (matrix[playerRow, playerCol] == matrix[firstMRow, firstMCol])
                        {

                            playerRow = secondMRow;
                            playerCol = secondMCol;
                            matrix[firstMRow, firstMCol] = '-';
                        }
                        else if (matrix[playerRow, playerCol] == matrix[secondMRow, secondMCol])
                        {

                            playerRow = firstMRow;
                            playerCol = firstMCol;
                            matrix[secondMRow, secondMCol] = '-';
                        }
                    }
                }
                else
                {
                    Console.WriteLine("I do not need more swords!");
                    Console.WriteLine($"The king paid {totalCoins} gold coins.");
                    printingMatrix(matrix);
                    isExist = false;
                    Environment.Exit(0);

                }
            }
            else if (lastDirection == "left")
            {
                if (hasValidCordinates(playerRow, playerCol))
                {
                    if (char.IsDigit(matrix[playerRow, playerCol]))
                    {
                        totalCoins += int.Parse(matrix[playerRow, playerCol].ToString());
                    }
                    if (mirrorCount > 0)
                    {
                        if (matrix[playerRow, playerCol] == matrix[firstMRow, firstMCol])
                        {

                            playerRow = secondMRow;
                            playerCol = secondMCol;
                            matrix[firstMRow, firstMCol] = '-';
                        }
                        else if (matrix[playerRow, playerCol] == matrix[secondMRow, secondMCol])
                        {

                            playerRow = firstMRow;
                            playerCol = firstMCol;
                            matrix[secondMRow, secondMCol] = '-';
                        }
                    }
                }
                else
                {
                    Console.WriteLine("I do not need more swords!");
                    Console.WriteLine($"The king paid {totalCoins} gold coins.");
                    printingMatrix(matrix);
                    isExist = false;
                    Environment.Exit(0);

                }
            }
            matrix[playerRow, playerCol] = 'A';
            if (totalCoins >= 65)
            {
                Console.WriteLine("Very nice swords, I will come back for more!");
                Console.WriteLine($"The king paid {totalCoins} gold coins.");
                printingMatrix(matrix);
                isExist = false;
                Environment.Exit(0);
            }



        }
       
        static bool hasValidCordinates(int row, int col)
        {
            return row >= 0 && row < matrix.GetLength(0) &&
                  col >= 0 && col < matrix.GetLength(1);
        }
    }
}

