using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibbonacciNumbers
{
    class Program
    {
        public static int Fibonacci(int n)
        {
            int a = 0;
            int b = 1;
            for (int i = 0; i < n; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }

        static void Main()
        {
            string numbers = Console.ReadLine();
            int numbersCount = Int32.Parse(numbers);
            string fibNumber = "";
            for (int i = 1; i < numbersCount + 1; i++)
            {
                fibNumber = fibNumber + Fibonacci(i).ToString();
            }
            Console.WriteLine(fibNumber);
        }
    }
}
