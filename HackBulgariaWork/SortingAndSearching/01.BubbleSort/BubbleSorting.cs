using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.BubbleSorting
{
    class MyIntComparer : IComparer<int>
    {
        public static List<int> BubbleSort(this List<int> list)
        {            
            for (int i = 1; i < list.Count; i++)
            {
                if (list[i-1]>list[i])
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
    }
}
