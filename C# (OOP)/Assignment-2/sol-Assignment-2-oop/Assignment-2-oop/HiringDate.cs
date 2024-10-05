using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2_oop
{
    public class HiringDate
    {
        int day;
        int month;
        int year;

      
        public int Year
        {
            get { return year; }
            set { year = value >= 2000 && value <= 2024 ? value : 2020; }
        }
        public int Month
        {
            get { return month; }
            set { month = value >= 1 && value <= 12 ? value : 1; }
        }

        public int Day
        {
            get { return day; }
            set { day = value >= 1 && value <= 31 ? value : 1; }
        }
        public override string ToString()
        {
            return $" {day}/{month}/{year}";
        }

    }
}
