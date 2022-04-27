using System;
using System.Collections.Generic;

namespace _06._Wardrobe
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int numberOfClothes = int.Parse(Console.ReadLine());
            Dictionary<string,Dictionary<string,int>> wardrobe = new Dictionary<string,Dictionary<string,int>>();
            fillingWardrobe(wardrobe, numberOfClothes);
            printingWardrobe(wardrobe);
        }

        private static void printingWardrobe(Dictionary<string, Dictionary<string, int>> wardrobe)
        {
            string[] dressToSearch = Console.ReadLine().Split();
            string colorToSearch =dressToSearch[0];
            string clothToSearch = dressToSearch[1];
            foreach (var element in wardrobe)
            {
               
                Console.WriteLine($"{element.Key} clothes:");
                foreach (var item in element.Value)
                {
                    
                    if (element.Key == colorToSearch && item.Key == clothToSearch)
                    {
                        Console.WriteLine($"* {item.Key} - {item.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {item.Key} - {item.Value}");

                    }
                }
                

            }

        }

        private static Dictionary<string, Dictionary<string, int>> fillingWardrobe(Dictionary<string, Dictionary<string, int>> wardrobe, int numberOfClothes)
        {
            for (int i = 0; i < numberOfClothes; i++)
            {
                string[] input = Console.ReadLine().Split(" -> ");
                string color = input[0];
                string[] clothes = input[1].Split(',');
                if (!wardrobe.ContainsKey(color))
                {
                    wardrobe.Add(color, new Dictionary<string,int>());
                    for (int j = 0; j < clothes.Length; j++)
                    {
                        if (wardrobe[color].ContainsKey(clothes[j]))
                        {

                            ;
                            wardrobe[color][clothes[j]]++;
                        }
                        else
                        {

                            wardrobe[color].Add(clothes[j], 1);

                        }

                    }
                    
                    
                }
                else
                {
                    for (int z = 0; z < clothes.Length; z++)
                    {
                        if (wardrobe[color].ContainsKey(clothes[z]))
                        {
                           
                           
                            wardrobe[color][clothes[z]]++;
                        }
                        else
                        {
                            
                            wardrobe[color].Add(clothes[z], 1);

                        }
                      
                        
                       
                    }
                }

                //foreach (var cloth in clothes)
                //{
                //    if (!wardrobe.ContainsKey(cloth))
                //    {
                //        wardrobe[color].Add(cloth, 0);
                //    }
                //    wardrobe[color][cloth]++;
                //}
            }
            return wardrobe;
          
        }
    }
}
