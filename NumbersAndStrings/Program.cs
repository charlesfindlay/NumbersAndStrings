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
            Console.Write("Enter daily deposit: ");
            decimal deposit = decimal.Parse(Console.ReadLine());
            Console.Write("Enter interest rate: ");
            decimal rate = decimal.Parse(Console.ReadLine());
            Console.Write("Enter years to save: ");
            int years = int.Parse(Console.ReadLine());

            Console.WriteLine("If you save {0:C} every day, you will have:", deposit);

            decimal balance = 0.00M;
            decimal dailyRate = (rate / 100 / 365) + 1;
            for (int days = 0; days <= years * 365; days++)
            {
                balance = balance * dailyRate + deposit;
                if (days % 365 == 0  && days != 0)
                {
                    Console.WriteLine("{0:C} after {1} years.", balance, days / 365);
                }


            }

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

            /*
            
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
            */
            
            
            // Solve the quadratic formula

            Console.WriteLine("Let's solve a quadratic equation! Yipee :)");
            Console.Write("Enter a value for a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter a value for b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Enter a value for c: ");
            double c = double.Parse(Console.ReadLine());

            // parts of equations
            double positive = ((-b + Math.Sqrt(b*b - 4*a*c)) / 2*a);
            double negative = ((-b - Math.Sqrt(b * b - 4 * a * c)) / 2 * a);

            if (double.IsNaN(positive) || double.IsNaN(negative))
            {
                Console.WriteLine("The equation has no solution");

            }
            else
            {
                Console.WriteLine("The answer is {0} and {1}", positive, negative);
            }

            Console.ReadLine();


        }
    }
}
