using System;
using System.Collections.Generic;
using System.Linq;

namespace Warm_Winter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int [] inputHats = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int[] inputScarfs = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            Stack<int> hats = new Stack<int>(inputHats);
            Queue<int> scarfs = new Queue<int>(inputScarfs);
            List<int> set = new List<int>();

            while (hats.Count>0 && scarfs.Count>0)
            {
                int hat = hats.Peek();
                int scarf = scarfs.Peek();
                if (hat>scarf)
                {
                    set.Add(hat+scarf);
                    hats.Pop();
                    scarfs.Dequeue();
                }
                else if (scarf>hat)
                {
                    hats.Pop();
                }
                else
                {
                    scarfs.Dequeue();
                    int increaseValue = hats.Pop()+1;
                    hats.Push(increaseValue);
                }
               
            }
            Console.WriteLine($"The most expensive set is: {set.Max()}");
            Console.WriteLine(String.Join(" ",set));

        }
    }
}
