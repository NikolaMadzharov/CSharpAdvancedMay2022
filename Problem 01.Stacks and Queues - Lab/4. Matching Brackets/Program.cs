using System;
using System.Collections.Generic;

namespace _4._Matching_Brackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            Stack<int> brackets = new Stack<int>();
            for (int i = 0; i < command.Length; i++)
            {
                if (command[i].ToString() == "(")
                {
                    brackets.Push(i);
                }
                else if (command[i].ToString() == ")")
                {
                    int openBracketStart = brackets.Pop();
                    Console.WriteLine(command.Substring(openBracketStart, i - openBracketStart + 1));
                }

            }
        }
    }
}
