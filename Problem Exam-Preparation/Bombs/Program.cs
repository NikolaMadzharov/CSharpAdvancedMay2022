using System;
using System.Collections.Generic;
using System.Linq;

namespace Bombs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, int> bombs = new SortedDictionary<string, int>
            {
                {"Datura Bombs",0 },
                {"Cherry Bombs",0 },
                {"Smoke Decoy Bombs",0 }
            };
            int daturaBombs = 0;
            int cherryBombs = 0;
            int SmokeDekoyBombs = 0;

            int [] inputQueuev = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int[] stackInput = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            Queue<int> queue =  new Queue<int>(inputQueuev);
            Stack<int> Stack = new Stack<int>(stackInput);
            while (Stack.Count>0&&queue.Count>0)
            {
                int currentQueueValue = queue.Peek();
                int currentStackValue =Stack.Peek();
                int result = currentStackValue + currentQueueValue;
                if (result == 40)
                {
                 
                    bombs["Datura Bombs"]++;
                    Stack.Pop();
                    queue.Dequeue();
                }
                else if (result ==60)
                {
                
                    bombs["Cherry Bombs"]++;
                    Stack.Pop();
                    queue.Dequeue();
                }
                else if (result==120)
                {
                  
                    bombs["Smoke Decoy Bombs"]++;
                    Stack.Pop();
                    queue.Dequeue();
                }
                else
                {
                    Stack.Pop();
                    Stack.Push(currentStackValue - 5);
                }
                if (daturaBombs >= 3 && cherryBombs >= 3 && SmokeDekoyBombs >= 3)
                {
                  
                    break;
                }

            }
            if (daturaBombs>=3&&cherryBombs>=3&&SmokeDekoyBombs>=3)
            {
                Console.WriteLine("Bene! You have successfully filled the bomb pouch!");
            }
            else
            {
                Console.WriteLine("You don't have enough materials to fill the bomb pouch.");
            }
            if (queue.Any())
            {
                Console.WriteLine($"Bomb Effects: {string.Join(", ",queue)}");
            }
            else
            {
                Console.WriteLine("Bomb Effects: empty");
            }
            if (Stack.Any())
            {
                Console.WriteLine($"Bomb Casings: {string.Join(", ",Stack)}");
            }
            else
            {
                Console.WriteLine("Bomb Casings: empty");
            }
            foreach (var bomb in bombs)
            {
                
                    Console.WriteLine($"{bomb.Key}: {bomb.Value}");
                
                
            }

        }

    }
}
