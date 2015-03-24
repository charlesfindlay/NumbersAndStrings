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
            //int index = 10000;

            //int oneThird = index / 3;

            //int remainder = index % 3;

            var increment = 1.0 / 3.0; //0.125;
            var total = 0.0;

            for (int i = 0; i < 100000; i++)
            {
                total = increment * (double)i;
                Console.WriteLine(total);
                if (i % 20 == 0)
                {
                    Console.WriteLine("Pausing...");
                    //Console.ReadLine();
                }
            }

            Console.ReadLine();
        }
    }
}
