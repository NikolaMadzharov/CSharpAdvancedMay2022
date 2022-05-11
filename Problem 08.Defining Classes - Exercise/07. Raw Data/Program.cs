using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Raw_Data
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int n = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                
                    string[] input = Console.ReadLine().Split(' ');
                string model = input[0];
                int engineSpeed = int.Parse(input[1]);
                int enginePower = int.Parse(input[2]);
                int cargoWeight = int.Parse(input[3]);
               string cargoType = input[4];

                double tire1Pressure = double.Parse(input[5]);
                int tire1Age = int.Parse(input[6]);

                double tire2Pressure = double.Parse(input[7]);
                int tire2Age = int.Parse(input[8]);

                double tire3Pressure = double.Parse(input[9]);
                int tire3Age = int.Parse(input[10]);

                double tire4Pressure = double.Parse(input[11]);
                int tire4Age = int.Parse(input[12]);

                Engine engine = new Engine(engineSpeed, enginePower);
                Cargo cargo = new Cargo(cargoType, cargoWeight);
                Tires[] tire = new Tires[]
                {
                   new Tires(tire1Pressure,tire1Age),
                   new Tires(tire2Pressure,tire2Age),
                   new Tires(tire3Pressure,tire3Age),
                   new Tires(tire4Pressure,tire4Age),

                };
                Car car = new Car(model, engine, cargo, tire);
                cars.Add(car);
            }
            List<Car> carsToPrint = new List<Car>();
            string command = Console.ReadLine();
            if (command=="fragile")
            {
                carsToPrint = cars.Where(x => x.cargo.Type == "fragile" && x.tire.Any(p => p.Pressure < 1)).ToList();
            }
            else if (command=="flammable")
            {
                carsToPrint = cars.Where(x => x.cargo.Type == "flammable" && x.engine.Power > 250).ToList();
            }

            

          

            foreach (var car in carsToPrint)
            {
                Console.WriteLine(car.Мodel);
            }
        }
    }
}
