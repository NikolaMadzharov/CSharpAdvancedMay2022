using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Fashion_Boutique
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] clothes = Console.ReadLine()
               .Split(" ", StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToArray();
            Stack<int> stack = new Stack<int>(clothes);
            int capacity = int.Parse(Console.ReadLine());
            int sum = 0;
            int numberRacks = 1;

            while (stack.Count > 0)
            {
                sum += stack.Peek();
                if (sum <= capacity)
                {
                    stack.Pop();
                }
                else
                {
                    numberRacks++;
                    sum = 0;
                }

            }
            Console.WriteLine(numberRacks);
        }
    }
}
