using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Friday13
{
    class Program
    {
        static void UnfortunateFridays(int startYear, int endYear) 
        {
            DateTime startDate = new DateTime(startYear, 01, 01);
            DateTime endDate = new DateTime(endYear, 12, 31);
            DateTime currentDate = new DateTime(startYear, 01, 01);

            while (currentDate < endDate)
            {
                if (currentDate.DayOfWeek == DayOfWeek.Friday &&  currentDate.Day == 13)
                {
                    Console.WriteLine(currentDate);
                }
                currentDate = currentDate.AddDays(1);
            }
        }
        static void Main()
        {
            UnfortunateFridays(2012, 2014);
        }
    }
}
