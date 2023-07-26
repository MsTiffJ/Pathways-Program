/* 
Program description: This program obtains the temperature in celsius and converts it to fahrenheit using methods

Programmer: Tiffany Jackson
Last update: July 20, 2023

Requirements:
(1) The beginning temperature in celsius must be less than the ending temperature in celsius
(2) The temperature in fahrenheit must be calculated using celsius *9/5+32
(3) The temperature in fahrenheit will be calculated starting with the beginning celsius and will increment
    until the ending celsius temperature is calculated 
(4) The temperature will be a floating decimal value
(5) The calculation must continue until the user quits

Algorithm:
(1) Prompt the user for the beginning celsius temperature
(2) Obtain beginning celsius temperature from user
(3) Prompt the user for the ending celsius temperature
(4) Obtain the ending celsius temperatures from the user
(5) Calculate the fahrenheit temperature by celsius*9/5+32
(6) Perform calculation using the beginning celsius temperature and continue until ending celsius temperature is
    used for calculation
(7) Output all fahrenheit temperature results
(8) Prompt the user to continue or quit
(9) End program if user decides to quit
(10) Repeat 1-9 if user decides to continue
*/
using System;

namespace celstofahrenmethod
{
    class Program
    {
        static double cTof(int celsius)
        {
            // (5) Calculate the fahrenheit temperature by celsius*9/5+32
            double fahrenheit = (double)(celsius * 9.0 / 5.0 + 32.0);
            return fahrenheit;
        }
        static void Main(string[] args)
        {
            int beginCelsius = 0;
            int endCelsius = 0;
            string? ContinueProgram;

            do
            {
                do
                {
                    // (1) Prompt the user for the beginning celsius temperature
                    Console.WriteLine("Enter the beginning celsius temperature");

                    // (2) Obtain the temperature from the user
                    beginCelsius = Convert.ToInt16(Console.ReadLine());

                    if (beginCelsius < 1)
                    {
                        Console.WriteLine("Please enter a beginning temperature of 1 or higher");
                    }

                }
                while (beginCelsius < 1);

                do
                {
                    do
                    {
                        // (3) Prompt the user for the ending celsius temperature
                        Console.WriteLine("Enter the ending celsius temperature");

                        // (4) Obtain the ending celsius temperature from the user
                        endCelsius = Convert.ToInt16(Console.ReadLine());

                        if (endCelsius < 1)
                        {
                            Console.WriteLine("Please enter an ending temperature of 1 or higher");
                        }

                    }
                    while (endCelsius < 1);

                    if (endCelsius <= beginCelsius)
                    {
                        Console.WriteLine("Please enter an ending temperature higher than the beginning temperature");
                    }
                }

                while (endCelsius <= beginCelsius);

                for (int temp = beginCelsius; temp <= endCelsius; temp++)

                {
                    Console.WriteLine(temp + " celsius is " + cTof(temp) + " fahrenheit");
                }

                {
                    Console.WriteLine("Do you want to continue, please enter y/n?");

                    ContinueProgram = Console.ReadLine();
                }
            }
                while (ContinueProgram == "y") ;
                
        }
    }
}

