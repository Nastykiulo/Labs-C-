using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Linq;

namespace CSharpConsoleApp
{
    class Date : IComparable<Date>
    {
        public readonly int y = 0; // можно так инициализировать поле только для чтения

        const int CC = 100;//константа

        private int _year;
        public int Year
        {
            
        set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(
                        "Year lesser than zero.");
                }
                _year = value;
            }
            get
            {
                return _year;
            }
        }

        private int _month;
        public int Month
        {
            set
            {
                if ((value < 1) || (value > 12))
                {
                    throw new ArgumentOutOfRangeException(
                        "Month must be between 1 and 12.");
                }
                _month = value;
            }
            get
            {
                return _month;
            }
        }

        private int _day;
        public int Day
        {
            set
            {
                if ((value < 1) || (value > 31))
                {
                    throw new ArgumentOutOfRangeException(
                        "Day must be between 1 and 31.");
                }
                _day = value;
            }
            get
            {
                return _day;
            }
        }

        public Date(int year, int month, int day)
        {
            Year = year;
            Month = month;
            Day = day;
        }

        public Date(DateTime dt)
        {
            Year = dt.Year;
            Month = dt.Month;
            Day = dt.Day;
        }


        public DateTime ToDateTime()
        {
            return new DateTime(Year, Month, Day);
        }

        public static DateTime ToDateTime(Date date)
        {
            return new DateTime(date.Year, date.Month, date.Day);
        }

        public static Date operator ++(Date arg)
        {
            return new Date(arg.Year, arg.Month, arg.Day + 1);
        }

        public static Date CreateDate(int year, int dayFromStart)
        {
            DateTime start = new DateTime(year, 1, 1);
            start = start.AddDays(dayFromStart);
            return new Date(start);
        }

        public int CompareTo(Date other)
        {
            return ToDateTime().CompareTo(Date.ToDateTime(other));
        }

        public override string ToString()
        {
            return $"{Day}/{Month}/{Year}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Date today = new Date(DateTime.Now);
            Console.WriteLine(today);
            //
            Date[] dates = {
                new Date(1812, 9, 7),
                new Date(1945, 5, 9),
                new Date(1917, 11, 7)
            };
            Date last = dates.Max();
            Date last2 = dates.Min();
            
            Console.WriteLine(last);
            Console.WriteLine(last2);


            // Анонимные типы 
            var someType = new { Name = "Anna" };
        }
        
    }

    public partial class Student
    {
        private string name;
        private string secondName = "NoName";
        private int course;
        private const string UO = "БГТУ";
    }


}