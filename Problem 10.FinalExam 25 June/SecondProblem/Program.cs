using System;
using System.Linq;

namespace ExamAdvanced
{

    internal class Program
    {
        static char[,] matrix;
        static int PlayerRow;
        static int PlayerCol;
        static int holeCounter = 1;
        static int hittedRodsCounter = 0;
        static string lastDirection;
        static int totalHoles;

        static void Main(string[] args)
        {

            int size = int.Parse(Console.ReadLine());
            matrix = new char[size, size];

            for (int r = 0; r < size; r++)
            {
                char[] input = Console.ReadLine().ToArray();
                for (int c = 0; c < size; c++)
                {
                    matrix[r, c] = input[c];
                    if (matrix[r, c] == 'V')
                    {
                        PlayerRow = r;
                        PlayerCol = c;
                    }

                }
            }
            string cmd = Console.ReadLine();
            while (cmd != "End")
            {
                lastDirection = cmd;
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
                cmd = Console.ReadLine();
            }


            Console.WriteLine($"Vanko managed to make {holeCounter} hole(s) and he hit only {hittedRodsCounter} rod(s).");
            printingMatrix(matrix);
            



        }

        public static void move(int row, int col)
        {
            if (!hasValidCordinates(PlayerRow + row, PlayerCol + col))
            {
                return;
            }

            matrix[PlayerRow, PlayerCol] = '*';
            holeCounter++;
            PlayerRow += row;
            PlayerCol += col;

            if (lastDirection == "up")
            {

                if (matrix[PlayerRow, PlayerCol] == 'R')
                {
                    Console.WriteLine("Vanko hit a rod!");

                    PlayerRow++;
                    hittedRodsCounter++;
                    holeCounter--;
                }
                else if (matrix[PlayerRow, PlayerCol] == 'C')
                {
                    matrix[PlayerRow, PlayerCol] = 'E';
                    Console.WriteLine($"Vanko got electrocuted, but he managed to make {holeCounter} hole(s).");
                    printingMatrix(matrix);
                    holeCounter += 1;
                    Environment.Exit(0);


                }
                else if (matrix[PlayerRow, PlayerCol] == '*')
                {
                    
                    holeCounter--;
                }


            }
            else if (lastDirection == "down")
            {

                if (matrix[PlayerRow, PlayerCol] == 'R')
                {

                    Console.WriteLine("Vanko hit a rod!");
                    PlayerRow--;
                    hittedRodsCounter++;
                    holeCounter--;
                }
                else if (matrix[PlayerRow, PlayerCol] == 'C')
                {
                    matrix[PlayerRow, PlayerCol] = 'E';
                    Console.WriteLine($"Vanko got electrocuted, but he managed to make {holeCounter} hole(s).");
                    printingMatrix(matrix);
                    holeCounter += 1;
                    Environment.Exit(0);
                }
                else if (matrix[PlayerRow, PlayerCol] == '*')
                {
                    Console.WriteLine($"The wall is already destroyed at position [{PlayerRow}, {PlayerCol}]!");
                    holeCounter--;
                }

            }
            else if (lastDirection == "right")
            {

                if (matrix[PlayerRow, PlayerCol] == 'R')
                {
                    Console.WriteLine("Vanko hit a rod!");
                    PlayerCol--;
                    hittedRodsCounter++;
                    holeCounter--;
                }
                else if (matrix[PlayerRow, PlayerCol] == 'C')
                {
                    matrix[PlayerRow, PlayerCol] = 'E';
                    Console.WriteLine($"Vanko got electrocuted, but he managed to make {holeCounter} hole(s).");
                    printingMatrix(matrix);
                    holeCounter += 1;
                    Environment.Exit(0);
                }
                else if (matrix[PlayerRow, PlayerCol] == '*')
                {
                    Console.WriteLine($"The wall is already destroyed at position [{PlayerRow}, {PlayerCol}]!");
                    
                }

            }
            else if (lastDirection == "left")
            {

                if (matrix[PlayerRow, PlayerCol] == 'R')
                {
                    Console.WriteLine("Vanko hit a rod!");
                    PlayerCol++;
                    hittedRodsCounter++;

                    holeCounter--;

                }
                else if (matrix[PlayerRow, PlayerCol] == 'C')
                {
                    matrix[PlayerRow, PlayerCol] = 'E';
                    Console.WriteLine($"Vanko got electrocuted, but he managed to make {holeCounter} hole(s).");
                    printingMatrix(matrix);
                    holeCounter += 1 ;
                    Environment.Exit(0);
                }
                else if (matrix[PlayerRow, PlayerCol] == '*')
                {
                    Console.WriteLine($"The wall is already destroyed at position[ {PlayerRow}, {PlayerCol}]!");
                    holeCounter--;
                }

            }


            matrix[PlayerRow, PlayerCol] = 'V';





        }



        static bool hasValidCordinates(int row, int col)
        {
            return row >= 0 && row < matrix.GetLength(0) &&
                  col >= 0 && col < matrix.GetLength(1);
        }
        public static void printingMatrix(char[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int z = 0; z < matrix.GetLength(1); z++)
                {
                    Console.Write(matrix[i, z]);
                }
                Console.WriteLine();
            }
        }
       
    }
}
