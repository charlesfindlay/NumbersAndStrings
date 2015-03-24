using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersAndStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            // Accumulation Problem

            decimal deposit = 35.00M;

            Console.WriteLine("If you save " + deposit + " every day, you will have:");
            Console.WriteLine("{0:C} after 1 year.", (deposit * 365).ToString());
            Console.WriteLine((deposit * 365 * 2) + " after 2 years.");
            Console.WriteLine((deposit * 365 * 5) + " after 5 years.");
            Console.WriteLine((deposit * 365 * 10) + " after 10 years.");

            Console.ReadLine();

        }
    }
}
