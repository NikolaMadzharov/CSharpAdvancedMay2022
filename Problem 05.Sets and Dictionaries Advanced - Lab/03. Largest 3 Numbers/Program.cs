using System;
using System.Linq;

namespace _03._Largest_3_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
          int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] sortedArray = numbers.OrderByDescending(x=>x).Take(3).ToArray();
          
            for (int i = 0; i < sortedArray.Length; i++)
            {
                Console.Write(sortedArray[i]+" ");
            }
        }
    }
}
