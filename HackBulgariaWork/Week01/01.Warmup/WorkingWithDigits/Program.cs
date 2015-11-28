using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            string digit = Console.ReadLine();
            int countDigits = digit.Length;
            int digitSum = 0;
            int factorialSum = 0;

            for (int i = 0; i < countDigits; i++)
            {
                int currentDigit = Int32.Parse(digit[i].ToString());
                digitSum += currentDigit;
            }

            for (int i = 0; i < digit.Length; i++)
            {
                int currentDigit = Int32.Parse(digit[i].ToString());
                int factorialNumber = currentDigit;
                for (int y = currentDigit; y > 1; y--)
                {
                    if (y-1 == 0)
                    {
                        factorialNumber = factorialNumber * 1;
                    }
                    else
                    {
                        factorialNumber = factorialNumber * (y - 1);
                    }
                }
                factorialSum += factorialNumber;
            }

            Console.WriteLine(countDigits);
            Console.WriteLine(digitSum);
            Console.WriteLine(factorialSum);
        }
    }
}
