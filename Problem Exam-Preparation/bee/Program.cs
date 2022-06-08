using System;

namespace Bee
{
    internal class Program
    {
         private static int beeRow;
        private static int beeCol;
        private static char[,] matrix;
        private static int eatenFlowers;
        private static string lastDirection;
      
        

        static void Main(string[] args)
        {
           int size = int.Parse(Console.ReadLine());
            matrix = new char [size, size];
            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                char[] input = Console.ReadLine().ToCharArray();
                for (int c = 0; c < input.Length; c++)
                {
                    matrix[r, c] = input[c];
                    if (matrix[r,c]=='B')
                    {
                        beeRow = r;
                        beeCol = c;
                    }
                }
            }
            while (true)
            {
               string cmd = Console.ReadLine();
                lastDirection = cmd;
                if (cmd =="up")
                {
                    move(-1, 0);
                }
                else if (cmd =="down")
                {
                    move(1, 0);
                }
                else if (cmd=="right")
                {
                    move(0, 1);
                }
                else if (cmd=="left")
                {
                    move(-1, 0);
                }

            }
        }
        public static void printingaMatrix(char[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int r = 0; r < matrix.GetLength(1); r++)
                {
                    Console.Write(matrix[i,r]);
                }
                Console.WriteLine();
            }
        }
        


        private static void move(int row, int col)
        {
            matrix[beeRow, beeCol] = '.';
            beeRow += row;
            beeCol += col;
            if (isInMatrix(beeRow,beeCol))
            {
                if (matrix[beeRow,beeCol]=='f')
                {
                    eatenFlowers++;
                }
                else if (matrix[beeRow,beeCol]=='O')
                {
                    matrix[beeRow, beeCol] = '.';
                    if (lastDirection=="up")
                    {
                        beeCol -= 1;
                    }
                    else if (lastDirection=="down")
                    {
                        beeRow += 1;
                    }
                    else if (lastDirection=="right")
                    {
                        beeCol += 1;
                    }
                    else if (lastDirection=="left")
                    {
                        beeCol -= 1;
                    }
                    if (matrix[beeRow, beeCol] == 'f')
                    {
                        eatenFlowers++;
                    }
                }
            }
            else
            {
                Console.WriteLine("The bee got lost!");
                if (eatenFlowers<5)
                {
                    Console.WriteLine($"The bee couldn't pollinate the flowers, she needed {Math.Abs(eatenFlowers-5) } flowers more");
                }
                else
                {
                    Console.WriteLine($"Great job, the bee managed to pollinate {eatenFlowers} flowers!");
                }
                printingaMatrix(matrix);
                
               
            }
            matrix[beeRow,beeCol] = 'B';
            if (eatenFlowers>=5)
            {
                Console.WriteLine($"Great job, the bee managed to pollinate {eatenFlowers} flowers!");
                printingaMatrix(matrix);
                
               
            }
        }
        private static bool isInMatrix(int row,int col)
        {
            return row>=0 && row<matrix.GetLength(0) && col>=0 && col<matrix.GetLength(1);
        }

    }
}
