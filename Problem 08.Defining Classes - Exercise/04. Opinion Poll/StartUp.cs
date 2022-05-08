using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            int countOfPeople = int.Parse(Console.ReadLine());

            for (int i = 0; i < countOfPeople; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                string name = input[0];
                int age = int.Parse(input[1]);
                people.Add(new Person(name, age));
               

            }
            List<Person> peopleOver30 = people.Where(x => x.Age > 30).OrderBy(x => x.Name).ToList();
            foreach (var person in peopleOver30)
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
        }
    }
}
