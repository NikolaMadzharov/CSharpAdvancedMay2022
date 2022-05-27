using System;
using System.Collections.Generic;
using System.Linq;

namespace Food_Finder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> words = new Dictionary<string, int>()
            {
                {"pear",0 },
                {"flour",0 },
                {"pork",0 },
                {"olive",0 },
            };
            char[] inputVowels = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            char[] inputConsonant = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();

            string pear = "pear";
            string flour = "flour";
            string pork = "pork";
            string olive = "olive";


            int pearLength = pear.Length;
            int flourLength = flour.Length;
            int porkLength = pork.Length;
            int oliveLength = olive.Length;



            

            Queue<char> vowel = new Queue<char>(inputVowels);
            Stack<char> consonant = new Stack<char>(inputConsonant);

            while (consonant.Count > 0)
            {
                char currentVowel = vowel.Dequeue();
                char currentConsonant = consonant.Pop();

                if (pear.Contains(currentVowel))
                {
                    pear = pear.Replace(currentVowel,' ');
                    pearLength--;
                }
                if (flour.Contains(currentVowel))
                {
                    flour = flour.Replace(currentVowel,' ');
                    flourLength--;
                }
                if (pork.Contains(currentVowel))
                {
                    pork = pork.Replace(currentVowel,' ');
                    porkLength--;
                }
                if (olive.Contains(currentVowel))
                {
                    olive = olive.Replace(currentVowel,' ');
                    oliveLength--;
                }


                if (pear.Contains(currentConsonant))
                {
                    pear = pear.Replace(currentConsonant,' ');
                    pearLength--;
                }
                if (flour.Contains(currentConsonant))
                {
                    flour = flour.Replace(currentConsonant,' ');
                    flourLength--;
                }
                if (pork.Contains(currentConsonant))
                {
                    pork = pork.Replace(currentConsonant,' ');
                    porkLength--;
                }
                if (olive.Contains(currentConsonant))
                {
                    olive = pear.Replace(currentConsonant,' ');
                    oliveLength--;
                }
                if (pearLength==0)
                {
                    words["pear"]++;
                }
                if (flourLength==0)
                {
                    words["flour"]++;
                }
                if (porkLength==0)
                {
                    words["pork"]++;
                }
                if (oliveLength==0)
                {
                    words["olive"]++;
                }

                vowel.Enqueue(currentVowel);

            }
            Console.WriteLine($"Words found: {words.Where(x=>x.Value>0).Count()}");
            foreach (var word in words)
            {
                if (word.Value>0)
                {
                    Console.WriteLine(word.Key);
                }
            }
        }
    }
}
