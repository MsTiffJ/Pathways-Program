/* 
Program description: This program outputs the list of children's names in order using Methods

Programmer: Tiffany Jackson
Last update: July 20, 2023

Requirements:
(1) Create a list of the children's names
(2) Sort the children from oldest to youngest


Algorithm:
(1) Establish the number of children
(2) Establish the last name of the children
(3) Establish the first name of the children
(4) Output the full name of the children in order from oldest to youngest
(5) Establish cousins' names
(6) Output cousins' names
*/

using System;

namespace childList
{
    class Program
    {
        // (1) Establish the number of children
static void MyMethod(string child1, string child2, string child3, string child4, string child5)
{
        // (2) Establish the last name of the children
 Console.WriteLine( "The oldest child is " + child1 + " Jacobs.");
 Console.WriteLine( "The second oldest child is " + child2 + " Jacobs.");
 Console.WriteLine( "The middle child is " + child3 + " Jacobs.");
 Console.WriteLine( "The second youngest child is " + child4 + " Jacobs.");
 Console.WriteLine( "The youngest child is " + child5 + " Jacobs.");
}
static void MyMethod(string childname)
{
Console.WriteLine(childname + " Jacobs.");}
        
        
static void Main(string[] args)
            {
        // (3) Establish the first name of the children
        // (4) Output the full name of the children in order from oldest to youngest
        MyMethod("Oldest","Second Oldest","Middle","Second Youngest","Youngest");
        MyMethod (child5: "Youngest", child2: "Second Oldest", child1: "Oldest", child3: "Middle", child4: "Second Youngest");

        // (5) Establish cousins' names
        // (6) Output cousins' names
Console.WriteLine("");
Console.WriteLine("Their cousins' names are:");

MyMethod("Bob");
MyMethod("Jenny");
MyMethod("Tim");
MyMethod("Susan");
       

        }
    }
}

