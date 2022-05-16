using System;

namespace _02.Super_Mario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int marioLives = int.Parse(Console.ReadLine());
            int rowCols = int.Parse(Console.ReadLine());
            string[,] maze =  new string[rowCols,rowCols];
            for (int row = 0; row < maze.GetLength(0); row++)
            {
                string input = Console.ReadLine();
               
                for (int col = 0; col < maze.GetLength(1); col++)
                {
                    maze[row,col] = input[col].ToString();
                }
            }
            int marioRow = -1;
            int marioCol = -1;
            for (int row = 0; row < rowCols; row++)
            {
                for (int col = 0; col < rowCols; col++)
                {
                    if (maze[row,col]=="M")
                    {
                        marioRow = row;
                        marioCol = col;
                       
                    }
                }
            }
            while (true)
            {

                string[] input = Console.ReadLine().Split();
                string move = input[0];
                int rowToMove = int.Parse(input[1]);
                int colToMove = int.Parse(input[2]);
                
                
                maze[rowToMove,colToMove] = "B";
                if (move=="W")
                {
                    if (marioRow>0)
                    {
                        maze[marioRow, marioCol] = "-";
                      
                        marioRow--;
                    }

                   

                }
                else if (move=="S")
                {
                    if (marioRow<rowCols-1)
                    {
                        maze[marioRow, marioCol] = "-";
                       
                        marioRow++;
                    }
                }
                else if(move=="A")
                {
                    if (marioCol>0)
                    {
                        maze[marioRow, marioCol] = "-";
                        
                        marioCol--; 
                    }
                }
                else if(move == "D")
                {
                    if (marioCol<rowCols-1)
                    {
                        maze[marioRow, marioCol] = "-";
                      
                        marioCol++;
                    }
                }
                marioLives--;
                if (maze[marioRow, marioCol] == "P")
                {
                    maze[marioRow, marioCol] = "-";
                    Console.WriteLine($"Mario has successfully saved the princess! Lives left: {marioLives}");
                    
                    break;
                   
                }
                
                if (marioLives <= 0)
                {
                    maze[marioRow, marioCol] = "X";
                    Console.WriteLine($"Mario died at {marioRow};{marioCol}.");
                    
                    break;
                }
                if (maze[marioRow,marioCol]=="B")
                {
                    if (marioLives>2)
                    {
                        marioLives -= 2;
                    }
                    else
                    {
                        maze[marioRow, marioCol] = "X";
                        Console.WriteLine($"Mario died at {marioRow};{marioCol}.");
                       
                        break;
                    }
                   
                }

                maze[marioRow, marioCol] = "M";
               

            }
            for (int i = 0; i < rowCols; i++)
            {
                for (int j = 0; j < rowCols; j++)
                {
                    Console.Write(maze[i, j]);
                }
                Console.WriteLine();
            }



        }
    }
}
