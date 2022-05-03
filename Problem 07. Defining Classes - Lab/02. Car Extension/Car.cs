using System;
using System.Collections.Generic;
using System.Text;

namespace CarManufacturer
{
    public class Car
    {
        string make;

        string model;

        int year;

        double fuelQuantity;

        double fuelConsumption;

        public string Make { get { return this.make; } set { make = value; } }

        public string Model { get { return this.model; } set { model = value; } }

        public int Year { get { return this.year; } set { year = value; } }

        public double FuelQuantity { get{ return this.fuelQuantity; } set { fuelQuantity = value; } }

        public double FuelConsumption { get { return this.fuelConsumption; } set { fuelConsumption = value; } }
        public void Drive (double distance)
        {
            if (fuelQuantity-distance* fuelConsumption > 0)
            {
                fuelQuantity -= distance * fuelConsumption;
            }
            else
            {
                Console.WriteLine("Not enough fuel to perform this trip");
            }
        }
        public   string WhoAMI()
        {
            return ($"Make: {this.Make}\nModel: {this.Model}\nYear: {this.Year}\nFuel: {this.FuelQuantity:F2}");
          
        }
    }
}
