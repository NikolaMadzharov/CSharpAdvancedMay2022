using System;
using System.Collections.Generic;

namespace _6._Supermarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Queue<string> queue = new Queue<string>();
            int count = 0;
            while (input != "End")
            {

                if (input == "Paid")
                {
                    while (queue.Count > 0)
                    {
                        string name = queue.Dequeue();
                        Console.WriteLine(name);
                    }
                }
                else
                {
                    queue.Enqueue(input);
                }
                input = Console.ReadLine();
            }
            int remaining = queue.Count;
            Console.WriteLine($"{remaining} people remaining.");
        }
    }
}
