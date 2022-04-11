using System;
using System.Collections.Generic;

namespace _06._Songs_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
             string [] songs = Console.ReadLine().Split(", ",StringSplitOptions.RemoveEmptyEntries);
            Queue<string> songQueue = new Queue<string>(songs);
            while (songQueue.Count>0)
            {
                
                string command = Console.ReadLine();
                if (command=="Play")
                {
                    
                    
                        songQueue.Dequeue();
                    
                   
                    

                }
                else if (command.StartsWith("Add"))
                {
                    string songFullname = command.Substring(4);
                    
                    
                    if(songQueue.Contains(songFullname))
                    {
                        Console.WriteLine($"{songFullname} is already contained!");
                    }
                    else  
                    {
                        songQueue.Enqueue(songFullname);
                    }
                }
                else if (command=="Show")
                {
                     Console.WriteLine("{0}", string.Join(", ",songQueue));
                }
            }
            Console.WriteLine("No more songs!");

        }
    }
}
