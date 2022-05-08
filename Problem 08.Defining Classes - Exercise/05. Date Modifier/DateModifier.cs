using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class DateModifier
    {
        public static int differenceBetweenDates (string firstDate, string seconDate)
            {
            DateTime firstD= DateTime.Parse (firstDate);
            DateTime seconD = DateTime.Parse(seconDate);
            TimeSpan timeSpan = firstD - seconD;

            int difference = (int)Math.Abs(timeSpan.TotalDays);
            return difference;
           
            }
    }
}
