using System;
using System.Linq;

namespace _04._Add_VAT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal[] number = Console.ReadLine().Split(", ").Select(decimal.Parse).ToArray();
            numbers = number.Select(x=>x +x*0.2m).ToArray();

            foreach (var number in numbers)
            {
                Console.WriteLine($"{number:f2}");
            }
        }
    }
}
