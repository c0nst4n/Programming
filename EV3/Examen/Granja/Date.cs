using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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


        public override string ToString()
        {
            return _day + "/" + _month + "/" + _year +  " " + _hour + ":" + _minute + ":" + _second; 
        }
        public Date(int day, int month, int year, int hour, int minute, int second)
        {
            _day = day;
            _month = month;
            _year = year;
            _hour = hour;
            _minute = minute;
            _second = second;

            CheckMonth();
            CheckHours();
            CheckDay();
        }


        public void CheckMonth()
        {
            if (_month > 12)
            {
                _month = 0;
                _year++;
            }

            if (_month < 1)
                _month = 1;
               
        }
        public void CheckHours()
        {
            if (_hour > 23)
            {
                _hour = 0;
                _day++;
            }

            if (_hour < 0)
                _hour = 0;

            if (_minute > 59)
            {
                _minute = 0;
                _hour++;
            }

            if (_minute < 0)
                _minute = 0;

            if (_second > 59)
            {
                _second = 0;
                _minute++;
            }

            if (_second < 0)
            {
                _second = 0;
            }
        }


        public void CheckDay()
        {
            int maxday;

            switch (_month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    maxday = 31;
                    break;
                case 2:
                    if (_year % 4 == 0)
                        maxday = 29;
                    else
                        maxday = 30;
                    break;
                default:
                    maxday = 30;
                    break;
            }


            if (_day > maxday)
                _day= maxday;
            if (_day < 1)
                _day= 1;
        }
    }
}
