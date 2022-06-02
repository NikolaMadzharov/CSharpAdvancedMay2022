using System;

namespace Armory
{
    internal class Program
    {
        private static char[,] matrix;
        private static int firstMirrorRow;
        private static int firstMirrorCol;

        private static int secondMirrorRow;
        private static int secondtMirrorCol;

        private static int collectMoney;

        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            matrix =  new char[size,size];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                
                char[] input = Console.ReadLine().ToCharArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row,col] = input[col];
                    if (matrix[row,col]=='M')
                    {
                        
                    }
                }
            }
        }
    }
}
