using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Factorial
{
    class Program
    {
        public int Fact(int n)
        {
            if (n < 1)
            {
                return 1;
            }
            else
            {
                return n * Fact(n - 1);
            }
        }

        static void Main(string[] args)
        {
            string factorial = Console.ReadLine();
            int factorialNumber = int.Parse(factorial);
            int factorialSum = factorialNumber;

            for (int i = factorialNumber; i > 1; i--)
            {
                if (i-1==0)
                {
                    factorialSum = factorialSum * 1;
                }
                else
                {
                    factorialSum = factorialSum * (i - 1);
                }
            }
            Console.WriteLine(factorialSum);
        }

    }
}
