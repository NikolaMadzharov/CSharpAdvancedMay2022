using System;
using System.Collections.Generic;

namespace _05._Count_Symbols
{
    internal class Program
    {
        static void Main(string[] args)
        {
          SortedDictionary<char, int> dictionary = new SortedDictionary<char, int>();
            string input = Console.ReadLine();
            fillingDictionary(dictionary,input);
            printingDictionary(dictionary);

        }

        private static void printingDictionary(SortedDictionary<char, int> dictionary)
        {
            foreach (var element in dictionary)
            {
                Console.WriteLine($"{element.Key}: {element.Value} time/s");
            }
        }

        private static SortedDictionary<char, int>  fillingDictionary(SortedDictionary<char, int> dictionary, string input)
        {

            foreach (char element in input)
            {
                if (!dictionary.ContainsKey(element))
                {
                    dictionary.Add(element,0);
                }
                dictionary[element]++;
            }
            return dictionary;
        }
    }
}
