using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Speed_Racing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string model = input[0];
                int fuelAmount = int.Parse(input[1]);
                double fuelRate = double.Parse(input[2]);
                Car car = new Car(model, fuelAmount, fuelRate);
               cars.Add(car);
                

                
                


            }
           
            while (true)
            {
                string input2 = Console.ReadLine();
                if (input2=="End")
                {
                    break;
                }
                string[] tokens = input2.Split();
                string action = tokens[0];
                string model = tokens[1];
                double amountOfKmToDrive = double.Parse(tokens[2]);


               
                Car carToSearch = cars.Where(x=> x.Model == model).FirstOrDefault();
                  carToSearch.checkIfYoucanDriveCar(amountOfKmToDrive);
                


            }
            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.Travelleddistance}");
            }
           

            
        }

       
    }
}
