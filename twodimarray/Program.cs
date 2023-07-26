/* 
Program description: This program calculates the two dimensional array to find minimum maximum and average

Programmer: Tiffany Jackson
Last update: July 24, 2023

Requirements:
(1) Build a two dimensional array
(2) Create my own method
(3) Array needs to have a for loop
(4) Find the minimum
(5) Find the maximum
(6) Find the average

Algorithm:
(1) Establish a foreach loop for each item in the array
    1a. If the item is equal to the integar
    2a. Return the index of the item found 

(2) Return -1

(3) Set the output to -1
*/
using System;

namespace twodimarray
{
    class Program
    {
        public static int myArrayMax(int[,] arx2d)
        {
            int max = arx2d[0, 0];
            for (int i = 0; i < arx2d.GetLength(0); i++)
            {
                for (int j = 0; j < arx2d.GetLength(1); j++)

                {
                    if(arx2d[i,j] > max)
                    {
                        max = arx2d[i, j];
                    }
                }
            }
            return max;
        }
        
        public static int myArrayMin(int[,] arx2d)
        {
            int min = arx2d[0, 0];
            for (int i = 0; i < arx2d.GetLength(0); i++)
            {
                for (int j = 0; j < arx2d.GetLength(1); j++)

                {
                    if(arx2d[i,j] < min)
                    {
                        min = arx2d[i, j];
                    }
                }
            }
            return min;
        }
         public static double myArrayAvg(int[,]arx2d)
       {
           double total=0.0;
           double average=0.0;
            for (int i = 0; i < arx2d.GetLength(0); i++)
            {
                for (int j = 0; j < arx2d.GetLength(1); j++)

                {
                    total +=(arx2d[i,j] +0.0); 
                }
            }
            average =total/arx2d.Length;
            return average;
            
       }
        public static void Main()
        {
            int[,] arx2d = { { 100, 30, 90, 20 }, { 80, 70, 40, 50 }, {90, 20, 80, 80} };

            int result = myArrayMax(arx2d);
            Console.WriteLine(result);

            result= myArrayMin(arx2d);
            Console.WriteLine(result);

            double result2= myArrayAvg(arx2d);
            Console.WriteLine(result2);

         
            for (int student = 0; student < arx2d.GetLength(1); student++)
            {
                double total=0.0;
                double average=0.0;
                for (int assignment = 0; assignment < arx2d.GetLength(0); assignment++)

                {
                    total +=(arx2d[assignment,student] +0.0); 
                }
            
                average =total/arx2d.GetLength(0);
                Console.WriteLine("The average for student " + student + " is " + average);
            }
        }
    }
}


