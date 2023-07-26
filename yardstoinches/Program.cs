/* 
Program description: This program obtains a number of yards from the user, converts the yards to inches,
and provides the equivalent number of inches to the user

Programmer: Tiffany Jackson
Last update: July 17, 2023

Requirements:
(1) The number of yards will be an integer from user
(2) The number of feet will be calculated by yards*3
(3) The number of inches will be calculated by the feet*12
(4) The number of inches will be an integer

Algorithm:
(1) Prompt the user for the number of yards
(2) Obtain the number of yards from the user
(3) Calculate the number of feet by yards*3
(4) Calculate the number of inches by feet*12
(5) Output the number of inches
*/

using System;

namespace yardstoinches
{
  class Program
  {
    static void Main(string[] args)
    {
int numberofyards = 0;

do
{
      Console.WriteLine("Enter number of yards");   

      // (2) Obtain the number of yards from the user
      
    numberofyards=Convert.ToInt32(Console.ReadLine());

if (numberofyards < 1)

{
  Console.WriteLine ("Please enter a valid number");
  
}
}
while (numberofyards < 1); 

      // (3) Calculate the number of feet by yards*3

      int numberoffeet=numberofyards*3;

      // (4) Calculate the number of inches by feet*12

      int numberofinches=numberoffeet*12;

      // (5) Output the number of inches

      Console.WriteLine("The number of yards is " + numberofyards); 
      Console.WriteLine("The number of feet is " + numberoffeet);  
      Console.WriteLine("The number of inches equals " + numberofinches); 
      
    }
  }
}