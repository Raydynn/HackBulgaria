using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.BubbleSort
{
    class MyIntSelectionSort : IComparer<int>
    {
        public static List<int> SelectionSort(this List<int> list)
        {
            int lowestNum = 0;
            int lowestNumIndex = 0;

            for (int i = 0; i < list.Count; i++)
            {
                int temp = list[i];
                list[i] = list[lowestNumIndex];
                list[lowestNumIndex] = temp;
                lowestNum = list[i];

                for (int j = i; j < list.Count; j++)
                {
                    if (list[j] < lowestNum)
                    {
                        lowestNum = list[j];
                        lowestNumIndex = j;
                    }
                }
            }
            return list;
        }
    }
}
