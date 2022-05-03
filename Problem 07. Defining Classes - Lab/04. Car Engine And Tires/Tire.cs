using System;
using System.Collections.Generic;
using System.Text;

namespace CarManufacturer
{
    public class Tire
    {
        int year;
        double pressure;

        public Tire()
        {

        }
        public Tire(int year,double pressure)
        {
            this.Year = year;
            this.Pressure = pressure;
        }

        public int Year { get { return this.year; } set { year=value; } }

        public double Pressure { get { return this.pressure; } set {pressure=value; } }
    }
}
