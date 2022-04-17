using System;
using System.Linq;

namespace _6._Jagged_Array_Modification
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            
           int [][]jaggedArray = new int[rows][];

            for (int row = 0; row < jaggedArray.GetLength(0); row++)
            {
                int [] cols = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                jaggedArray[row] = new int[cols.Length];
                for (int col = 0; col < cols.Length; col++)
                {
                    jaggedArray[row][col] = cols[col];
                }
            }
            string input = String.Empty;
            while ((input=Console.ReadLine())!="END")
            {
                string[] command = input.Split(" ");
                string action = command[0];
                int row = int.Parse(command[1]);
                int column = int.Parse(command[2]);
                int value = int.Parse(command[3]);
                if(row<0 ||row>= jaggedArray.Length || column<0 ||column>= jaggedArray[row].Length)
                {
                    Console.WriteLine("Invalid coordinates");
                    continue;
                }
                if (action=="Add")
                {
                    
                        jaggedArray[row][column] += value;
                }
                else if (action=="Subtract")
                {
                        jaggedArray[row][column] -= value;
                }

            }


            for (int row = 0; row < jaggedArray.GetLength(0); row++)
            {
                for (int col = 0; col < jaggedArray[row].Length; col++)
                {
                    Console.Write(jaggedArray[row][col]+" ");
                }
                Console.WriteLine();
            }
             
         
          
             
        }
    }
}
