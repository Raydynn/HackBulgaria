using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace SumAllNumbersInString
{
    class Program
    {
        public static int SumOfNumbersInString(string n)
        {
            string numbersStr = n;
            int sum = 0;
            string[] numbers = Regex.Split(numbersStr, "[A-Za-z]+");

            for (int i = 0; i < numbers.Length; i++)
            {
                int temp = Int32.Parse(numbers[i]);
                sum += temp;
            }

            return sum;
        }

        static void Main()
        {
            Console.WriteLine(SumOfNumbersInString("1abc33xyz22"));
        }
    }
}
