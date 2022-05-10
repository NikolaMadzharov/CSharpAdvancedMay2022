using System;
using System.Collections.Generic;
using System.Text;

namespace _06._Speed_Racing
{
    internal class Car
    {
        public Car(string model, double fuelAmount, double fuelConsumptionPerKilometer)
        {
            Model = model;
            FuelAmount = fuelAmount;
            FuelConsumptionPerKilometer = fuelConsumptionPerKilometer;
            Travelleddistance = 0;
           
        }

       
      

        public string Model { get; set; }

        public double FuelAmount { get; set; }

        public double FuelConsumptionPerKilometer { get; set; }

        public double Travelleddistance { get; set; }

        public void checkIfYoucanDriveCar(double amountOfKmToDrive)
        {
            double litters = amountOfKmToDrive * FuelConsumptionPerKilometer;
            if (FuelAmount-litters>=0)
            {
                FuelAmount -= litters;
                Travelleddistance += amountOfKmToDrive;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }
      

    }
}
