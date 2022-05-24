using System;
using System.Collections.Generic;
using System.Linq;

namespace beaverAtWork
{
    internal class Program
    {
        private static int beaverRow;
        private static int beaverCol;
        private static char[,] matrix;
        private static string lastDirection;

        private static List<char> branches = new List<char>();
        private static int totalBranches = 0;
        static void Main(string[] args)
        {
         int n = int.Parse(Console.ReadLine());
            matrix =  new char[n,n];
            
            beaverRow = 0;
            beaverCol = 0;  

            for (int i = 0; i < n; i++)
            {
                char [] input = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
                for (int j = 0; j < n; j++)
                {
                    matrix[i,j] = input[j];
                    if (matrix[i,j]=='B')
                    {
                        beaverRow = i;
                        beaverCol = j;
                    }
                    if (char.IsLower(matrix[i,j]))
                    {
                        totalBranches++;
                    }
                }
            }
            string cmd = Console.ReadLine();
           
            while (cmd!="end")
            {
                lastDirection =cmd;
                if (cmd=="up")
                {
                    move(-1, 0);
                }
                else if (cmd=="down")
                {
                    move(1,0);
                }
                else if (cmd=="right")
                {
                    move(0, 1);
                }
                else if (cmd=="left")
                {
                    move(0, -1);
                }
                if (totalBranches.Equals(0))
                {
                    Console.WriteLine($"The Beaver successfully collect {branches.Count} wood branches: {string.Join(", ", branches)}.");
                    printingMatrix(matrix);
                    Environment.Exit(0);
                }
                cmd = Console.ReadLine();
            }
            Console.WriteLine($"The Beaver failed to collect every wood branch. There are {totalBranches} branches left.");
            printingMatrix(matrix);
            
           

        }

        private static void printingMatrix(char[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int z = 0; z < matrix.GetLength(1); z++)
                {
                    Console.Write(matrix[i,z]+" ",StringSplitOptions.RemoveEmptyEntries);
                }
                Console.WriteLine();
            }
        }

        static void move(int row,int col)
        {
            if (!hasValidCordinates(beaverRow+row,beaverCol+col))
            {
                if (branches.Any())
                {
                    branches.RemoveAt(branches.Count-1);
                    
                    return;
                }
            }
            matrix[beaverRow, beaverCol] = '-';
            
            
            beaverRow += row;
            beaverCol+=col;
            if (char.IsLower(matrix[beaverRow,beaverCol]))
            {
                branches.Add(matrix[beaverRow, beaverCol]);
                totalBranches--;
                matrix[beaverRow, beaverCol] = 'B';
            }
            else if (matrix[beaverRow,beaverCol]=='F')
            {
                matrix[beaverRow, beaverCol] = '-';
                if (lastDirection=="up")
                {
                    if (beaverRow==0)
                    {
                        if (char.IsLower(matrix[matrix.GetLength(0)-1,beaverCol]))
                        {
                            branches.Add(matrix[matrix.GetLength(0)-1,beaverCol]);
                            totalBranches--;
                        }
                        beaverRow = matrix.GetLength(0)-1;
                        matrix[beaverRow, beaverCol] = 'B';
                    }
                    else
                    {
                        if (char.IsLower(matrix[0, beaverCol]))
                        {
                            branches.Add(matrix[0, beaverCol]);
                            totalBranches--;
                        }
                        beaverRow = 0;
                        matrix[beaverRow, beaverCol] = 'B';
                    }
                }
                else if (lastDirection=="down")
                {

                    if (beaverRow == matrix.GetLength(0)-1)
                    {
                        if (char.IsLower(matrix[0, beaverCol]))
                        {
                            branches.Add(matrix[0, beaverCol]);
                            totalBranches--;
                        }
                        beaverRow = 0;
                        matrix[beaverRow, beaverCol] = 'B';
                    }
                    else
                    {
                        if (char.IsLower(matrix[matrix.GetLength(0)-1, beaverCol]))
                        {
                            branches.Add(matrix[matrix.GetLength(0)-1, beaverCol]);
                            totalBranches--;
                        }
                        beaverRow = matrix.GetLength(0)-1;
                        matrix[beaverRow, beaverCol] = 'B';
                    }
                }
                else if (lastDirection=="right")
                {
                    if (beaverCol==matrix.GetLength(1)-1)
                    {
                        if (char.IsLower(matrix[beaverRow,0]))
                        {
                            branches.Add(matrix[beaverRow, 0]);
                            totalBranches--;
                        }
                        beaverCol = 0;
                        matrix[beaverRow, beaverCol] = 'B';
                        
                    }
                    else
                    {
                        if (char.IsLower(matrix[beaverRow,matrix.GetLength(1)-1]))
                        {
                            branches.Add(matrix[beaverRow, matrix.GetLength(1) - 1]);
                            totalBranches--;
                        }
                        beaverCol=matrix.GetLength(1)-1;
                        matrix[beaverRow, beaverCol] = 'B';
                    }
                }
                else if (lastDirection=="left")
                {
                    if (beaverCol==0)
                    {
                        if (char.IsLower(matrix[beaverRow,matrix.GetLength(1)-1]))
                        {
                            branches.Add(matrix[beaverRow, matrix.GetLength(1) - 1]);
                            totalBranches--;
                        }
                        beaverCol=-matrix.GetLength(1)-1;
                        matrix[beaverRow, beaverCol] = 'B';
                       
                    }
                    else
                    {
                        if (char.IsLower(matrix[beaverRow, 0]))
                        {
                            branches.Add(matrix[beaverRow, 0]);
                            totalBranches--;
                        }
                        beaverCol = 0;
                        matrix[beaverRow, beaverCol] = 'B';
                    }


                }
               
            }
            else
            {
                matrix[beaverRow, beaverCol] = 'B';
            }
        }
        static bool hasValidCordinates(int row,int col)
        {
            return row >= 0 && row < matrix.GetLength(0) &&
                  col >= 0 && col < matrix.GetLength(1);
        }
    }
}
