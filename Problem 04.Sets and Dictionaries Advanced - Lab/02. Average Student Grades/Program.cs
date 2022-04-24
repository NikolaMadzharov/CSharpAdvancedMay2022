using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Average_Student_Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfStudens = int.Parse(Console.ReadLine());
            Dictionary<string,List<decimal>> dictionary = new Dictionary<string,List<decimal>>();
            for (int i = 0; i < numberOfStudens; i++)
            {
                string[] input = Console.ReadLine().Split();
                string name  = input[0];
                decimal grades = decimal.Parse(input[1]);
                if (!dictionary.ContainsKey(name))
                {
                    dictionary.Add(name, new List<decimal>());
                    dictionary[name].Add(grades);

                }
                else
                {
                    dictionary[name].Add(grades);
                }
            }
            foreach (var student in dictionary)
            {
                Console.Write($"{student.Key} -> ");
                foreach (var grade in student.Value)
                {
                    Console.Write($"{grade:f2} ");
                }
                Console.WriteLine($"(avg: {student.Value.Average():f2})");
            }
        }
    }
}
