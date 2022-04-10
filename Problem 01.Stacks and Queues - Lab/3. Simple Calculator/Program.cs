using System;
using System.Collections.Generic;
using System.Linq;

namespace SimpleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().Reverse().ToArray();
            Stack<string> stack = new Stack<string>(input);
            while (stack.Count > 1)
            {
                int firstNum = int.Parse(stack.Pop());
                string operation = stack.Pop().ToString();
                int secondNum = int.Parse(stack.Pop());
                if (operation == "+")
                {
                    stack.Push((firstNum + secondNum).ToString());
                }
                else if (operation == "-")
                {
                    stack.Push((firstNum - secondNum).ToString());
                }
            }
            Console.WriteLine(stack.Pop());
        }
    }
}