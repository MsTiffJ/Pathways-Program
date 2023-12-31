﻿using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {

            // Declare variables
            bool userChoice;
            string userChoiceString;
            const int arraySize = 12;
            string[] nameArray = new string[arraySize];
            string fileName = "names.txt";

            // Repeat main loop
            do
            {

                // TODO: Get a valid input
                do
                {
                    //  Initialize variables

                    userChoice = false;

                    //  TODO: Provide the user a menu of options

                    Console.WriteLine("What's your pleasure? ");
                    Console.WriteLine("L: Load the data file into an array.");
                    Console.WriteLine("S: Save the array to the data file.");
                    Console.WriteLine("C: Add a name to the array.");
                    Console.WriteLine("R: Read a name from the array.");
                    Console.WriteLine("U: Update a name in the array.");
                    Console.WriteLine("D: Delete a name from the array.");
                    Console.WriteLine("Q: Quit the program.");

                    //  TODO: Get a user option (valid means its on the menu)

                    userChoiceString = Console.ReadLine();

                    userChoice = (userChoiceString == "L" || userChoiceString == "l" ||
                                userChoiceString == "S" || userChoiceString == "s" ||
                                userChoiceString == "C" || userChoiceString == "c" ||
                                userChoiceString == "R" || userChoiceString == "r" ||
                                userChoiceString == "U" || userChoiceString == "u" ||
                                userChoiceString == "D" || userChoiceString == "d" ||
                                userChoiceString == "Q" || userChoiceString == "q");

                    if (!userChoice)
                    {
                        Console.WriteLine("Please enter a valid option.");
                    }

                } while (!userChoice);

                //  TODO: If the option is L or l then load the text file (names.txt) into the array of strings (nameArray)

                if (userChoiceString == "L" || userChoiceString == "l")
                {
                    Console.WriteLine("In the L/l area");

                    int index = 0;  // index for my array
                    using (StreamReader sr = File.OpenText(fileName))
                    {
                        string s = "";
                        Console.WriteLine(" Here is the content of the file names.txt : ");
                        while ((s = sr.ReadLine()) != null)
                        {
                            Console.WriteLine(s);
                            nameArray[index] = s;
                            index = index + 1;
                        }
                        Console.WriteLine("");
                    }
                }

                //  TODO: Else if the option is an S or s then store the array of strings into the text file

                else if (userChoiceString == "S" || userChoiceString == "s")
                {
                    Console.WriteLine("In the S/s area");
                

                using (StreamWriter fileStr = File.CreateText(fileName))
                {
                    for (int i=0; i < nameArray.Length; i++)
                     {

                        fileStr.WriteLine(nameArray[i]);

                     } 
                    
                    Console.WriteLine("Your document has been saved as names.txt. ");
                }
                }
                //  TODO: Else if the option is a C or c then add a name to the array (if there's room)

                else if (userChoiceString == "C" || userChoiceString == "c")
                {
                    bool found = false;
                    Console.WriteLine("In the C/c area");
                    for (int index = 0; index < arraySize; index++)
                    {
                        if ((nameArray[index]) != "")
                        {
                            //Console.WriteLine(nameArray[index]);
                        }
                        else
                        {
                            if (found == false)
                            {
                                Console.WriteLine("Index " + index + " is available.");
                                Console.WriteLine("Please enter a name ");
                                string name = Console.ReadLine();
                                nameArray[index] = name;
                                found = true;
                            }
                        }
                    }
                    if (found == false)
                        Console.WriteLine("There is no room for any more names. ");

                }

                //  TODO: Else if the option is an R or r then print the array

                else if (userChoiceString == "R" || userChoiceString == "r")
                {
                    Console.WriteLine("In the R/r area");
                    for (int index = 0; index < arraySize; index++)
                    {
                        if ((nameArray[index]) != "")
                            Console.WriteLine(nameArray[index]);
                        else
                            Console.WriteLine("Index " + index + " is available.");
                    }

                }
                //  TODO: Else if the option is a U or u then update a name in the array (if it's there)

                else if (userChoiceString == "U" || userChoiceString == "u")
                {
                    Console.WriteLine("In the U/u area");
                    bool found = false;
                    Console.WriteLine("Enter a name to update");
                    string nameUpdate = Console.ReadLine();
                    string nameInArray;
                    string updateName;
                    for (int index = 0; index < arraySize; index++)
                    {
                        if (found == false)
                        {
                            nameInArray = nameArray[index];

                            if (nameUpdate == nameInArray)
                            {
                                Console.WriteLine("Enter new name");
                                updateName = Console.ReadLine();
                                nameArray[index] = updateName;
                                Console.WriteLine("Name updated");
                                found = true;
                            }

                        }

                    }

                    if (found == false)
                    { Console.WriteLine("Name NOT found"); }
                }

                //  TODO: Else if the option is a D or d then delete the name in the array (if it's there)

                else if (userChoiceString == "D" || userChoiceString == "d")
                {
                    bool found = false;
                    Console.WriteLine("In the D/d area");
                    Console.WriteLine("Enter a name to delete");
                    string? nameDelete = Console.ReadLine();
                    string nameInArray;
                    for (int index = 0; index < arraySize; index++)
                    {
                        if (found == false)
                        {
                            nameInArray = nameArray[index];

                            if (nameDelete == nameInArray)
                            {
                                Console.WriteLine("Name found");
                                nameArray[index] = "";
                                Console.WriteLine("Name deleted");
                                found = true;
                            }

                        }

                    }

                    if (found == false)
                    { Console.WriteLine("Name NOT found"); }
                }
                //  TODO: Else if the option is a Q or q then quit the program

                else
                {
                    Console.WriteLine("Good-bye!");
                }
            } while (!(userChoiceString == "Q") && !(userChoiceString == "q"));
        }  // end main
    }  // end program
}  // end namespace