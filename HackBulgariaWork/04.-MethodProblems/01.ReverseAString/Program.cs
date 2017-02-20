using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ReverseAString
{
    class Program
    {
        void ReverseList(List<int> list) 
        {
            List<int> ogList = new List<int>(list);
            ogList.Reverse();
        }
        static void Main()
        {
        }
    }
}
