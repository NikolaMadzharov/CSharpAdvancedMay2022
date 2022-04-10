using System;
using System.Collections.Generic;

namespace _7._Hot_Potato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] kids = Console.ReadLine().Split();
            Queue<string> queue = new Queue<string>(kids);
            int tossesLimit = int.Parse(Console.ReadLine());
            int currentTosses = 1;
            while (queue.Count > 1)
            {
                string currentKid = queue.Dequeue();
                if (tossesLimit != currentTosses)
                {
                    queue.Enqueue(currentKid);
                    currentTosses++;
                }
                else
                {
                    Console.WriteLine($"Removed {currentKid}");
                    currentTosses = 1;

                }

            }
            Console.WriteLine($"Last is {queue.Dequeue()}");
        }
    }
}