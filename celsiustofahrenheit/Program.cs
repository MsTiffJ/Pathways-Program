/* 
Program description: This program obtains the temperature in celsius and converts it to fahrenheit

Programmer: Tiffany Jackson
Last update: July 17, 2023

Requirements:
(1) The temperature in celsius will be an integer from user
(2) The temperature in fahrenheit will be calculated by celsius*9/5+32
(3) The temperature will be a floating decimal value

Algorithm:
(1) Prompt the user for the celsius temperature
(2) Obtain the temperature from the user
(3) Calculate the fahrenheit temperature by celsius*9/5+32
(4) Output the fahrenheit temperature
*/
using System;

namespace celsiustofahrenheit
{
  class Program
  {
    static void Main(string[] args)
    {
      // (1) Prompt the user for the celsius temperature
      Console.WriteLine("Enter the degrees in celsius");  

      // (2) Obtain the temperature from the user
      
      int celsius=Convert.ToInt16(Console.ReadLine());

      // (3) Calculate the fahrenheit temperature by celsius*9/5+32

      float fahrenheit=(float)(celsius * 9.0/5.0 + 32.0);

do
{
    Console.WriteLine("Enter higher temperature");
    celsius=Convert.ToInt16(Console.ReadLine());
    fahrenheit=(float)(celsius * 9.0/5.0 + 32.0);

}
while (fahrenheit < 32);

      // (4) Output the fahrenheit temperature

      Console.WriteLine("The celsius temperature is " + celsius); 
      Console.WriteLine("The fahrenheit temperature is " + fahrenheit);  
       

    }
  }
}