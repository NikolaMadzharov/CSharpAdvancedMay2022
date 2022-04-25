using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._SoftUni_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> regular = new HashSet<string>();
            HashSet<string> vip = new HashSet<string>();
            string people = Console.ReadLine();
            while(people != "PARTY")
            {
                if (char.IsDigit(people[0]))
                {
                    vip.Add(people);
                }
                else
                {
                    regular.Add(people);
                }
                people = Console.ReadLine();
            }
            string guests = Console.ReadLine();
            while (guests!="END")
            {
                if (vip.Contains(guests))
                {
                    vip.Remove(guests);
                }
                else
                {
                    regular.Remove(guests);
                }
                guests = Console.ReadLine();
            }
           int  count = vip.Count + regular.Count;
            Console.WriteLine(count);
            if (vip.Count>0)
            {
                foreach (var guest in vip)
                {
                    Console.WriteLine(guest);
                }
            }
            if (regular.Count>0)
            {
                foreach (var guest in regular)
                {
                    Console.WriteLine(guest);
                }
            }
        }
    }
}
