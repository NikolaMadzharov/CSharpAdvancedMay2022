using System;
using System.Linq;

namespace _5._Square_With_Maximum_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
         int [] input = Console.ReadLine().Split(", ",StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            int rows = input[0];
            int cols = input[1];
            int[,] matrix = new int[rows, cols];    
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] inputInLoop = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = inputInLoop[col];
                }
            }
            int maxSum = int.MinValue;
            int maxRow = 0;
            int maxCol = 0;
           

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                
                for (int col = 0; col <matrix.GetLength(1); col++)
                {
                    if (row+1<rows && col+1<cols)
                    {
                        int sum = matrix[row, col]+ matrix[row,+col+1]+ matrix[row +1,col] + matrix[row+1,col+1];
 
                        if (sum > maxSum)
                        {
                            maxSum = sum;
                            maxRow = row;
                            maxCol = col;
                            
                        }
                    }
                  
                }
            }
          
            for (int row = maxRow; row <= maxRow+1; row++)
            {
                for (int col = maxCol; col <= maxCol+1; col++)
                {
                    Console.Write(matrix[row,col]+" " );
                    
                }
                Console.WriteLine();
            }
            
            Console.WriteLine(maxSum);
        }

                
           
        
    }
}
