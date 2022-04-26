using System;
using System.Collections.Generic;

namespace _01._Unique_Usernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int numbersOfNames = int.Parse(Console.ReadLine());
            HashSet<string> names = new HashSet<string>();
            FillingSet(names,numbersOfNames);
            printingNames(names);
        }

        private static HashSet<string> FillingSet(HashSet<string> set, int numbersOfNames)
        {
           
            for (int i = 0; i < numbersOfNames; i++)
            {
                string name = Console.ReadLine();
                set.Add(name);
            }
            return set;
           
        }

        private static void printingNames(HashSet<string> set)
        {
           
            foreach (var name in set)
            {
                Console.WriteLine(name);
            }
        }
    }
}
