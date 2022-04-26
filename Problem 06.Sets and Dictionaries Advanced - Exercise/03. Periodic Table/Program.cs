using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Periodic_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int numberOfElelements = int.Parse(Console.ReadLine());
         HashSet<string> elements = new HashSet<string>();
            for (int i = 0; i < numberOfElelements; i++)
            {
                string[] chemicalElements = Console.ReadLine().Split(' ');
                foreach (var element in chemicalElements)
                {
                    elements.Add(element);
                }
            }
            HashSet<string> elements2 = elements.OrderBy(x=>x).ToHashSet();
            foreach (var element in elements2)
            {
                Console.Write(element+" ");
            }
           
        }
    }
}
