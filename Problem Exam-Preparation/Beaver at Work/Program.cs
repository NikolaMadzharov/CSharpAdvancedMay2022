using System;
using System.Collections.Generic;
using System.Linq;

namespace Survivor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];
            List<char> woodBranches = new List<char>();
            int woodBranchCount = 0;
            int beaverRow = -10;
            int beaverCol = -10;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] input = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];
                    if (matrix[row, col] != 'F' && matrix[row, col] != '-' && matrix[row, col] != 'B')
                    {
                        woodBranchCount++;
                    }
                    if (matrix[row, col] == 'B')
                    {
                        beaverRow = row;
                        beaverCol = col;
                    }
                }
            }


            string cmd = Console.ReadLine();
            while (cmd != "end")
            {
                if (woodBranchCount.Equals(0))
                {
                    Console.WriteLine($"The Beaver successfully collect {woodBranches.Count} wood branches: {string.Join(", ",woodBranches)}.");
                    
                    break;
                }


                if (cmd == "up")
                {
                    if (beaverRow - 1 >= 0 && beaverRow - 1 < matrix.GetLength(0))
                    {
                        if (char.IsLower(matrix[beaverRow - 1, beaverCol]))
                        {
                            woodBranches.Add(matrix[beaverRow - 1, beaverCol]);
                            woodBranchCount--;
                            matrix[beaverRow, beaverCol] = '-';
                            matrix[beaverRow - 1, beaverCol] = 'B';
                            beaverRow--;
                        }
                        else if (matrix[beaverRow - 1, beaverCol] == 'F')
                        {
                            if (beaverRow - 1 == 0)
                            {
                                matrix[beaverRow - 1, beaverCol] = '-';
                                matrix[beaverRow, beaverCol] = '-';
                                matrix[matrix.GetLength(0) - 1, beaverCol] = 'B';
                                beaverRow = matrix.GetLength(0) - 1;
                            }
                            else
                            {
                                matrix[beaverRow - 1, beaverCol] = '-';
                                matrix[0, beaverCol] = 'B';
                                beaverRow = 0;
                            }

                        }
                    }
                    else
                    {
                        woodBranches.RemoveAt(woodBranches.Count - 1);
                    }



                }
                else if (cmd == "down")
                {
                    if (beaverRow + 1 >= 0 && beaverRow + 1 < matrix.GetLength(0))
                    {
                        if (char.IsLower(matrix[beaverRow + 1, beaverCol]))
                        {
                            woodBranches.Add(matrix[beaverRow + 1, beaverCol]);
                            woodBranchCount--;
                            matrix[beaverRow, beaverCol] = '-';
                            matrix[beaverRow + 1, beaverCol] = 'B';
                            beaverRow++;
                        }
                        else if (matrix[beaverRow + 1, beaverCol] == 'F')
                        {
                            if (beaverRow + 1 == matrix.GetLength(0) - 1)
                            {
                                matrix[beaverRow + 1, beaverCol] = '-';
                                matrix[beaverRow, beaverCol] = '-';
                                matrix[0, beaverCol] = 'B';
                                beaverRow = 0;
                            }
                            else
                            {
                                matrix[beaverRow + 1, beaverCol] = '-';
                                matrix[matrix.GetLength(0) - 1, beaverCol] = 'B';
                                beaverRow = matrix.GetLength(0) - 1;
                            }

                        }
                    }
                    else
                    {
                        woodBranches.RemoveAt(woodBranches.Count - 1);
                    }
                }
                else if (cmd == "right")
                {
                    if (beaverCol + 1 < matrix.GetLength(1))
                    {
                        if (char.IsLower(matrix[beaverRow, beaverCol + 1]))
                        {
                            woodBranches.Add(matrix[beaverRow, beaverCol + 1]);
                            woodBranchCount--;
                            matrix[beaverRow, beaverCol] = '-';
                            matrix[beaverRow, beaverCol + 1] = 'B';
                            beaverCol++;
                        }
                        else if (matrix[beaverRow, beaverCol + 1] == 'F')
                        {
                            if (beaverCol + 1 == matrix.GetLength(1) - 1)
                            {
                                matrix[beaverRow, beaverCol] = '-';
                                matrix[beaverRow, beaverCol + 1] = '-';
                                matrix[beaverRow, 0] = 'B';
                                beaverCol = 0;
                            }
                            else
                            {
                                matrix[beaverRow, beaverCol] = '-';
                                matrix[beaverRow, beaverCol + 1] = '-';
                                matrix[beaverRow, matrix.GetLength(1) - 1] = 'B';
                                beaverCol = matrix.GetLength(0) - 1;
                            }
                        }


                    }
                    else
                    {
                        woodBranches.RemoveAt(woodBranches.Count - 1);
                    }
                }
                else if (cmd == "left")
                {
                    
                    if (beaverCol - 1 >=0)
                    {
                        if (char.IsLower(matrix[beaverRow, beaverCol - 1]))
                        {
                            woodBranches.Add(matrix[beaverRow, beaverCol - 1]);
                            woodBranchCount--;
                            matrix[beaverRow, beaverCol] = '-';
                            matrix[beaverRow, beaverCol - 1] = 'B';
                            beaverCol--;
                        }
                        else if (matrix[beaverRow, beaverCol - 1] == 'F')
                        {
                            if (beaverCol - 1 == 0)
                            {
                                matrix[beaverRow, beaverCol] = '-';
                                matrix[beaverRow, beaverCol - 1] = '-';
                                matrix[beaverRow, matrix.GetLength(1) - 1] = 'B';
                                beaverCol = matrix.GetLength(1) - 1;
                            }
                            else
                            {
                                matrix[beaverRow, beaverCol] = '-';
                                matrix[beaverRow, beaverCol - 1] = '-';
                                matrix[beaverRow, 0] = 'B';
                                beaverCol = 0;
                            }
                        }
                    }
                    else
                    {
                        woodBranches.RemoveAt(woodBranches.Count - 1);
                    }


                   

                }

                cmd = Console.ReadLine();
            }

            if (woodBranchCount>0)
            {
                Console.WriteLine($"The Beaver failed to collect every wood branch. There are {woodBranchCount} branches left.");
            }
            
            
            for (int i = 0; i < n; i++)
            {
                for (int z = 0; z < n; z++)
                {
                    Console.Write(matrix[i,z]+" ",StringSplitOptions.RemoveEmptyEntries);
                }
                Console.WriteLine();
            }
        }
    }
}

