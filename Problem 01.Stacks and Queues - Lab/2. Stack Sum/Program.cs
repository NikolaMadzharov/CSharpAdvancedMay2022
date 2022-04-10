using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Stack_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>(numbers);
            string command = Console.ReadLine().ToLower();
            while (command != "end")
            {

                string[] actions = command.Split(' ');
                if (actions[0] == "add")
                {
                    int firstNumber = int.Parse(actions[1]);
                    int secondNumber = int.Parse(actions[2]);
                    stack.Push(firstNumber);
                    stack.Push(secondNumber);
                }
                else if (actions[0] == "remove")
                {
                    int count = int.Parse(actions[1]);
                    if (stack.Count >= count)
                    {
                        for (int i = 0; i < count; i++)
                        {
                            stack.Pop();
                        }
                    }

                }
                command = Console.ReadLine().ToLower();

            }
            int sum = stack.Sum();
            Console.WriteLine($"Sum: {sum}");

        }
    }
}