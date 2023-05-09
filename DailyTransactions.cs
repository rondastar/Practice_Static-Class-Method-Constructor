using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Practice_Static_Class_Method_Constructor
{
    internal class DailyTransactions
    {
        public static List<Transaction> _transactions;

        static DailyTransactions()
        {
            _transactions = new List<Transaction>();
        }

        public static void AddTransaction(Transaction transaction)
        {
            _transactions.Add(transaction);
        }

        public static double CalculateTotal()
        {
            // calculate subtotal
            double subtotal = 0;
            foreach (Transaction transaction in _transactions)
            {
                subtotal += transaction.Amount;
            }
            // calculate taxes
            double taxesCharged = subtotal * BusinessInfo._taxAmount;
            // add subtotal and taxes to calculate total
            double total = taxesCharged + subtotal;
            return total;
        }

        public static void DisplayAllInfo()
        {
            // Display transaction info
            foreach (Transaction transaction in _transactions)
            {
                Console.WriteLine(transaction.ToString());
            }
            // display tax rate as percentage
            Console.WriteLine($"Tax Rate: {BusinessInfo._taxAmount * 10.0}%");
            // calculate total
            double total = CalculateTotal();
            Console.WriteLine($"Total: {total.ToString("c")}");
        }
    }
}
