using System;
using System.Collections.Generic;
using System.Linq;

namespace Bakery_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,int> bekaryResult = new Dictionary<string, int>
            {
                {"Croissant", 0 },
                {"Muffin", 0 },
                {"Baguette", 0 },
                {"Bagel", 0 }
            };

            double[] inputWater = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            double[] inputFlour = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            Queue<double> water = new Queue<double>(inputWater);
            Stack<double> flour = new Stack<double>(inputFlour);

          

            while (water.Count>0 && flour.Count>0)
            {
                double waterPeek = water.Peek();
                double flourPeek = flour.Peek();
                double[] flourAndWaterPercentange = new double[2];
                double result = waterPeek + flourPeek;
                flourAndWaterPercentange[0] = (waterPeek / result) * 100;
                flourAndWaterPercentange[1] = (flourPeek / result) * 100;
                
                if (flourAndWaterPercentange[0]==50 && flourAndWaterPercentange[1]==50)
                {
                    bekaryResult["Croissant"]++;
                    water.Dequeue();
                    flour.Pop();

                }
                else if (flourAndWaterPercentange[0] == 40 && flourAndWaterPercentange[1] == 60)
                {
                    bekaryResult["Muffin"]++;
                    water.Dequeue();
                    flour.Pop();
                }
                else if (flourAndWaterPercentange[0] == 30 && flourAndWaterPercentange[1] == 70)
                {
                    bekaryResult["Baguette"]++;
                    water.Dequeue();
                    flour.Pop();
                }
                else if (flourAndWaterPercentange[0] == 20 && flourAndWaterPercentange[1] == 80)
                {
                    bekaryResult["Bagel"]++;
                    water.Dequeue();
                    flour.Pop();
                }
                else
                {
                     double currentFlour = flour.Pop();
                    double currentWater = water.Dequeue();
                    double diffFlourAndWater = currentFlour - currentWater;
                    bekaryResult["Croissant"]++;
                    flour.Push(diffFlourAndWater);

                }

            }
           
            foreach (var product in bekaryResult.OrderByDescending(x=>x.Value).ThenBy(x=>x.Key))
            {


                if (product.Value>0)
                {
                    Console.WriteLine($"{product.Key}: {product.Value}");

                }



            }
            if (water.Count > 0)
            {
                Console.Write("Water left: ");
                Console.Write(String.Join(", ", water));
                 Console.WriteLine();

            }
            else
            {
                Console.WriteLine("Water left: None");
            }
            if (flour.Count > 0)
            {
                Console.Write("Flour left: ");
                Console.Write(String.Join(", ",flour));
               Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Flour left: None");
            }


        }

        
        
    }
}
