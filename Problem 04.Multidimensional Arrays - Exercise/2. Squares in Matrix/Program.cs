using System;
using System.Linq;

namespace _2._Squares_in_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int [] size = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int rows = size[0];
            int cols = size[1];
            string [,] matrix= new string [rows, cols];
            for (int row = 0; row < rows; row++)
            {
                string [] input = Console.ReadLine().Split(' ');
                for (int col = 0; col < cols; col++)
                {
                    matrix[row,col]=input[col];
                }
            }
            int counter = 0;
            for (int row = 0; row < rows; row++)
            {
               
                for (int col = 0; col < cols; col++)
                {
                    if (row + 1 < rows && col + 1 < cols)
                    {
                        string symbol1 = matrix[row,col];
                        string symbol2 = matrix[row,col+1];
                        string symbol3 = matrix[row+1,col];
                        string symbol4 = matrix[row+1,col+1];
                        if (symbol1==symbol2&& symbol3==symbol4)
                        {
                            counter++;
                        }
                    }
                    
                }
            }
            Console.WriteLine(counter);

        }
    }
}
