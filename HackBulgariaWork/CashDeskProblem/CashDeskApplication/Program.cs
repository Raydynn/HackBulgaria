using CashDesk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashDeskApplication
{
    class Program
    {
        static void Main()
        {
            var a = new Bill(10);
            var b = new Bill(5);
            var c = new Bill(10);
            Console.WriteLine(a);
            Console.WriteLine(a.Equals(c));
            Console.WriteLine(((int)a));

            List<Bill> bills = new List<Bill> { new Bill(10), new Bill(20), new Bill(50), new Bill(100) };
            BatchOfBills batch = new BatchOfBills(bills);

            foreach (var bill in batch)
            {
                Console.WriteLine(bill);
            }
            
            Console.WriteLine(batch.Total() + " dorrah!");
            Console.WriteLine(batch);
        }
    }
}
