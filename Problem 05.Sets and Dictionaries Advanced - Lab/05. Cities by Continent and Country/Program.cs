using System;
using System.Collections.Generic;

namespace _05._Cities_by_Continent_and_Country
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfCountries = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, List<string>>> world = new Dictionary<string, Dictionary<string, List<string>>>();
            for (int i = 0; i < numberOfCountries; i++)
            {
                string [] input = Console.ReadLine().Split();
                string contitent = input[0];
                string country = input[1];
                string city = input[2];
                if (!world.ContainsKey(contitent))
                {
                    world.Add(contitent, new Dictionary<string, List<string>>( ));
                    

                }
               if (!world[contitent].ContainsKey(country))
                {
                    world[contitent].Add(country, new List<string>());
                }
             
                
                    world[contitent][country].Add(city);

                


              
               
               
             
                




            }
            foreach (var contitent in world)
            {
                Console.WriteLine($"{contitent.Key}:");
           
                foreach (var country in contitent.Value)
                {
                    Console.WriteLine($"{country.Key} -> {string.Join(", ", country.Value)}");
                }
            }
        }
    }
}
