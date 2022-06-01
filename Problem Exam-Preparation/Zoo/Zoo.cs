using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zoo
{
    public class Zoo
    {
        public Zoo(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
        }

          public List<Animal> Animals { get; set; } =new List<Animal>();
        public string Name { get; set; }

        public int Capacity { get; set; }

        public string AddAnimal(Animal animal)
        {
            if (string.IsNullOrWhiteSpace(animal.Species))
            {
                return "Invalid animal species";
            }
            if (animal.Diet!= "herbivore" && animal.Diet!= "carnivore")
            {
                return "Invalid animal diet";
            }
            if (Animals.Count>=Capacity)
            {
                return "The zoo is full";
            }
            Animals.Add(animal);
            return $"Successfully added {animal} to the zoo.";
        }

        public int RemoveAnimals(string species)
        {
            int count = this.Animals.RemoveAll(a => a.Species == species);
            return count;
        }
        public List<Animal> GetAnimalsByDiet(string diet)
        {
            List<Animal> animals = Animals.Where(a => a.Diet == diet).ToList();
            return animals;
        }
        public Animal GetAnimalByWeight(double weight)
        {
            return Animals.FirstOrDefault(a => a.Weight == weight);
        }
        
        public string GetAnimalCountByLength(double minimumLength, double maximumLength)
        {
            int count  = Animals.Count(x => minimumLength <= maximumLength);
            return $"There are {count} animals with a length between {minimumLength} and {maximumLength}meters.";

        }

    }
}
