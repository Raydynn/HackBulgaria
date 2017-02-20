using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.IncreasingAndDecreasingSequences
{
    class Program
    {
        public static bool IsIncreasing(int[] sequence)
        {
            int a;
            int b;
            bool increasing = true;
            
            for (int i = 0; i < sequence.Length-1; i++)
            {
                a = sequence[i];
                b = sequence[i + 1];
                if (a < b)
                {
                    continue;
                }
                else
                {
                    increasing = false;
                    break;
                }
            }
            return increasing;
        }

        public static bool IsDecreasing(int[] sequence)
        {
            int a;
            int b;
            bool decreasing = true;

            for (int i = 0; i < sequence.Length - 1; i++)
            {
                a = sequence[i];
                b = sequence[i + 1];
                if (a > b)
                {
                    continue;
                }
                else
                {
                    decreasing = false;
                    break;
                }
            }
            return decreasing;
        }

        static void Main(string[] args)
        {
            int[] incNumbers = new int[5]{ 1, 3, 2, 7, 6 };
            Console.WriteLine(IsIncreasing(incNumbers));

            int[] decNumbers = new int[5] { 9, 8, 7, 5, 9 };
            Console.WriteLine(IsDecreasing(decNumbers));
        }
    }
}
