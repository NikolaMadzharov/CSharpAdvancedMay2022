using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    public class Family
    {
        public Family()
        {
            People  = new List<Person>();
        }
        public List<Person> People { get; set; }
        
        public void AddMember(Person person)
        {
            People.Add(person);
        }
        public Person GetOldestMember()
        {
            Person person = People.OrderByDescending(x => x.Age).FirstOrDefault();

            return person; ;
        }
    }
    

}
