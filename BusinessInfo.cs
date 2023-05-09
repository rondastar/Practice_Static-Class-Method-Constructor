using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Static_Class_Method_Constructor
{
    internal class BusinessInfo
    {
        public static string _businessName;
        public static double _taxAmount;

        static BusinessInfo()
        {
            _businessName = "Anna's Bananas";
            _taxAmount = .114;
        }
    }
}
