using System;
using System.Collections.Generic;
using System.Text;

namespace Renovators
{
    public class Renovator
    {
        public Renovator(string name, string type, double rate, int days)
        {
            Name = name;
            Type = type;
            Rate = rate;
            Days = days;
        }

        public string Name { get; set; }

        public string Type { get; set; }

        public double Rate { get; set; }
        public int Days { get; set; }

        public bool Hired { get; set;} = false;

        public override string ToString()
        {
            StringBuilder info = new StringBuilder();
            info.Append($"-Renovator: {this.Name}{Environment.NewLine}--Specialty: {this.Type}{Environment.NewLine}--Rate per day: {this.Rate} BGN");
            return info.ToString();

        }
    }

}
