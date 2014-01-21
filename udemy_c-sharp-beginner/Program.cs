using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace udemy_c_sharp_beginner
{
    class Date
    {
        private int month, day, year;

        public Date(int m, int d, int y)
        {
            month = m;
            day = d;
            year = y;
        }

        public override string ToString()
        {
            return month + "/" + day + "/" + year;
        }

        public int Month
        {
            get
            {
                return month;
            }
            set
            {
                month = value;
            }
        }
        public int Day
        {
            get
            {
                return day;
            }
            set
            {
                day = value;
            }
        }
        public int Year
        {
            get
            {
                return year;
            }
            set
            {
                year = value;
            }
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            Date today = new Date(7, 12, 2011);
            Console.WriteLine("Today is " + today.ToString());
            today.Day = 11;
            today.Month = 8;
            Console.WriteLine("Today is " + today.ToString());
            Console.WriteLine(today.Month + "/" + today.Day +
                "/" + today.Year);
            Console.ReadKey();
        }
    }
}
