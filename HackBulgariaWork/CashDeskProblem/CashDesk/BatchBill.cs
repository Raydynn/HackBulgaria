using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashDesk
{
    public class BatchOfBills : IEnumerable
    {
        private List<Bill> batchOfBills;
        private int count;
        public List<Bill> Batch
        {
            get { return batchOfBills; }
            set { batchOfBills = value; }
        }

        public BatchOfBills(List<Bill> billBatch)
        {
            this.batchOfBills = new List<Bill>();
            for (int i = 0; i < billBatch.Count; i++)
            {
                this.Batch.Add(billBatch[i]);
            }
        }

        public int Count
        { 
            get { return count; } 
            set { count = batchOfBills.Count;}
        }

        public int Total()
        {
            int total = 0;
            for (int i = 0; i < batchOfBills.Count; i++)
            {
                total += (int)batchOfBills[i];
            }
            return total;
        }

        public override string ToString()
        {
            var stringValueTotal = batchOfBills.Count + " bills ammasing to a total of " + Total() + " dorrah!" ;
            return stringValueTotal;
        }



        public IEnumerator GetEnumerator()
        {
            return this.batchOfBills.GetEnumerator();
        }
    }
}
