using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Static_Class_Method_Constructor
{
    internal class Transaction
    {
        DateTime _now = DateTime.Now;
        string _name;
        double _amount;

        public Transaction(string name, double amount)
        {
            _name = name;
            _amount = amount;
        }

        public DateTime Now { get => _now; }
        public string Name { get => _name; }
        public double Amount { get => _amount; }

        public override string ToString()
        {
            // displays product name, time of transaction, and amount
            return $"{Name} - {Now.ToShortTimeString()} - {Amount.ToString("c")}";
        }
    }
}
