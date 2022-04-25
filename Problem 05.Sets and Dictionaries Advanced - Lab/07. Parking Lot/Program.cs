using System;
using System.Collections.Generic;

namespace _07._Parking_Lot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            HashSet<string> parking = new HashSet<string>();
            while (input!="END")
            {
                string[] commands = input.Split(",",StringSplitOptions.RemoveEmptyEntries);
                string action = commands[0];
                string carNumber = commands[1];
                if (action=="IN")
                {
                    parking.Add(carNumber);
                }
                else if (action == "OUT")
                {
                    parking.Remove(carNumber);
                }
                input = Console.ReadLine();
            }
            if (parking.Count>0)
            {
                foreach (var car in parking)
                {
                    Console.WriteLine(car);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
           

        }
    }
}
