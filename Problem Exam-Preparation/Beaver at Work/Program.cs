using System;
using System.Collections.Generic;

namespace TruffleHunter
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            int n=int.Parse(Console.ReadLine());
            string[,] matrix = new string[n,n];
            Dictionary<string, int> collectionTruffles = new Dictionary<string, int>
            {
                {"B", 0 },
                {"S", 0 },
                {"W", 0 },
                
            };
           


            int wildBoarEatenTruffles = 0;

                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                string [] fillMatrix = Console.ReadLine().Split(' ');
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        matrix[row,col] = fillMatrix[col];
                        

                    }
                }
            string cmd = Console.ReadLine();
            
            while (cmd!= "Stop the hunt")
            {
                string[] input = cmd.Split();
                string action = input[0];
                int row = int.Parse(input[1]);
                int col = int.Parse(input[2]);

                if (action=="Collect")
                {
                    
                    if (matrix[row,col]=="B")
                    {
                        collectionTruffles["B"]++;
                        matrix[row, col] = "-";
                    }
                    else if (matrix[row, col] == "S")
                    {
                        collectionTruffles["S"]++;
                        matrix[row, col] = "-";
                    }
                    else if (matrix[row,col]=="W")
                    {
                        collectionTruffles["W"]++;
                        matrix[row, col] = "-";
                    }
                }
                else if (action== "Wild_Boar")
                {
                    
                    string direction = input[3];
                    int wildBoarRow = 0;
                    int wildBoarCol = 0;
                    matrix[row, col] = "WB";
                    wildBoarRow = row;
                    wildBoarCol = col;
                    if (direction=="up")
                    {

                        if (matrix[wildBoarRow,wildBoarCol]!="-")
                        {
                            while (wildBoarRow>=0)
                            {
                                for (int rows = wildBoarRow; rows >=0; rows++)
                                {
                                  
                                }
                            }
                        }
                        
                    }
                   
                    
                    
                }


                cmd = Console.ReadLine();
            }
            
           


        }
    }
}
