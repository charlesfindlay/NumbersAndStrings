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

            /*
            decimal deposit = 35.00M;

            Console.WriteLine("If you save " + deposit + " every day, you will have:");
            Console.WriteLine("{0:C} after 1 year.", (deposit * 365).ToString());
            Console.WriteLine((deposit * 365 * 2) + " after 2 years.");
            Console.WriteLine((deposit * 365 * 5) + " after 5 years.");
            Console.WriteLine((deposit * 365 * 10) + " after 10 years.");

            Console.ReadLine();
            */
            
            // Land Cost Calculator

            /*
            decimal sqYardCost = 5.0M;
            decimal perimeterCost = 0.75M;
            int length;
            int width;

            Console.WriteLine("Enter the length & width of the land parcel you are buying:");
            Console.Write("Length: ");
            length = int.Parse(Console.ReadLine());
            Console.Write("Width: ");
            width = int.Parse(Console.ReadLine());

            Console.WriteLine();

            decimal landcost = (length * width * sqYardCost) + (((length * 2) + (width * 2)) * perimeterCost);
            Console.WriteLine("The cost of the land you're buying is {0:C}", landcost);

            Console.ReadLine();
             */ 
             

            // Space Exploration


            
            double startSpeed;
            double finalSpeed;
            int boostTime;
            double boostPer;
            int hours;

            Console.Write("Enter spaceship velocity: ");
            startSpeed = int.Parse(Console.ReadLine());
            Console.Write("Enter minutes of boost time: ");
            boostTime = int.Parse(Console.ReadLine());
            Console.Write("Enter boost/coast cycle time in hours: ");
            hours = int.Parse(Console.ReadLine());

            boostPer = Math.Pow(1.05, (boostTime * 60 / 30));

            for (int minutes = 15; minutes <= hours*60; minutes += 15)
            {
                finalSpeed = boostPer * startSpeed;
                Console.WriteLine("After {0} minutes your space ship will be going {1} MPH", minutes, finalSpeed);
                startSpeed = finalSpeed;
            }

            Console.ReadLine();
            

            

        }
    }
}
