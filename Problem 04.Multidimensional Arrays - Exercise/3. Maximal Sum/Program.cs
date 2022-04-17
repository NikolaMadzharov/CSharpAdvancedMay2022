using System;
using System.Linq;

namespace _3._Maximal_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int [] size = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int rows = size[0];
            int cols = size[1];
            int [,] matrix = new int[rows, cols];
            for (int row = 0; row < rows; row++)
            {
                int [] inputNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = inputNumbers[col];
                }
            }
            int maxSum = int.MinValue;
            int maxrow = -10;
            int maxcol = -10; 
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if (row +2<rows && col+2<cols)
                    {
                        int sum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] + matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] + matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                        if (sum > maxSum)
                        {
                            maxSum = sum;
                            maxrow = row;
                            maxcol = col;
                        }
                    }
                }
            }
            for (int row = maxrow; row <= maxrow+3; row++)
            {
                for (int col = maxcol; col < maxcol+3; col++)
                {
                    Console.Write(matrix[row,col]+" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine(maxSum);
        }
    }
}
