using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
           Family family = new Family();
            int members = int.Parse(Console.ReadLine());  

            for (int i = 0; i < members; i++)
            {
                string [] input = Console.ReadLine().Split(' '); 
                string name = input[0];
                int age = int.Parse(input[1]);

                Person person = new Person(name,age);

               family.AddMember(person);
            }
           Person oldest = family.GetOldestMember();
            Console.WriteLine($"{oldest.Name} {oldest.Age}");
        }
    }
}
