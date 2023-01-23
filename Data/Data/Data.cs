using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    internal class Data
    {
        int _day;
        int _month;
        int _year;
        public Data()
        {
            _day = 1;
            _month = 1;
            _year = 1900;
        }
        public Data(int day, int month, int year) 
        {
            _day=day;
            _month=month;
            _year=year;
        }

       public int Day
        {
            get => _day;

            set 
            { _day = value;
                if (_day == null)
                    _day = 1;                   
             }
                
            
        }

        public int Month
        {
            get => _month;

            set 
            {
                _month = value;
                if (_month == null)
                    _month = 1;
            }
        }

        public int Year
    }
}
