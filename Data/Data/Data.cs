using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

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
        {
            get => _year;

            set
            {
                _year = value;
                if (_year == null)
                    _year = 1900;
            }
        }

        public bool IsLeap()
        {
            return _year % 4 == 0;
        }

        public int GetDaysInMonth() 
        {
            switch (_month)
            {
                case 1:
                    return 31;
                    break;
                case 2:
                    if (IsLeap())
                    {
                        return 29;
                        break;
                    }
                    return 28;
                    break;
                case 3:
                    return 31;
                    break;
                case 4:
                    return 30;
                    break;
                case 5:
                    return 31;
                    break;
                case 6:
                    return 30;
                    break;
                case 7:
                    return 31;
                    break;
                case 8:
                    return 31;
                    break;
                case 9:
                    return 30;
                    break;
                case 10:
                    return 31;
                    break;
                case 11:
                    return 30;
                    break;
                default:
                    return 31;
                    break;
            }
           
        }

        public static int GetDaysInSaidMonth(int SaidMonth)
        {
            switch (SaidMonth)
            {
                case 1:
                    return 31;
                    break;
                case 2:
                    if (IsLeap())
                    {
                        return 29;
                        break;
                    }
                    return 28;
                    break;
                case 3:
                    return 31;
                    break;
                case 4:
                    return 30;
                    break;
                case 5:
                    return 31;
                    break;
                case 6:
                    return 30;
                    break;
                case 7:
                    return 31;
                    break;
                case 8:
                    return 31;
                    break;
                case 9:
                    return 30;
                    break;
                case 10:
                    return 31;
                    break;
                case 11:
                    return 30;
                    break;
                default:
                    return 31;
                    break;
            }

        }


    

       public enum DaysOfWeek
        {
            MONDAY,
            TUESDAY,
            WEDNESDAY,
            THURSDAY,
            FRIDAY,
            SATURDAY,
            SUNDAY
        }

        public DaysOfWeek DayName() 
        {
            
            int n = ((14 - _month) / 12);
            _year = (_year - n);
            _month = (_month + (12 * n) - 2);
            return (DaysOfWeek)(((_day + _year *(_year / 4) - (_year / 100) + (_year / 400) + ((31 * _month) / 12)) % 7));
        }

        public bool IsValid()
        {
            bool checkday = false;
            bool checkmonth = false;
            bool checkyear = false;
            if (_day > 0 && _day <= GetDaysInMonth())
                checkday = true;

            if (_month > 0 && _month <= 12)
                checkmonth = true;

            if (_year > 1899 && _year <= 2050)
                checkyear = true;

            return checkday && checkmonth && checkyear;
        }

        public string ToShortString()
        {
            return JsonSerializer.Serialize(_day + "-" + _month + "-" + _year);
        }

        enum MONTHNAME
        {
            January,
            February,
            March,
            April,
            May,
            June,
            July,
            August,
            September,
            October,
            November,
            December
        }

        public string ToString()
        {

            return DayName() +" "+ _day + " of " + (MONTHNAME)(_month -1) + " of " + _year;
        }

        public int ElapsedDays()
        {
            int result = 0;
            int startyear = 1900;
            int YEARS = _year; 
            while (startyear < _year)
            {
                if (IsLeap())
                    result += 366;
                else
                    result += 365;

                startyear++;
            }

            for(int i = 1; i < _month; i++)
            {
                result += GetDaysInMonth();
            }

            for (int i = 1; i < _day; i++)
            {
                result++;
            }

            return result;
        }



        public Data ElapsedData(int inputDays)
        {
            int Year = 1900;
            int Month = 1;
            int Day = 1;
            
            while(inputDays > 365)
            {
                if (Year % 4 == 0)
                    inputDays -= 366;
                else
                    inputDays -= 365;
                Year++;
            }

            while (inputDays > GetDaysInSaidMonth(Month))
            {
                inputDays -= GetDaysInSaidMonth(Month);
                Month++;
            }

            while (inputDays <= GetDaysInSaidMonth(Month))
            {
                inputDays--;
                Day++;
            }

            Data Result = new Data(Day, Month, Year);
            return Result;
        }

        public int daysBeetween(Data InputData)
        {

            int Result = 0;

            while (_year < InputData._year)
            {
                if (InputData._year % 4 == 0)
                    Result += 366;
                else
                    Result += 365;

                _year++;
                 
            }

            while (_month < InputData._month)
            {
                Result += GetDaysInSaidMonth(_month);

                _month++;
            }

            while(_day < InputData._day)
            {
                Result++;
                _month++;
            }
           
            return Result;
            //A esto aún le falta la mitad
        }

        public void NextDay()
        {
            if (_day == 31 && _month == 12)
            {
                _day = 1;
                _month = 1;
                _year++;

            }
            else if (_day == GetDaysInMonth())
            {
                _day = 1;
                _month++;
            }

            else { _day++; }

        }

        public void FormerDay()
        {
            if (_day == 1 && _month == 1)
            {
                _year--;
                _month = 12;
                _day = 31;
            }
            else if (_day == 1)
            {
                _month--;
                
            }
            else { _day--; }
        }

        public Data Copy()
        {
            Data Copy = new Data(_day, _month, _year);
            return Copy;
        }
    }
}
