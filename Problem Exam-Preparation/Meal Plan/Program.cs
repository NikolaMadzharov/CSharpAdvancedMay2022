using System;
using System.Collections.Generic;
using System.Linq;

namespace Meal_Plan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] mealsInput = Console.ReadLine().Split(' ');
            double[] inputCalories = Console.ReadLine().Split().Select(double.Parse).ToArray();
           Stack<double> caloriesPerDay = new Stack<double>(inputCalories);
            Queue<string> meals = new Queue<string>(mealsInput);
            
            while (caloriesPerDay.Count>0&& meals.Count>0)
            {
                string currentMeal = meals.Peek();
                double currentCalories = caloriesPerDay.Pop();
                if (currentMeal=="salad")
                {
                    if (currentCalories>=350)
                    {
                        currentCalories-=  350;
                       meals.Dequeue();
                        
                    }
                }
                else if (currentMeal=="soup")
                {
                    if (currentCalories>=490)
                    {
                        currentCalories -= 490;
                        meals.Dequeue();
                    }
                }
                else if (currentMeal == "pasta")
                {
                    if (currentCalories >= 680)
                    {
                        currentCalories -= 680;
                        meals.Dequeue();
                    }
                }
                else if (currentMeal == "steak")
                {
                    if (currentCalories >= 790)
                    {
                        currentCalories -= 790;
                        meals.Dequeue();
                    }
                }
               

            }


            }
           
        }
    }
 
