using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.DateSums
{
    class Program
    {
        static void PrintDatesWithGivenSum(int year, int sum) 
        {
            int currentYear = year;
            int sumOfDates = 0;
            DateTime startDate = new DateTime(year, 01, 01);
            DateTime endDate = new DateTime(year, 12, 31);
            int yearSum = 0;

            while (currentYear != 0)
            {
                yearSum += currentYear % 10;
                currentYear = currentYear / 10;
            }

            for (DateTime current = startDate; current <= endDate; current = current.AddDays(1))
            {
                int currentDaySum = (current.Day / 10) + (current.Day % 10);
                int currentMonthSum = (current.Month / 10) + (current.Month % 10);
                sumOfDates = yearSum + currentDaySum + currentMonthSum;
                if (sumOfDates == sum)
                {
                    Console.WriteLine("{0:dd MM yyyy}", current);
                }
                sumOfDates = 0;
            }
        }


        static void Main()
        {
            PrintDatesWithGivenSum(2013, 8);
        }
    }
}
