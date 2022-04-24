using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Same_Values_in_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
           double[]input = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            Dictionary < double, int> dictionary = new Dictionary<double, int>();
            foreach (var number in input)
            {
                if (!dictionary.ContainsKey(number))
                {
                    dictionary.Add(number, 0);
                }
                dictionary[number]++;
            }
            foreach (var item in dictionary)
            {
                Console.WriteLine($"{item.Key} - {item.Value} times");
            }
           
        }
    }
}
