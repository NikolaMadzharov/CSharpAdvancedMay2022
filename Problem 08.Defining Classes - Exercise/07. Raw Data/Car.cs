using System;
using System.Collections.Generic;
using System.Text;

namespace _07._Raw_Data
{
    public  class Car
    {
        public Car(string мodel, Engine engine, Cargo cargo, Tires[] tire)
        {
            Мodel = мodel;
            this.engine = engine;
            this.cargo = cargo;
            this.tire = tire;
        }

        public string Мodel { get; set; }

        public Engine engine { get; set; }

        public Cargo cargo { get; set; }

        public Tires[] tire { get; set; }

    }
}
