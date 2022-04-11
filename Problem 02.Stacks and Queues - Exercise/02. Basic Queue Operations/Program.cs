using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Basic_Queue_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] elements = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Queue<int> queue = new Queue<int>();

            int push = input[0];
            int pop = input[1];
            int specialElement = input[2];
            for (int i = 0; i < push; i++)
            {
                queue.Enqueue(elements[i]);
            }
            for (int i = 0; i < pop; i++)
            {
                queue.Dequeue();
            }
            if (queue.Contains(specialElement))
            {
                Console.WriteLine("true");
            }
            else if (queue.Count > 0)
            {
                Console.WriteLine(queue.Min());
            }
            else
            {
                Console.WriteLine('0');
            }

        }
    }
}
