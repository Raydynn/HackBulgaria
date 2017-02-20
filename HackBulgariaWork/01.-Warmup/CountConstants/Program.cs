using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountConstants
{
    class Program
    {
        static void Main(string[] args)
        {
            string constants = Console.ReadLine();
            string lowerCaseContsants = constants.ToLower();
            int constantsCounter = 0;

            for (int i = 0; i < lowerCaseContsants.Length; i++)
            {
                if (lowerCaseContsants[i] == 'b' || lowerCaseContsants[i] == 'c' || lowerCaseContsants[i] == 'd' ||
                     lowerCaseContsants[i] == 'f' || lowerCaseContsants[i] == 'g' || lowerCaseContsants[i] == 'h' ||
                     lowerCaseContsants[i] == 'j' || lowerCaseContsants[i] == 'k' || lowerCaseContsants[i] == 'l' ||
                     lowerCaseContsants[i] == 'm' || lowerCaseContsants[i] == 'n' || lowerCaseContsants[i] == 'p' ||
                     lowerCaseContsants[i] == 'q' || lowerCaseContsants[i] == 'r' || lowerCaseContsants[i] == 's' ||
                     lowerCaseContsants[i] == 't' || lowerCaseContsants[i] == 'v' || lowerCaseContsants[i] == 'w' ||
                     lowerCaseContsants[i] == 'x' || lowerCaseContsants[i] == 'z')
                {
                    constantsCounter++;
                }
                else
                {
                    continue;
                }                
            }
            Console.WriteLine(constantsCounter);
        }
    }
}
