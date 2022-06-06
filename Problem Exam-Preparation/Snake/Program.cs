using System;

namespace Snake
{
    public class Program
    {
        private static int burrowRow1;
        private static int burrowCow1;

        private static int burrowRow2;
        private static int burrowCow2;

        private static char[,] matrix;

        private static int colectedFood;

        private static int snakeRow;

        private static int snakeCow;

        private static bool GoneOut;
        static void Main(string[] args)
        {
            GoneOut = false; 
            int cuurentBurrowCount = 0;
            int size = int.Parse(Console.ReadLine());
            matrix=  new char[size,size];
            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                char[] input = Console.ReadLine().ToCharArray();
                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    matrix[r, c] = input[c];
                    if (matrix[r,c]=='B')
                    {
                        if (cuurentBurrowCount==0)
                        {
                            burrowRow1 = r;
                            burrowCow1 = c;
                            cuurentBurrowCount++;
                        }
                        else
                        {
                            burrowRow2 = r;
                            burrowCow2 = c;
                        }

                    }
                    if (matrix[r,c]=='S')
                    {
                        snakeRow = r;
                        snakeCow = c;
                    }
                }
            }
            while (GoneOut==false)
            {
                string cmd = Console.ReadLine();
            
                if (cmd == "up")
                {
                    move(-1, 0);
                }
                else if (cmd == "down")
                {
                    move(1, 0);
                }
                else if (cmd == "right")
                {
                    move(0, 1);
                }
                else if (cmd == "left")
                {
                    move(0, -1);
                }
                if (colectedFood >= 10)
                {
                    Console.WriteLine("You won! You fed the snake.");
                    Console.WriteLine($"Food eaten: {colectedFood}");
                    printingMatrix(matrix);
                    GoneOut = true;
                    Environment.Exit(0);
                }
               
               
            }

        }

        public static void printingMatrix(char[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                for (int r = 0; r < matrix.GetLength(0); r++)
                {
                    Console.Write(matrix[i,r]);
                }
                Console.WriteLine();
            }
        }
            

        public static void move(int row, int col)
        {
            matrix[snakeRow, snakeCow] = '.';
            snakeRow += row;
            snakeCow += col;
            if (hasValidCordinates(snakeRow,snakeCow))
            {
                if (matrix[snakeRow,snakeCow]==matrix[burrowRow1,burrowCow1])
                {
                    snakeRow = burrowRow2;
                    snakeCow = burrowCow2;
                    matrix[burrowRow1, burrowCow1] = '.';
                }
                else if (matrix[snakeRow,snakeCow]==matrix[burrowRow2,burrowCow2])
                {
                    snakeRow = burrowRow1;
                    snakeCow=burrowCow1;
                    matrix[burrowRow2, burrowCow2] = '.';
                }
                else if (matrix[snakeRow,snakeCow]=='*')
                {
                    colectedFood++;
                }
            }
          
            else
            {
                Console.WriteLine("Game over!");
                Console.WriteLine($"Food eaten: {colectedFood}");
                printingMatrix(matrix);
                GoneOut=true;
                Environment.Exit(0);
            }
            matrix[snakeRow, snakeCow] = 'S';
            if (colectedFood >= 10)
            {
                Console.WriteLine("You won! You fed the snake.");
                Console.WriteLine($"Food eaten: {colectedFood}");
                printingMatrix(matrix);
                GoneOut = true;
                Environment.Exit(0);
            }
          
           
        }

        static bool hasValidCordinates(int row, int col)
        {
            return row >= 0 && row < matrix.GetLength(0) &&
                  col >= 0 && col < matrix.GetLength(1);
        }

    }


    
}
