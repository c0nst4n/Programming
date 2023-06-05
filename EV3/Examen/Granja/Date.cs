using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Granja
{
    public class Date
    {
        private int _day;
        private int _month;
        private int _year;
        private int _hour;
        private int _minute;
        private int _second;
        public int Year => _year;
        public int Month => _month;
         public int Day => _day;
        public int Hour => _hour;
        public int Minute => _minute;
        public int Second => _second;

        public Date(int day, int month, int year, int hour, int minute, int second)
        {
            _day = day;
            _month = month;
            _year = year;
            _hour = hour;
            _minute = minute;
            _second = second;
        }
    }
}
