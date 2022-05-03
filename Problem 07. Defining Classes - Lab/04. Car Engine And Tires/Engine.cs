using System;
using System.Collections.Generic;
using System.Text;

namespace CarManufacturer
{
    public class Engine
    {
        int hoursePower;

        double cubicCapacity;

        public Engine()
        {

        }
        public Engine(int hoursepower,double cubiccapacity)
        {
            this.HoursePower = hoursepower;
            this.CubicCapacity = cubiccapacity;
        }

        public int HoursePower { get { return this.hoursePower; } set { hoursePower = value; } }
        public double CubicCapacity { get { return this.cubicCapacity; } set { cubicCapacity = value; } }

    }
}
