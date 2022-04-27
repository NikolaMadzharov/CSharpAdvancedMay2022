using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Even_Times
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
          Dictionary<int, int> numbers = new Dictionary<int, int>();
            fillingDictionary(numbers, lines);
            printingDicionary(numbers);
        }

        private static void printingDicionary(Dictionary<int, int> numbers)
        {
            int sum = 0;
            foreach (KeyValuePair<int, int> pair in numbers)
            {
                if (pair.Value % 2 == 0)
                {
                    Console.WriteLine(pair.Key);
                }
               
            }
            //foreach (var kvp in numbers.Where(kvp => kvp.Value % 2 == 0))
            {
                //Console.WriteLine(kvp.Key);
            }

        }

        private static Dictionary<int,int> fillingDictionary(Dictionary<int,int> numbers,int lenghtOfTheLoop)
        {
            for (int i = 0; i < lenghtOfTheLoop; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                if (!numbers.ContainsKey(currentNumber))
                {
                    numbers.Add(currentNumber, 0);
                
                }
             
                
                   numbers[currentNumber]++;
                
            }
            return numbers;
            
        }
    }
}
