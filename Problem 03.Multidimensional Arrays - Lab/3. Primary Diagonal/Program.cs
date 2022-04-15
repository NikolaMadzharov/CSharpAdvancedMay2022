using System;
using System.Linq;

namespace _3._Primary_Diagonal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int[,] matrixx = new int [input, input];
            for (int row = 0; row < matrixx.GetLength(0); row++)
            {
                int [] inputInLoop = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                for (int col = 0; col < input; col++)
                {
                    matrixx[row, col] = inputInLoop[col];
                }
            }
            int sum = 0;
            for (int i = 0; i <matrixx.GetLength(0); i++)
            {
                sum += matrixx[i, i];
            }
            Console.WriteLine(sum);
                
        }
       
    }
}
