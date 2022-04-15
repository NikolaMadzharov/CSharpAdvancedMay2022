using System;

namespace _4._Symbol_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            int cols = rows;

            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                string symbols = Console.ReadLine();
                for (int col = 0; col < cols; col++)
                {
                    char currentSymbol = symbols[col];
                    matrix[row, col] = currentSymbol;
                }
            }

            bool isFound = false;

            char symbol = char.Parse(Console.ReadLine());
            int symbolInInteger = symbol;

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if (matrix[row, col] == symbol)
                    {
                        Console.WriteLine($"({row}, {col})");
                        isFound = true;
                        return;
                    }
                }
            }

            if (isFound == false)
            {
                Console.WriteLine($"{symbol} does not occur in the matrix");
            }
        }
    }
}