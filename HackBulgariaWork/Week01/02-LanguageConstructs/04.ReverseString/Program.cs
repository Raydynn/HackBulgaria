using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.ReverseString
{
    class Program
    {
        public static string ReverseMe(string original)
        {
            StringBuilder reverseStr = new StringBuilder();

            for (int i = original.Length-1; i >= 0; i--)
            {
                reverseStr.Append(original[i]);
            }

            string reversedString = reverseStr.ToString();
            return reversedString;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(ReverseMe("Prase"));
        }
    }
}
