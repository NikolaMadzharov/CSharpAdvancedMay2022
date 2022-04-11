using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Balanced_Parenthesis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> stack = new Stack<char>();
            bool isValid = true;
            foreach (var item in input)
            {
                if (item=='{' || item=='['||item=='(')
                {
                    stack.Push(item);
                    continue;
                }
                if (stack.Count == 0)
                {
                    isValid = false;
                    break;
                }
                if (item=='}'&& stack.Peek()=='{')
                {
                    stack.Pop();
                }
                else if (item==']'&& stack.Peek()=='[')
                {
                    stack.Pop();
                }
                else if (item==')'&& stack.Peek()=='(')
                {
                    stack.Pop();
                }
                else
                {
                    isValid = false;
                    break;
                }
            }
            if (!isValid || stack.Count>0)
            {
                Console.WriteLine("NO");
            }
            else
            {
                Console.WriteLine("YES");
            }
        }
    }
}
