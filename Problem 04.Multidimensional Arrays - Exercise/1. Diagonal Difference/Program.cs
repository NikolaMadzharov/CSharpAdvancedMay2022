using System;
using System.Linq;

namespace _1._Diagonal_Difference
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int size  = int.Parse(Console.ReadLine());
            int[,] matrix = new int[size, size];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int [] numbersInput = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = numbersInput[col];
                }
            }
            int firstDiagonalSum = 0;
            int secondDiagonalSum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                firstDiagonalSum += matrix[i, i];
            }
            for (int i = 0; i <matrix.GetLength(0); i++)
            {
                secondDiagonalSum += matrix[i, matrix.GetLength(1) - 1 - i];
            }
            int result = firstDiagonalSum - secondDiagonalSum;
            Console.WriteLine(Math.Abs(result));

        }
    }
}
