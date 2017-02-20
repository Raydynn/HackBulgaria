using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashDesk
{
    class CashDeskLibrary
    {
        private Dictionary<Bill, int> cashDesk;

        public Dictionary<Bill, int> CashDesk
        {
            get { return cashDesk; }
            set { cashDesk = value; }
        }
        public CashDeskLibrary TakeMoney(Bill money)
        {
            if (cashDesk.ContainsKey(money))
            {
                cashDesk[money] += 1;
            }
            else
            {
                cashDesk.Add(new KeyValuePair<int, string>);
            }
        }
        public CashDeskLibrary TakeBatchOfBills(BatchOfBills money)
        {

        }
    }
}
