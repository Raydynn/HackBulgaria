using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Hacker1337
{
    class Program
    {
        static void HackerTime() 
        {    
            DateTime currentDate = DateTime.Now;
            int currentYear = currentDate.Year;
            DateTime hackDate = new DateTime(currentYear , 12, 21, 13, 37, 0);

            if (currentDate > hackDate)
            {
                hackDate = hackDate.AddYears(1);
                    
            }

            TimeSpan timeForHackin = hackDate - currentDate;

            Console.WriteLine("{0:dd\\:hh\\:mm}", timeForHackin);
        }
        static void Main()
        {
            HackerTime();
        }
    }
}
