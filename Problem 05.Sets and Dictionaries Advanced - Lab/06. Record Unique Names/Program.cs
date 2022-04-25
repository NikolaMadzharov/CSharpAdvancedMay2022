using System;
using System.Collections.Generic;

namespace _06._Record_Unique_Names
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfNames = int.Parse(Console.ReadLine());
            HashSet<string> set = new HashSet<string>();
            for (int i = 0; i < numberOfNames; i++)
            {
                string name = Console.ReadLine();
                set.Add(name);
            }
            foreach (var item in set)
            {
                Console.WriteLine(item);
            }
        }
    }
}
