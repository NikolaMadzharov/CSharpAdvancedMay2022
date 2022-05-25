using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace FishingNet
{
    public class Net
    {
        public List<Fish> Fish = new List<Fish>();

        public Net(string material, int capacity)
        {
            Material = material;
            Capacity = capacity;
        }

        public string Material { get; set; }

        public int Capacity { get; set; }

        public int Count => this.Fish.Count;

        public string AddFish(Fish fish)
        {
            if (string.IsNullOrWhiteSpace(fish.FishType)||fish.Length<=0 || fish.Weight<=0)
            {
                return "Invalid fish.";
            }
            if (Count==Capacity)
            {
                return "Fishing net is full";
            }
            Fish.Add(fish);
            return $"Successfully added {fish.FishType} to the fishing net.";
        }
        public bool ReleaseFish(double weight)
        {
           Fish fish =  this.Fish.FirstOrDefault(x => x.Weight==weight);
            if (fish != null)
            {
                return this.Fish.Remove(fish);
            }
            return false;
        }
         public Fish GetFish(string fishType)
        {
            Fish fish = this.Fish.FirstOrDefault(x=>x.FishType==fishType);
            return fish;
        }

        public Fish GetBiggestFish()
        {
            double longestFish = this.Fish.Max(e => e.Length);
            Fish fish = this.Fish.FirstOrDefault(e => e.Length == longestFish);
            return fish;

        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Into the {this.Material}:");
            foreach (var fish in Fish.OrderByDescending(x=>x.Length))
            {
                sb.AppendLine(fish.ToString());
            }
            return sb.ToString().TrimEnd();
        }




    }
}
