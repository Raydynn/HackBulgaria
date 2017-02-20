using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lucas_Series
{
    class Program
    {
        
        public static int NthLucas(int n)
        {
            int currentN = 0;
            int temp1 = 0;
            int temp2 = 0;
            for (int i = 0; i <= n; i++)
            {
                if (i == 0)
                {
                    currentN = 2;
                    temp1 = 2;
                }
                else if (i == 1)
                {
                    currentN = 1;
                    temp2 = 1;
                }
                else
                {
                    currentN = temp2 + temp1;
                    temp1 = temp2;
                    temp2 = currentN;
                }
            }
            return currentN;
        }

        public static List<int> FirstNLucas(int n)
        {
            List<int> numbersList = new List<int>();
            int currentN = 0;

            for (int i = 0; i <= n; i++)
            {
                if (i == 0)
                {
                    currentN = 2;
                    numbersList.Add(currentN);
                }
                else if (i == 1)
                {
                    currentN = 1;
                    numbersList.Add(currentN);
                }
                else
                {
                    currentN = (numbersList [numbersList.Count - 1]) + (numbersList[numbersList.Count - 2]);
                    numbersList.Add(currentN);               
                }
            }
            return numbersList;
        }
        static void Main(string[] args)
        {            
            Console.WriteLine(NthLucas(120));
        }
    }
}
