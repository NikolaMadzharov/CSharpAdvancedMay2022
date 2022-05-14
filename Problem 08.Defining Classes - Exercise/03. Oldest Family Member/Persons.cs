using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Person
    {
        string name;
        int age;

        public Person()
        {
            name = "No name";
            age = 1;
        }

        public Person(int age):this()
        {
            Age = age;
        }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get { return this.name; }  set{name=value;} }

        public int Age { get { return this.age; } set {age=value; } }
    }
}
