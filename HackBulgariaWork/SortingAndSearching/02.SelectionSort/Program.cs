using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01.BubbleSort;

namespace _02.SelectionSort
{
    class Program
    {
        public static List<int> BubbleSort(this List<int> list)
        {
            for (int i = 1; i < list.Count; i++)
            {
                if (list[i - 1] > list[i])
                {
                    int temp = list[i - 1];
                    list[i - 1] = list[i];
                    list[i] = temp;
                }
                else
                {
                    continue;
                }
            }
            return list;
        }
        static void Main(string[] args)
        {
        }
    }
}
