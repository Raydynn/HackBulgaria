using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Number_List
{
    class Program
    {
        public static List<int> NumberToList(int n)
        {
            string numbers = n.ToString();
            List<int> numbersList = new List<int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbersList.Add(int.Parse(numbers[i].ToString()));
            }
            return numbersList;
        }

        public static int ListToNumber(string digits)
        {
            string strNum = "";
            

            for (int i = 0; i < digits.Length; i++)
            {
                strNum = strNum + digits[i];
            }

            int number = Int32.Parse(strNum);
            return number;
        }


        static void Main()
        {
            List<int> res = NumberToList(856);

            foreach (var number in res)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine();
            Console.WriteLine(ListToNumber("125315"));
        }
    }
}
