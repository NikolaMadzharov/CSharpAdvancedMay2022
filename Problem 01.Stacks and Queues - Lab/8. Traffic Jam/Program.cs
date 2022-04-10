using System;
using System.Collections.Generic;

namespace _8._Traffic_Jam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfPassingCars = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            Queue<string> queue = new Queue<string>();
            int passedCars = 0;
            while (command != "end")
            {
                if (command == "green")
                {
                    for (int i = 0; i < countOfPassingCars; i++)
                    {
                        if (queue.Count == 0)
                        {
                            break;
                        }
                        string currentCar = queue.Dequeue();
                        Console.WriteLine($"{currentCar} passed!");
                        passedCars++;
                    }
                }
                else
                {
                    queue.Enqueue(command);
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"{passedCars} cars passed the crossroads.");
        }
    }
}