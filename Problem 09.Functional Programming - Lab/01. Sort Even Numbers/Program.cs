using System;
using System.Linq;

namespace _01._Sort_Even_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            numbers=numbers.Where(x=>x%2==0).OrderBy(x=>x).ToArray();

            Console.WriteLine(String.Join(", ",numbers));


        }
    }
}
