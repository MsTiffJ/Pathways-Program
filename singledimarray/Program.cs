/* 
Program description: This program calculates the single dimensional array to find minimum maximum and average

Programmer: Tiffany Jackson
Last update: July 24, 2023

Requirements:
(1) Build a single dimensional array
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

namespace singledimarray
{
    class Program
    {
        public static int myArrayMax(int[]arx)
        {
            int max=arx[0];
            for (int i =1; i<arx.Length; i++)
        
            {
                if(arx[i] > max)
                {
                    max = arx[i];
                }

            }
            return max;
        }
        public static int myArrayMin(int[]arx)
        {
            int min=arx[0];
            for (int i =1; i<arx.Length; i++)
        
            {
                if(arx[i] < min)
                {
                    min = arx[i];
                }

            }
            return min;
        }   
         public static double myArrayAvg(int[]arx)
        {
            double total=arx[0];
            double average=0.0;
            for (int i =1; i<arx.Length; i++)
        
            {
                
                total +=(arx[i] +0.0); 
                average =total/arx.Length;

            }
            return average;
        } 
        public static void Main()
        {
        int[] arx2 = {1, 3, 9, 2, 8, 7, 4};

        int result= myArrayMax(arx2);
        Console.WriteLine(result);
        
        result= myArrayMin(arx2);
        Console.WriteLine(result);

        double result2= myArrayAvg(arx2);
        Console.WriteLine(result2);
        }
    }
}
