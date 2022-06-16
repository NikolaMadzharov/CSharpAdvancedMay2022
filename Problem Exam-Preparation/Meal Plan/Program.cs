using System;
using System.Collections.Generic;
using System.Linq;

namespace MealPlan
{
    class Program
    {
        static void Main(string[] args)
        {
            int salad = 350;
            int soup = 490;
            int pasta = 680;
            int steak = 790;

            string[] meals = Console.ReadLine().Split();
            Queue<string> queue = new Queue<string>(meals);
            int[] calories = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>(calories);

            while (queue.Count != 0 && stack.Count != 0)
            {
                int meal = 0;
                int calorie = stack.Peek();
                if (queue.Peek() == nameof(salad))
                {
                    meal = salad;
                }
                else if (queue.Peek() == nameof(soup))
                {
                    meal = soup;
                }
                else if (queue.Peek() == nameof(pasta))
                {
                    meal = pasta;
                }
                else if (queue.Peek() == nameof(steak))
                {
                    meal = steak;
                }

                if (calorie < meal)
                {
                    stack.Pop();
                    int difference =Math.Abs(calorie-meal);
                   
                    if (!stack.Any())
                    {
                        queue.Dequeue();
                        break;
                       
                    }
                    queue.Dequeue();
                    
                    stack.Push(stack.Pop()-difference);
                    
                }
                else if (calorie >= meal)
                {
                    stack.Pop();
                    calorie -= meal;
                    stack.Push(calorie);
                    queue.Dequeue();
                }
            }
            if (stack.Count == 0)
            {
                Console.WriteLine($"John ate enough, he had {meals.Length - queue.Count} meals.");
                Console.WriteLine($"Meals left: {string.Join(", ", queue)}.");
            }
            if (queue.Count == 0)
            {
                //                "John had {number of meals} meals."
                //"For the next few days, he can eat {dailyCalories1, dailyCalories2, etc.} calories."
                Console.WriteLine($"John had {meals.Length} meals.");
                Console.WriteLine($"For the next few days, he can eat {string.Join(", ", stack)} calories.");
            }
        }
    }
}



