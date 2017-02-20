using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashDesk
{
    public class Bill
    {
        private int bill;
        public int Bills 
        {
            get { return bill; }
            set { bill = value; }
        }

        public Bill(int value) 
        {
            this.bill = value;
        }

        public override string ToString()
        {
            var stringValueBill = "A " + bill + "$ bill";
            return stringValueBill;
        }
        public override int GetHashCode()
        {
            return (int)bill;
        }
        public override bool Equals(object obj)
        {
            if (obj is Bill &&  obj != null)
            {
                return this.bill == ((Bill)obj).bill;
            }
            else
            {
                return false;
            }
        }
        public static bool operator ==(Bill b1, Bill b2)
        {
            return b1.Equals(b2);
        }
        public static bool operator !=(Bill b1, Bill b2)
        {
            return !(b1==b2);
        }

        public static explicit operator int(Bill bill5)
        {
            return bill5.bill;
        }
    }
}
