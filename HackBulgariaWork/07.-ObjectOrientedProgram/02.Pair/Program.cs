using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.PairNamespace
{
    class Program
    {
        public class Pair
        {
            private object x;
            private object y;

            public object Object1 { get; }
            public object Object2 { get; }

            public override string ToString()
            {
                return "Object one = " + x + ". Object two = " + y + ".";
            }
            public Pair(object obj1, object obj2) 
            {
                this.x = obj1;
                this.y = obj2;
            }
            public override bool Equals(object obj)
            {
                if (obj is Pair)
                {
                    Pair pObj = (Pair)obj;
                    return this.x == pObj.x && this.y == pObj.y;
                }
                return false;
            }
            public static bool operator ==(Pair p1, Pair p2)
            {
                return p1.Equals(p2);
            }
        }
        static void Main()
        {
            
        }
    }
}
