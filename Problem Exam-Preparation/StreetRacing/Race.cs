using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StreetRacing
{
    public class Race
    {
        public Race(string name, string type, int laps, int capacity, int maxHorsePower)
        {
            Name = name;
            Type = type;
            Laps = laps;
            Capacity = capacity;
            MaxHorsePower = maxHorsePower;
        }

        public string Name { get; set; }

        public string Type { get; set; }

        public int Laps { get; set; }

        public int Capacity { get; set; }

        public int MaxHorsePower { get; set; }

        private List<Car> Participants = new List<Car>();
        public int Count=>Participants.Count;

        public void  Add(Car car)
        {
            Car newCar = Participants.Where(l => l.LicensePlate != l.LicensePlate).Where(h => h.HorsePower < MaxHorsePower).FirstOrDefault();
            if (Capacity<Count)
            {
            Participants.Add(newCar);
            }
        }
        public bool Remove(string licensePlate)
        {
            Car car =  Participants.Where(l => l.LicensePlate == licensePlate).FirstOrDefault();
            
            return Participants.Remove(car);
           
        }
        public Car FindParticipant(string licensePlate)
        {
            Car car = Participants.Where(l=>l.Equals(licensePlate)).FirstOrDefault();
            if (car==null)
            {
                return null;
            }
            return car;
        }

        public Car GetMostPowerfulCar()
        {
            int maxHoursePower = Participants.Max(p=>p.HorsePower);
            Car car = Participants.Where(h=> h.HorsePower== maxHoursePower).FirstOrDefault();

            if (car==null)
            {
                return null;
            }
            return car;
        }
        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Race: { Name} -Type: { Type} (Laps: { Laps})");
            foreach (var car in Participants)
            {
                sb.AppendLine(car.ToString());
            }
            return sb.ToString().TrimEnd();
        }
    }
}
