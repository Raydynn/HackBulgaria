using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Time
{
    class Program
    {
        class Date
        {
            private int hours;
            private int minutes;
            private int seconds;
            private int dayOfMonth;
            private int month;
            private int year;
            
            public int Hours
            {
                get { return this.hours; }
                set
                {
                    if (value < 0 || value >= 24)
                    {
                        throw new IndexOutOfRangeException();
                    }
                    else
                    {
                        this.hours = value;
                    }
                }
            }

            public int Minutes
            {
                get { return this.minutes; }
                set
                {
                    if (value < 0 || value > 59)
                    {
                        throw new IndexOutOfRangeException();
                    }
                    else
                    {
                        minutes = value;
                    }
                }
            }
            public int Seconds
            {
                get { return this.seconds; }
                set
                {
                    if (value < 0 || value > 59)
                    {
                        throw new IndexOutOfRangeException();
                    }
                    else
                    {
                        seconds = value;
                    }
                }
            }
            public int Year
            {
                get { return this.year; }
                set { year = value; }
            }

            public int Month
            {
                get { return this.month; }
                set
                {
                    if (value <= 0 || value > 12)
                    {
                        throw new IndexOutOfRangeException();
                    }
                    else
                    {
                        month = value;
                    }
                }
            }             
            public int DayOfMonth
            {
                get { return this.dayOfMonth; }
                set
                {
                    
                    if (value <= 0 || value > 31)
                    {
                        throw new IndexOutOfRangeException();
                    }
                    else
                    {
                        dayOfMonth = value;
                    }
                }
            }

            

            public Date(int day, int month, int year)
            {
                this.month = month;
                this.dayOfMonth = day;
                this.year = year;
            }

            public Date(int day, int month, int year, int hours, int minutes, int seconds)
            {
                this.hours = hours;
                this.minutes = minutes;
                this.seconds = seconds;
                this.dayOfMonth = day;
                this.month = month;
                this.year = year;
            }
        }
        public override string ToString()
        {
            return base.ToString();
        }
        static DateTime Now() 
        {
            return DateTime.Now;
        }

        static void Main()
        {
            Date userSubDate = new Date(21, 10, 2014, 21, 40, 59);
            Console.WriteLine("{0:hh}{1:mm}{2:ss}{3:dd}{4:MM}{5:YY}", 
                userSubDate.Hours, userSubDate.Minutes, userSubDate.Seconds, 
                userSubDate.DayOfMonth, userSubDate.Year);
        }
    }
}
