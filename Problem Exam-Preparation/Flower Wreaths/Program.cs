using System;
using System.Collections.Generic;
using System.Linq;

namespace Flowers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int [] inputStack = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int[] inputQueue = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>(inputStack);
            Queue<int> queue = new Queue<int>(inputQueue);
            int sumUnder15 = 0;
            int wreathsCreated = 0;

            while (queue.Any()&& stack.Any())
            {
                int currentStackValue = stack.Peek();
                int currentQueueValue = queue.Peek();
                int result = currentStackValue + currentQueueValue;
                if (result ==15)
                {
                    queue.Dequeue();
                    stack.Pop();
                    wreathsCreated++;
                }
                else if (result >=15)
                {
                    stack.Pop();
                    stack.Push(currentStackValue - 2);
                }
                else
                {
                    sumUnder15 += currentStackValue + currentQueueValue;
                    queue.Dequeue();
                    stack.Pop();
                }
                if (sumUnder15==15)
                {
                    wreathsCreated++;
                   
                }
               
              
            }
           
            
                while (sumUnder15>=15)
                {
                    sumUnder15 -= 15;
                    wreathsCreated++;
                

                }
           
            if (wreathsCreated>=5)
            {
                Console.WriteLine($"You made it, you are going to the competition with {wreathsCreated} wreaths!");
            }
            else
            {
                int needed =Math.Abs(wreathsCreated-5);
                Console.WriteLine($"You didn't make it, you need {needed} wreaths more!");
            }
        }
    }
}
