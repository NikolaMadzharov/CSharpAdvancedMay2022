using System;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Make = "VW";
            car.Model = "MK3";
            car.Year = 1992;
            car.FuelQuantity = 220;
            car.FuelConsumption = 10;
            car.Drive(20);
            Console.WriteLine(car.WhoAMI());
            
        }
    }
}
