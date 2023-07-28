using System;

namespace CRUDRunChallenge
{
    class Program
    {
        static void Main(string[] args)
        {

            // Declare variables
            bool userOption;
            string? userOptionString;
            int arrayColumn = 2;
            int arrayRow = 25;
            string[,] nameArray = new string[arrayRow, arrayColumn];
            string fileName = "restaurant.txt";

            // Repeat main loop
            do
            {

                // TODO: Get a valid input
                do
                {
                    //  Initialize variables

                    userOption = false;

                    //  TODO: Provide the user a menu of options

                    Console.WriteLine("Choose a list option: ");
                    Console.WriteLine("O: Open your list of restaurants.");
                    Console.WriteLine("S: Save the array to the data file.");
                    Console.WriteLine("C: Add a name to the array.");
                    Console.WriteLine("R: Read a name from the array.");
                    Console.WriteLine("U: Update a name in the array.");
                    Console.WriteLine("D: Delete a name from the array.");
                    Console.WriteLine("Q: Quit the program.");

                    //  TODO: Get a user option (valid means its on the menu)

                    userOptionString = Console.ReadLine();

                    userOption = (userOptionString == "O" || userOptionString == "o" ||
                                userOptionString == "S" || userOptionString == "s" ||
                                userOptionString == "C" || userOptionString == "c" ||
                                userOptionString == "R" || userOptionString == "r" ||
                                userOptionString == "U" || userOptionString == "u" ||
                                userOptionString == "D" || userOptionString == "d" ||
                                userOptionString == "Q" || userOptionString == "q");

                    if (!userOption)
                    {
                        Console.WriteLine("Please enter a valid option.");
                    }

                } while (!userOption);

                //  TODO: If the option is O or o then open the text file (restaurant.txt) into the array of strings (nameArray)

                if (userOptionString == "O" || userOptionString == "o")
                {
                    Console.WriteLine("Opening your file ");

                    //int indexRow = 0;  // index for my array
                    //int indexColumn = 0;
                    using (StreamReader sr = File.OpenText(fileName))           //StreamReader is the function to get file info (lines of text)
                    {
                        string? s = "";                                         //s is a string variable for storing file lines brought in by StreamReader
                        int counter = 0;                                        //Counter is variable to increment
                        Console.WriteLine(" Here is your restaurant file: ");   //Output text
                        Console.WriteLine("");                                  //Output blank line
                        while ((s = sr.ReadLine()) != null)                     //While loop - Read text in file and store info in 's' variable
                        {
                            int correctRow = counter / 2;                       //Declare row variable and set row number (index)
                            int correctColumn = 0;                              //Declare row variable and set to 0
                            if (counter % 2 == 1)                               //Determine if there is a remainder for row number
                            {
                                correctColumn = 1;                              //If there is a remainder, column becomes an odd number
                            }
                            nameArray[correctRow, correctColumn] = s;           //Set array to the line(s) stored in 's' variable     
                            //Console.WriteLine(correctRow + " ");        
                            //Console.WriteLine(correctColumn);
                            Console.WriteLine(nameArray[correctRow, correctColumn]); //Output the text in the array
                            counter = counter + 1;                                   //Increment the counter so that the loop can move to the next row

                            for (int row = 0; row < nameArray.GetLength(0); row++)

                                for (int column = 0; column < nameArray.GetLength(1); column++)

                                {
                                    Console.WriteLine(nameArray[row, column]);
                                    nameArray[correctRow, correctColumn] = s;
                                }





                            //Console.WriteLine(s);
                            //nameArray[indexRow, indexColumn] = s;
                            //indexRow += 1;
                            //indexColumn += 1;
                        }
                        Console.WriteLine("");
                    }
                }

                //  TODO: Else if the option is an S or s then store the array of strings into the text file
                /* //Full Comment Start 
                                                                else if (userOptionString == "S" || userOptionString == "s")
                                                                {
                                                                    Console.WriteLine("In the S/s area");


                                                                    using (StreamWriter fileStr = File.CreateText(fileName))
                                                                    {
                                                                        for (int i = 0; i < nameArray.Length; i++)
                                                                        {

                                                                            fileStr.WriteLine(nameArray[i]);

                                                                        }

                                                                        Console.WriteLine("Your document has been saved in your restaurant file. ");
                                                                    }
                                                                }
                */ //Full Comment End
                   //  TODO: Else if the option is a C or c then add a name to the array (if there's room)

                else if (userOptionString == "C" || userOptionString == "c")
                {
                    Console.WriteLine("Add a Restaurant name and rating:");
                    bool found = false;
                    int counter = 0;
                    int newRestaurantEntered = 0;
                    for (int row = 0; row < nameArray.GetLength(0); row++)
                    {
                        for (int column = 0; column < nameArray.GetLength(1); column++)
                        {
                            //Console.WriteLine(row);
                            //Console.WriteLine(column);
                            if ((nameArray[row, column]) != "")
                            {
                              //  Console.WriteLine(nameArray[row, column]);
                            }
                            else
                            {
                                if (found == false)
                                {
                                    counter += column;
                                    Console.WriteLine("There is room to enter a new Restaurant and/or Rating.");                                   
                                    int addRow = 0;
                                    addRow = counter / 2;
                                    int addColumn = 0;
                                    if (counter % 2 == 1)
                                    {
                                        addColumn = 1;
                                    }
                                    addRow += row;
                                     //Console.WriteLine(addRow);
                                     //Console.WriteLine(addColumn);
                                     //Console.WriteLine("Counter is " + counter);
                                    if (addColumn == 0)
                                    { 
                                        Console.WriteLine("Please enter a restaurant name");
                                        string? restaurantName = Console.ReadLine();    
                                        nameArray[addRow, addColumn] = restaurantName;
                                        Console.WriteLine("Restaurant " + restaurantName + " has been entered.");
                                        newRestaurantEntered += 1;                                    
                                    }

                                    if (newRestaurantEntered == 1)
                                    { 
                                        string? currentRestaurant = nameArray[addRow, newRestaurantEntered-1];
                                        Console.WriteLine("Please enter the rating for " + currentRestaurant + ".");
                                        string? restaurantRating = Console.ReadLine();
                                        nameArray[addRow, newRestaurantEntered] = restaurantRating;
                                        Console.WriteLine("Rating for " + currentRestaurant + " has been entered.");
                                    }

                                    if (addColumn == 1 && newRestaurantEntered == 0)
                                    { 
                                        string? currentRestaurant = nameArray[addRow, addColumn-1];
                                        Console.WriteLine("Please enter the rating for " + currentRestaurant + ".");
                                        string? restaurantRating = Console.ReadLine();
                                        nameArray[addRow, addColumn] = restaurantRating;
                                        Console.WriteLine("Rating for " + currentRestaurant + " has been entered.");
                                    }

                                    counter += 1;
                                    //Console.WriteLine("Counter is " + counter);                
                                    found = true;
                                    
                                }
                            }

                        }
                    }
                    if (found == false)
                    { Console.WriteLine("There is no room for any more rating entries. "); }
                    /*
                    bool found = false;                                
                    for (int index = 0; index < nameArray.GetLength(0); index++)        //the lines of text
                    {
                        if ((nameArray[arrayRow, arrayColumn]) != "")               //if row and column are empty
                        {
                            Console.WriteLine(nameArray[arrayRow, arrayColumn]);   //output the line
                        }
                        else
                        {
                            if (found == false)
                            {
                                Console.WriteLine("Index is available.");
                                Console.WriteLine("Please enter a restaurant ");
                                string? name = Console.ReadLine();
                                nameArray[arrayRow, arrayColumn] = name;
                                found = true;
                            }
                        }

                    }
                    if (found == false)
                    {
                        Console.WriteLine("There is no room for any more restaurants. ");
                    }
                    */
                }
                //  TODO: Else if the option is an R or r then print the array

                //Full Comment Start 
                else if (userOptionString == "R" || userOptionString == "r")
                {
                    Console.WriteLine("Here is the list of the Restaurants and their ratings:");
                    Console.WriteLine("");
                    for (int row = 0; row < arrayRow; row++)
                    {
                        for (int column = 0; column < arrayColumn; column++)
                        {
                            //Console.Write(row);
                            //Console.Write(column);
                            Console.Write(nameArray[row, column]);
                        }
                        Console.Write("\n");
                        //if ((nameArray[index]) != "")
                        // Console.WriteLine(nameArray[index]);
                        //else
                        //Console.WriteLine("Index " + index + " is available.");
                    }
                    //Console.WriteLine ("");
                }
                //Full Comment End
                //  TODO: Else if the option is a U or u then update a name in the array (if it's there)
                /* //Full Comment Start 
                                                    else if (userOptionString == "U" || userOptionString == "u")
                                                    {
                                                        Console.WriteLine("In the U/u area");
                                                        string? changeChoice;
                                                                  Console.WriteLine("Change restaurant name and/or rating");
                                                        Console.WriteLine("What would you like to change? Press N for name or R for rating");
                                                        bool found = false;
                                                        Console.WriteLine("Enter a name to update");
                                                        var nameUpdate = Console.ReadLine();
                                                        string nameInArray;
                                                        //string? updateName;
                                                        for (int index = 0; index < arraySize; index++)
                                                        {
                                                            if (found == false)
                                                            {
                                                                nameInArray = nameArray[index];

                                                                if (nameUpdate == nameInArray)
                                                                {
                                                                    Console.WriteLine("Enter new name");
                                                                    string? updateName = Console.ReadLine();
                                                                    nameArray[index] = updateName;
                                                                    Console.WriteLine("Name updated");
                                                                    found = true;
                                                                }

                                                            }

                                                        }

                                                        if (found == false)
                                                        { Console.WriteLine("Name NOT found"); }
                                                    }
                */ //Full Comment End
                   //  TODO: Else if the option is a D or d then delete the name in the array (if it's there)
                /* //Full Comment Start 
                                                    else if (userOptionString == "D" || userOptionString == "d")
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
                */ //Full Comment End
                else
                {
                    Console.WriteLine("Good-bye!");
                }

            } while (!(userOptionString == "Q") && !(userOptionString == "q"));
        }  // end main
    }  // end program
}  // end namespace