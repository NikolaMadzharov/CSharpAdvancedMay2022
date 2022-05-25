using System;
using System.Collections.Generic;

namespace TruffleHunter
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            string[,] matrix = new string[n, n];
            int countBlackTruffles = 0;
            int countSummerTruffles = 0;
            int countWhiteTruffles = 0;
            int wildBoarEatenTruffles = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] fillMatrix = Console.ReadLine().Split(' ');
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = fillMatrix[col];

                }
            }
            string cmd = Console.ReadLine();

            while (cmd != "Stop the hunt")
            {
                string[] input = cmd.Split();
                string action = input[0];
                int row = int.Parse(input[1]);
                int col = int.Parse(input[2]);

                if (action == "Collect")
                {

                    if (matrix[row, col] == "B")
                    {
                        countBlackTruffles += 1;
                        matrix[row, col] = "-";
                    }
                    else if (matrix[row, col] == "S")
                    {
                        countSummerTruffles += 1;
                        matrix[row, col] = "-";
                    }
                    else if (matrix[row, col] == "W")
                    {
                        countWhiteTruffles += 1;
                        matrix[row, col] = "-";
                    }
                }
                else if (action == "Wild_Boar")
                {

                    string direction = input[3];



                    if (direction == "up")
                    {
                        for (int i = row; i >= 0; i -= 2)
                        {
                            if (matrix[i, col] == "S")
                            {
                                matrix[i, col] = "-";
                                wildBoarEatenTruffles++;
                            }
                            else if (matrix[i, col] == "B")
                            {
                                matrix[i, col] = "-";
                                wildBoarEatenTruffles++;
                            }
                            else if (matrix[i, col] == "W")
                            {
                                matrix[i, col] = "-";
                                wildBoarEatenTruffles++;
                            }

                        }


                    }
                    else if (direction == "down")
                    {
                        for (int i = row; i < matrix.GetLength(0) ; i+=2)
                        {
                            if (matrix[i, col] == "S")
                            {
                                matrix[i, col] = "-";
                                wildBoarEatenTruffles++;
                            }
                            else if (matrix[i, col] == "B")
                            {
                                matrix[i, col] = "-";
                                wildBoarEatenTruffles++;
                            }
                            else if (matrix[i, col] == "W")
                            {
                                matrix[i, col] = "-";
                                wildBoarEatenTruffles++;
                            }
                        }
                    }
                    else if (direction == "right")
                    {
                        for (int i = col; i < matrix.GetLength(1) ; i += 2)
                        {
                            if (matrix[row, i] == "S")
                            {
                                matrix[row, i] = "-";
                                wildBoarEatenTruffles++;
                            }
                            else if (matrix[i, col] == "B")
                            {
                                matrix[row, i] = "-";
                                wildBoarEatenTruffles++;
                            }
                            else if (matrix[row, i] == "W")
                            {
                                matrix[row, i] = "-";
                                wildBoarEatenTruffles++;
                            }
                        }
                    }
                    else if (direction == "left")
                    {
                        for (int i = col; i >= 0; i -= 2)
                        {
                            if (matrix[row, i] == "S")
                            {
                                matrix[row, i] = "-";
                                wildBoarEatenTruffles++;
                            }
                            else if (matrix[row, i] == "B")
                            {
                                matrix[row, i] = "-";
                                wildBoarEatenTruffles++;
                            }
                            else if (matrix[row, i] == "W")
                            {
                                matrix[row, i] = "-";
                                wildBoarEatenTruffles++;
                            }
                        }
                    }



                }
                cmd = Console.ReadLine();
                //// down
                //for (int i = row; i < matrix.GetLength(0)-1; i++)
                //{

                //}
                ////right 
                //for (int i = col; i < matrix.GetLength(1)-1; i+=2)
                //{

                //}
                //// left 
                //for (int i = col ; i >= 0; i-=2)
                //{

                //}
            }
            Console.WriteLine($"Peter manages to harvest {countBlackTruffles} black, {countSummerTruffles} summer, and {countWhiteTruffles} white truffles.");
            Console.WriteLine($"The wild boar has eaten {wildBoarEatenTruffles} truffles.");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i, j] + " ", StringSplitOptions.RemoveEmptyEntries);
                }
                Console.WriteLine();
            }
        }
    }
}
