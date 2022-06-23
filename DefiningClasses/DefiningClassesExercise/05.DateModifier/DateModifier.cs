using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class DateModifier
    {
        public DateTime Date1 { get; set; }
        public DateTime Date2 { get; set; }

        public double CalculateDifference(string date1, string date2)
        {
            this.Date1 = DateTime.ParseExact(date1, "yyyy MM dd", System.Globalization.CultureInfo.InvariantCulture);
            this.Date2 = DateTime.ParseExact(date2, "yyyy MM dd", System.Globalization.CultureInfo.InvariantCulture);
            if (DateTime.Compare(Date2, Date1) > 0)
            {
                return Math.Ceiling((Date2 - Date1).TotalDays);
            }
            else
            {
                return Math.Ceiling((Date1 - Date2).TotalDays);
            }
        }
    }
}
