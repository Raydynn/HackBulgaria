using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeIntegers
{
    class Program
    {
        public static bool IsIntPalindrome(int n)
        {
            int number = n;            
            string stringNum = number.ToString();
            int numberSize = stringNum.Length;
            bool isPalindrome = true;

            if (number >= 0 && number < 10)
            {
                return isPalindrome;
            }
            else
            {
                for (int i = 0; i < numberSize / 2; i++)
                {
                    if (stringNum[numberSize - i] == stringNum[i])
                    {
                        continue;
                    }
                    else
                    {
                        isPalindrome = false;
                    }
                }
                return isPalindrome;
            }
        }

        public static int GetLargestPalindrome(int n)
        {
            int number = n;
            int largestPalindrome = 0;

            for (int i = number; i > 0; i--)
            {
                if (IsIntPalindrome(i))
                {
                    largestPalindrome = i;
                    break;
                }
            }
            return largestPalindrome;
        }


        static void Main(string[] args)
        {
        }
    }
}
