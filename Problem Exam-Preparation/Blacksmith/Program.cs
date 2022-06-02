using System;
using System.Collections.Generic;
using System.Linq;

namespace Blacksmith
{
    internal class Program
    {
        private static int count;
        static void Main(string[] args)
        {
            SortedDictionary<string, int> items = new SortedDictionary<string, int>
            {
                {"Gladius",0},
                {"Shamshir",0 },
                {"Katana",0},
                {"Sabre",0 },
                {"Broadsword",0 }
            };

            int []queueInput = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] stackInput = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> queue = new Queue<int>(queueInput);

            Stack <int> stack = new Stack<int>(stackInput);
            count = 0;
            while (queue.Count > 0&& stack.Count>0)
            {
                int currentQueueValue  =  queue.Peek();
                int currentStackValue  = stack.Pop();
                int result  = currentQueueValue+ currentStackValue;
              
                if (result == 70)
                {
                    items["Gladius"]++;
                    count++;
                    //queue.Dequeue();
                    //stack.Pop();
                }
                else if (result==80)
                {
                    items["Shamshir"]++;
                    count++;
                    //queue.Dequeue();
                    //stack.Pop();
                }
                else if (result ==90)
                {
                    items["Katana"]++;
                    count++;
                    //queue.Dequeue();
                    //stack.Pop();
                }
                else if (result == 110)
                {
                    items["Sabre"]++;
                    count++;
                    //queue.Dequeue();
                    //stack.Pop();
                }
                else if (result==150)
                {
                    items["Broadsword"]++;
                    count++;
                    //queue.Dequeue();
                    //stack.Pop();
                }
                else
                {
                    
                   
                    stack.Push(currentStackValue+5);
                    
                }
                queue.Dequeue();
               


            }
            
            if (count>0)
            {
                Console.WriteLine($"You have forged {count} swords.");
            }
            else
            {
                Console.WriteLine("You did not have enough resources to forge a sword.");
                if (queue.Count > 0)
                {
                    Console.WriteLine($"Steel left: {string.Join(", ", queue)}");
                }
                else
                {
                    Console.WriteLine("Steel left: none");
                }
                if (stack.Count > 0)
                {
                    Console.WriteLine($"Carbon left: {string.Join(", ", stack)}");
                }
                else
                {
                    Console.WriteLine("Carbon left: none");
                }
                return;
            }
            if (queue.Count>0)
            {
                Console.WriteLine($"Steel left: {string.Join(", ",queue)}");
            }
            else
            {
                Console.WriteLine("Steel left: none");
            }
            if (stack.Count>0)
            {
                Console.WriteLine($"Carbon left: {string.Join(", ",stack)}");
            }
            else
            {
                Console.WriteLine("Carbon left: none");
            }
            foreach (var item in items.Where(x=>x.Value>=1))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
