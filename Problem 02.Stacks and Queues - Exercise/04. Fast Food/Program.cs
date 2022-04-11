using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Fast_Food
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int quantityOfFood = int.Parse(Console.ReadLine());
            int[] food=Console.ReadLine().Split().Select(int.Parse).ToArray();
            Console.WriteLine(food.Max());
            Queue<int> queue = new Queue<int>(food);
            while (queue.Count>0&&quantityOfFood>=0)
            {
                int currentFoodOrder = queue.Peek();
                if (currentFoodOrder-quantityOfFood>0)
                {
                    break;
                }
                quantityOfFood -= currentFoodOrder;
                queue.Dequeue();
            }
            if (queue.Count>0)
            {
                Console.WriteLine($"Orders left: {string.Join(" ",queue)}");
            }
            else
            {
                Console.WriteLine("Orders complete");
            }
        }
    }
}
