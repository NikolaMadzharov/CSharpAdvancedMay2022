using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Person
    {
        string name;
        int age;

        public string Name { get { return this.name; }  set{name=value;} }

        public int Age { get { return this.age; } set {age=value; } }
    }
}
