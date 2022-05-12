using System;
using System.Linq;

namespace _03._Count_Uppercase_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            Func<string, bool> isUpperLetter = w=>char.IsUpper(w[0]);
            Console.WriteLine(String.Join(" ",input.Where(isUpperLetter)));
        }
    }
}
