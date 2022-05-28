using System;
using System.Collections.Generic;
using System.Linq;

namespace Lootbox
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] input2 = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> queue = new Queue<int>(input1);

            Stack<int> stack = new Stack<int>(input2);

            int value = 0;
            while (queue.Count > 0 && stack.Count > 0)
            {
                int currentQueueValue = queue.Peek();
                int currentStackValue = stack.Peek();
                int result = currentStackValue + currentQueueValue;
                if (result % 2 == 0)
                {
                    queue.Dequeue();
                    stack.Pop();
                    value += currentQueueValue + currentStackValue;
                }
                else
                {
                    stack.Pop();
                    queue.Enqueue(currentStackValue);
                }
                if (queue.Count == 0)
                {
                    Console.WriteLine("First lootbox is empty");
                }
                if (stack.Count == 0)
                {
                    Console.WriteLine("Second lootbox is empty");
                }
            }
            if (value >= 100)
            {
                Console.WriteLine($"Your loot was epic! Value: { value}");
            }
            else
            {
                Console.WriteLine($"Your loot was poor... Value: {value}");
            }

           



        }
    }
}
