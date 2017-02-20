using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.JoiningStrings
{
    class Program
    {
        public static string JoinStrings(string separator, params string[] strings) 
        {
            string joinedStr = String.Join(separator, strings);

            return joinedStr;
        }

        static void Main()
        {
            string sep = ",";
            string[] parameter = new string[3];
            parameter[1] = "I";
            parameter[2] = "I";
            parameter[3] = "I";

            Console.WriteLine(JoinStrings(sep, parameter));
        }
    }
}
