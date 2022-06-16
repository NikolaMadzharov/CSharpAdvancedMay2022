using System;
using System.Collections.Generic;
using System.Linq;

namespace Birthday_Celebration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] queueInput = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Queue<int> guests = new Queue<int>(queueInput);
            int [] stackInput = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Stack <int> plates = new Stack<int>(stackInput);
            int wastedFood = 0;
            while (guests.Any()&& plates.Any())
            {
               int currentGuest = guests.Peek();
                int currentPlate = plates.Peek();
                if (currentPlate>=currentGuest)
                {
                    wastedFood += currentPlate - currentGuest;
                    guests.Dequeue();
                    plates.Pop();
                    
                }
                else if (currentGuest>currentPlate)
                {
                   
                    List<int> neededStack = new List<int>(guests);
                    neededStack[0]-=currentPlate;
                    guests = new Queue<int>(neededStack);
                    plates.Pop();
                  
                }
               

            }
            if (plates.Count!=0)
            {
                Console.WriteLine($"Plates: {string.Join(" ",plates)}");
            }
            if (guests.Count!=0)
            {
                Console.WriteLine($"Guests: {string.Join(" ",guests)}");
            }
            Console.WriteLine($"Wasted grams of food: {wastedFood}");

        }
    }
}
