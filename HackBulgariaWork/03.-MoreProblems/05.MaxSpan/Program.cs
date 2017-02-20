using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.MaxSpan
{
    class Program
    {
        public static int MaxSpan(List<int> numbers) 
        {
            int counter = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                for (int j = numbers[i]; j < numbers.Count; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        if (j - i >= counter)
                        {
                            counter = (j - i) + 1;
                        }
                    }
                }
            }

            return counter;
        }
        static void Main()
        {
            List<int> example1 = new List<int>(new int[] { 1, 2, 1, 1, 3 });
            List<int> example2 = new List<int>(new int[] { 1, 4, 2, 1, 4, 1, 4 });
            List<int> example3 = new List<int>(new int[] { 1, 4, 2, 1, 4, 4, 4 });
            Console.WriteLine(MaxSpan(example1));
            Console.WriteLine(MaxSpan(example2));
            Console.WriteLine(MaxSpan(example3));
        }
    }
}
