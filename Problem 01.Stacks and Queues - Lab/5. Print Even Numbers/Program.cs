using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Print_Even_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Queue<int> queue = new Queue<int>(input);
            for (int i = 0; i < input.Length; i++)
            {
                int currentElement = queue.Dequeue();
                if (currentElement % 2 == 0)
                {
                    queue.Enqueue(currentElement);
                }
            }
            Console.Write(String.Join(", ", queue));






        }
    }
}

