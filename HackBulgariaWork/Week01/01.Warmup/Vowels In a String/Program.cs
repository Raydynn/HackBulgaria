using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vowels_In_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string vowels = Console.ReadLine();
            string lowerCaseVowels = vowels.ToLower();
            int vowelsCounter = 0;

            for (int i = 0; i < lowerCaseVowels.Length; i++)
            {
                if (lowerCaseVowels[i] == 'a' || lowerCaseVowels[i] == 'e' || lowerCaseVowels[i] == 'i' ||
                    lowerCaseVowels[i] == 'o' || lowerCaseVowels[i] == 'u' || lowerCaseVowels[i] == 'y')
                {
                    vowelsCounter++;
                }
                else
                {
                    continue;
                }
            }
            Console.WriteLine(vowelsCounter);
        }
    }
}
