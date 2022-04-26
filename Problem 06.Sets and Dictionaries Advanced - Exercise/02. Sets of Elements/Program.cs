using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Sets_of_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int [] lenghtOfSets = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int firstSetLenght = lenghtOfSets[0];
            HashSet<int> set = new HashSet<int>();

            int secondSetLenght = lenghtOfSets[1];
            HashSet<int> secondSet = new HashSet<int>();

            fillingFirstSet(set,firstSetLenght);
            fillingSecondSet(secondSet, secondSetLenght);
            printingSets(set, secondSet);
        }

        private static void printingSets(HashSet<int> set, HashSet<int> secondSet)
        {
            foreach (var number in set)
            {
                if (secondSet.Contains(number))
                {
                    Console.Write(number+" ");
                }
            }
        }

        private static HashSet<int> fillingSecondSet(HashSet<int> secondSet, int secondSetLenght)
        {
            for (int i = 0; i < secondSetLenght; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                secondSet.Add(currentNumber);
            }
            return secondSet;
        }

        private static HashSet<int> fillingFirstSet(HashSet<int> set, int firstSetLenght)
        {
            for (int i = 0; i < firstSetLenght; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                set.Add(currentNumber);
            }
            return set;
            
        }
    }
}
