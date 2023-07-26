/* 
Program description: This program calculates power for the end user 

Programmer: Tiffany Jackson
Last update: July 20, 2023

Requirements:
(1) Base number must be greater than or equal to 1
(2) Exponent number must be greater than or equal to 1
(3) Program must restart if user answers yes to continuing

Algorithm:
(1) Prompt the user to provide a base number
(2) Prompt the user to provide an exponent number
(3) Print out value of base taken to exponent power
(4) Prompt the user to provide a yes/no for continuation, loop from (1)
*/
using System;

namespace powercalculation
{
    class Program
    {
      static double CalculatePower(int baseNo, int power)
      {
          return Math.Pow(baseNo, power);


      }

        static void Main(string[] args)
        {
            int basenumber = 0;
            int exponent = 0;
            double powResult = 0;
            string? PowCalc;

            do
            {
                do
                {
                    // (1) Prompt user to enter a base number 
                    Console.WriteLine("Please enter a base number");

                    // (2) Obtain base number
                    basenumber = Convert.ToInt16(Console.ReadLine());

                    if (basenumber < 1)
                    {
                        Console.WriteLine("Please enter base number of 1 or higher");
                    }
                }
                while (basenumber < 1);

                do
                {
                    // (1) Prompt user to enter an exponent 
                    Console.WriteLine("Please enter an exponent");

                    // (2) Obtain exponent
                    exponent = Convert.ToInt16(Console.ReadLine());

                    if (exponent < 1)
                    {
                        Console.WriteLine("Please enter exponent of 1 or higher");
                    }
                }
                while (exponent < 1);

                //powResult = Math.Pow(basenumber, exponent);

                // (3) Print out value of base taken to exponent power

                Console.WriteLine("Your total equals " + CalculatePower(basenumber, exponent));

                Console.WriteLine("");
                Console.WriteLine("Do you want to continue, please enter y/n?");

                PowCalc = Console.ReadLine();
            }
            while (PowCalc == "y");

        }
    }
}


