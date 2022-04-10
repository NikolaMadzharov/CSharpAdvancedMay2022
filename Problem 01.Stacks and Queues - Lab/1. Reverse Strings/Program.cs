using System;
using System.Collections.Generic;

namespace _1._Reverse_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> stack = new Stack<char>();
            foreach (var charElement in input)
            {
                stack.Push(charElement);
            }
            while (stack.Count > 0)
            {
                Console.Write(stack.Pop());

            }

        }
    }
}

