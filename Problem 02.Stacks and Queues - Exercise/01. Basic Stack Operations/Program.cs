using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Basic_Stack_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int [] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[]elements = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Stack<int> stack=new Stack<int>();

            int push = input[0];
            int pop = input[1];
            int specialElement = input[2];
            for (int i = 0; i < push; i++)
            {
                stack.Push(elements[i]);
            }
            for (int i = 0; i < pop; i++)
            {
                stack.Pop();
            }
            if (stack.Contains(specialElement))
            {
                Console.WriteLine("true");
            }
            else if (stack.Count>0)
            {
                Console.WriteLine(stack.Min());
            }
            else
            {
                Console.WriteLine('0');
            }
        }
    }
}
