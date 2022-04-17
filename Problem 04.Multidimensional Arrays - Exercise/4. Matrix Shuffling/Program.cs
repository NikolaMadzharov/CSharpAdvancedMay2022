using System;
using System.Linq;

namespace _4._Matrix_Shuffling
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int[] size = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int rows = size[0];
            int cols = size[1]; 
            string[,] matrix = new string[rows, cols];
            for (int row = 0; row < rows; row++)
            {
                string[] inputNumbers = Console.ReadLine().Split();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = inputNumbers[col];
                }
            }
            string input = Console.ReadLine();
            while (input!="END")
            {
                bool flag = true;
                string[] commands = input.Split(' ');
                string action = commands[0];

               
                if (action=="swap" && commands.Length==5)
                {
                    int row1 = int.Parse(commands[1]);
                    int row2 = int.Parse(commands[2]);
                    int col1 = int.Parse(commands[3]);
                    int col2 = int.Parse(commands[4]);


                    if (row1 >= rows || row2 >= rows || row1 < 0 || row2 < 0 || col1 >= cols || col2 >= cols || col1 < 0 || col2 < 0)
                    {
                        flag = false;

                    }
                    else
                    {
                        string temp = matrix[row1, col1];
                        matrix[row1, col1] = matrix[row2, col2];
                        matrix[row2, col2] = temp;

                    }
                }
                else
                {
                    flag=false;
                }
                if (!flag)
                {
                    Console.WriteLine("Invalid input!");
                }
                else
                {

                    for (int col = 0; col <cols; col++)
                    {
                        for (int row = 0; row <rows; row++)
                        {
                            Console.Write(matrix[row,col]+" ");
                        }
                        
                    }
                    

                }
                input = Console.ReadLine();
            }
           
        }

       
    }
}
