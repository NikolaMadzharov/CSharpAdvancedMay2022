

using System;

namespace _02._Armory
{
    internal class Program
    {
        private static int totalCoins;
        private static int firstMirrorRow;
        private static int firstMirrorCol;

        private static int secondMirrorRow;
        private static int secondMirrowCol;

        private static int officerRow;
        private static int officerCol;

        private static char[,] matrix;
        private static int mirrorsCount;
        static void Main(string[] args)
        {
             
          
            

            int n = int.Parse(Console.ReadLine());

            matrix = new char[n, n];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] input =Console.ReadLine().ToCharArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];

                    if (matrix[row, col] == 'M')
                    {
                        if (mirrorsCount == 0)
                        {
                            firstMirrorRow = row;
                            firstMirrorCol = col;
                            mirrorsCount++;
                        }

                        secondMirrorRow = row;
                        secondMirrowCol = col;
                    }

                    if (matrix[row, col] == 'A')
                    {
                        officerRow = row;
                        officerCol = col;
                    }
                }
            }

            while (true)
            {
                string cmd  =  Console.ReadLine();

               
                if (cmd == "up")
                {

                    Movement(-1, 0);

                }
                else if (cmd == "down")
                {
                    Movement(1, 0);
                }
                else if (cmd=="right")
                {
                    Movement(0, 1);

                }
                else if (cmd=="left")
                {
                   Movement(0,-1); 
                }
                
                  else if (!isInMatrix(officerRow,officerCol))
            {
                Console.WriteLine("I do not need more swords!");
                Console.WriteLine($"The king paid {totalCoins} gold coins.");
                pringingMatrix(matrix);
                Environment.Exit(0);
            }
           
           
            matrix[officerRow, officerCol] = 'A';
            if (totalCoins>=65)
            {
                Console.WriteLine("Very nice swords, I will come back for more!");
                Console.WriteLine($"The king paid {totalCoins} gold coins.");
                pringingMatrix(matrix);
                Environment.Exit(0);
            }

            }

        }
       
        public static void Movement(int row, int col)
        
        {
            matrix[officerRow, officerCol] = '-';
            officerRow += row;
            officerCol += col;
            if (isInMatrix(officerRow,officerCol))
            {
                if (char.IsDigit(matrix[officerRow,officerCol]))
                {
                    totalCoins += int.Parse(matrix[officerRow, officerCol].ToString());
                    

                }
                else if (mirrorsCount>0)
                {
                     if (matrix[officerRow, officerCol] == matrix[firstMirrorRow, firstMirrorCol])
                    {
                        officerRow = secondMirrorRow;
                        officerCol = secondMirrowCol;
                        matrix[firstMirrorCol, firstMirrorCol] = '-';
                    }
                    else if (matrix[officerRow, officerCol] == matrix[secondMirrorRow, secondMirrowCol])
                    {
                        officerRow = firstMirrorRow;
                        officerCol = firstMirrorCol;
                        matrix[secondMirrorRow, secondMirrowCol] = '-';
                    }

                }
               
               

            }
            else if (!isInMatrix(officerRow,officerCol))
            {
                Console.WriteLine("I do not need more swords!");
                Console.WriteLine($"The king paid {totalCoins} gold coins.");
                pringingMatrix(matrix);
                Environment.Exit(0);
            }
           
           
            matrix[officerRow, officerCol] = 'A';
            if (totalCoins>=65)
            {
                Console.WriteLine("Very nice swords, I will come back for more!");
                Console.WriteLine($"The king paid {totalCoins} gold coins.");
                pringingMatrix(matrix);
                Environment.Exit(0);
            }
            

        }
        public static bool isInMatrix(int row ,int col)
        {
            return row>=0 && row<= matrix.GetLength(0)&& col>=0 && col<= matrix.GetLength(1);
        }

        public static void pringingMatrix(char[,] matrix)
        {
            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    Console.Write(matrix[r,c]);
                }
                Console.WriteLine();
            }
        }



    }
}

