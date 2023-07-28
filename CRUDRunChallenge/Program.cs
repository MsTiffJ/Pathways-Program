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

                        }
                        Console.WriteLine("");
                    }
                }

                //  TODO: Else if the option is an S or s then store the array of strings into the text file
//Full Comment Start 
                                                                else if (userOptionString == "S" || userOptionString == "s")
                                                                {
                                                                    Console.WriteLine("In the S/s area");


                                                                    using (StreamWriter fileStr = File.CreateText(fileName))
                                                                    {
                                                                        for (int row = 0; row < nameArray.GetLength(0); row++)
                                                                        {
                                                                                for (int column = 0; column < nameArray.GetLength(1); column++)
                                                                                {

                                                                                    fileStr.WriteLine(nameArray[row,column]);

                                                                                }
                                                                        }
                                                                        Console.WriteLine("Your document has been saved in your restaurant file. ");
                                                                    }
                                                                }
//Full Comment End
                   //  TODO: Else if the option is a C or c then add a name to the array (if there's room)

                else if (userOptionString == "C" || userOptionString == "c")
                {
                    Console.WriteLine("Add a Restaurant name and rating:");
                    bool found = false;
                    int counter = 0;
                    int newRestaurantEntered = 0;                                   //New restaurant entered
                    for (int row = 0; row < nameArray.GetLength(0); row++)          //As long as the row length is less than the array length increment
                    {
                        for (int column = 0; column < nameArray.GetLength(1); column++) //As long as the column length is less than the array length increment
                        {
                            //Console.WriteLine(row);
                            //Console.WriteLine(column);
                            if ((nameArray[row, column]) != "")                     //If the array position is not empty
                            {
                                //  Console.WriteLine(nameArray[row, column]);        //Do nothing
                            }
                            else                                                    //Otherwise we need to do this
                            {
                                if (found == false)                                 //If there is an empty space
                                {
                                    counter += column;                              //Go through and find a space
                                    Console.WriteLine("There is room to enter a new Restaurant and/or Rating.");
                                    int addRow = 0;                                 //Set Variable to 0
                                    addRow = counter / 2;                           //Determine if row is even or odd
                                    int addColumn = 0;                              //Set Variable to 0
                                    if (counter % 2 == 1)                           //If counter has a remainder 
                                    {
                                        addColumn = 1;                              //Then column is odd
                                    }
                                    addRow += row;                                  //Set the row position addRow =0 and then add the row position from the array
                                                                                    //Console.WriteLine(addRow);
                                                                                    //Console.WriteLine(addColumn);
                                                                                    //Console.WriteLine("Counter is " + counter);
                                    if (addColumn == 0)                             //If the column is an even number then add a restaurant name
                                    {
                                        Console.WriteLine("Please enter a restaurant name");
                                        string? restaurantName = Console.ReadLine();                    //Entering in new restaurant
                                        nameArray[addRow, addColumn] = restaurantName;
                                        Console.WriteLine("Restaurant " + restaurantName + " has been entered.");
                                        newRestaurantEntered += 1;
                                    }

                                    if (newRestaurantEntered == 1)                          //If new restaurant is entered
                                    {
                                        string? currentRestaurant = nameArray[addRow, newRestaurantEntered - 1];      //Find restaurant name that was just entered
                                        Console.WriteLine("Please enter the rating for " + currentRestaurant + "."); //Ask for Rating
                                        string? restaurantRating = Console.ReadLine();                              //Store rating entered in restaurantRating
                                        nameArray[addRow, newRestaurantEntered] = restaurantRating;                 //Find restaurant enteres and enter rating
                                        Console.WriteLine("Rating for " + currentRestaurant + " has been entered.");  //Current Rating was entered
                                    }

                                    if (addColumn == 1 && newRestaurantEntered == 0)                            //If there is a restaurant with no rating then ask
                                    {
                                        string? currentRestaurant = nameArray[addRow, addColumn - 1];             //Find the position of the missing rating
                                        Console.WriteLine("Please enter the rating for " + currentRestaurant + "."); //Ask for Rating
                                        string? restaurantRating = Console.ReadLine();                          //Store rating entered in restaurantRating
                                        nameArray[addRow, addColumn] = restaurantRating;                        //Enter rating into empty space
                                        Console.WriteLine("Rating for " + currentRestaurant + " has been entered."); //Current Rating Entered
                                    }

                                    counter += 1;                                                  //Keep looping until all spaces are filled             
                                    //Console.WriteLine("Counter is " + counter);                
                                    found = true;                                                   //If all spaces are filled then loop stops

                                }
                            }

                        }
                    }
                    if (found == false)
                    { Console.WriteLine("There is no room for any more rating entries. "); }

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
                //Full Comment Start 
                else if (userOptionString == "U" || userOptionString == "u")
                {
                    Console.WriteLine("In the U/u area");
                    bool found = false;
                    string? changeRestaurantChoice;                 //Variable to change name of restaurant
                    string? changeRatingChoice;                     //Variable to change rating of restaurant
                    string? nameInArray;                            //Variale to store the found name

                    Console.WriteLine("Change restaurant name and/or rating");  //Ask for change 
                    Console.WriteLine("What would you like to change? Press N for name or R for rating"); //Select what needs to be changed
                    string? nameUpdate = Console.ReadLine();        //Collect restaurant name update choice
                    if (nameUpdate == "N" || nameUpdate == "n")        //Store name update choice
                    {
                        Console.WriteLine("Enter restaurant name to update");  //Ask for restaurant name to update
                        string? restaurantName = Console.ReadLine();            //Store restaurant name choice
                        for (int row = 0; row < nameArray.GetLength(0); row++)          //As long as the row length is less than the array length increment
                        {
                            for (int column = 0; column < nameArray.GetLength(1); column++) //As long as the column length is less than the array length increment
                            {
                                if (found == false)
                                {
                                    nameInArray = nameArray[row, column];            //Looking for restaurant choice
                                    if (restaurantName == nameInArray)                  //If restaurant name is found
                                    {
                                        Console.WriteLine("Please enter new restaurant name");     //Ask for new name
                                        changeRestaurantChoice = Console.ReadLine();              //Store new name
                                        nameArray[row, column] = changeRestaurantChoice;          //Put new name in array
                                        Console.WriteLine("Restaurant name has been updated");   //advised new name has been updated
                                        found = true;
                                    }
                                }

                            }

                        }
                        if (found == false)
                        { Console.WriteLine("Name NOT found"); }
                    }
                    if (nameUpdate == "R" || nameUpdate == "r")        //Store rating update choice
                    {
                        Console.WriteLine("Enter restaurant name you would like to update rating for");  //Ask for restaurant name to update rating
                        string? restaurantName = Console.ReadLine();            //Store restaurant name choice
                        for (int row = 0; row < nameArray.GetLength(0); row++)          //As long as the row length is less than the array length increment
                        {
                            for (int column = 0; column < nameArray.GetLength(1); column++) //As long as the column length is less than the array length increment
                            {
                                if (found == false)
                                {
                                    nameInArray = nameArray[row, column];            //Looking for restaurant choice
                                    if (restaurantName == nameInArray)                  //If restaurant name is found 

                                    {
                                        Console.WriteLine("Please enter new rating for " + restaurantName);     //Ask for new rating
                                        changeRatingChoice = Console.ReadLine();              //Store new rating
                                        nameArray[row, column + 1] = changeRatingChoice;          //Put new rating in array
                                        Console.WriteLine("Restaurant rating has been updated for " + restaurantName);   //advised new rating has been updated
                                        found = true;
                                    }

                                }
                            }

                        }
                        if (found == false)
                        { Console.WriteLine("Rating NOT found"); }
                    }
                }

                //  TODO: Else if the option is a D or d then delete the name in the array (if it's there)
                //Full Comment Start 
                else if (userOptionString == "D" || userOptionString == "d")
                {
                    bool found = false;
                    string? nameInArray;

                    Console.WriteLine("Delete restaurant name and/or rating");  //Ask for delete
                    Console.WriteLine("What would you like to delete? Press N for name or R for rating"); //Select what needs to be deleted
                    string? nameDelete = Console.ReadLine();        //Collect restaurant name to delete
                    if (nameDelete == "N" || nameDelete == "n")        //Store name delete choice
                    {
                        Console.WriteLine("What restaurant name would you like to delete?"); //Asking for name to delete
                        string restaurantName = Console.ReadLine();    //Store name choice
                        for (int row = 0; row < nameArray.GetLength(0); row++)          //As long as the row length is less than the array length increment
                        {
                            for (int column = 0; column < nameArray.GetLength(1); column++) //As long as the column length is less than the array length increment
                            {
                                if (found == false)
                                {
                                    nameInArray = nameArray[row, column];            //Looking for restaurant choice
                                    if (restaurantName == nameInArray)                  //If restaurant name is found 
                                    {  
                                        nameArray[row,column] ="";                      //Delete name
                                        nameArray[row,column +1] ="";                   //Delete rating
                                        Console.WriteLine(restaurantName + " and rating has been deleted");
                                        found =true;
                                    }

                                }
                            }

                        }
                        if (found == false)
                        { Console.WriteLine("Name NOT found"); }

                    }
                    if (nameDelete == "R" || nameDelete == "r")        //Store rating delete choice
                    {
                        Console.WriteLine("What restaurant name would you like to delete the rating for?"); //Asking for name of restaurant to delete rating
                        string restaurantName = Console.ReadLine();    //Store name choice
                        for (int row = 0; row < nameArray.GetLength(0); row++)          //As long as the row length is less than the array length increment
                        {
                            for (int column = 0; column < nameArray.GetLength(1); column++) //As long as the column length is less than the array length increment
                            {
                                if (found == false)
                                {
                                    nameInArray = nameArray[row, column];            //Looking for restaurant choice
                                    if (restaurantName == nameInArray)                  //If restaurant name is found 
                                    {  
                                        nameArray[row,column +1] ="";                      //Delete name
                                        Console.WriteLine("Rating for " + restaurantName + " has been deleted");
                                        found =true;
                                    }

                                }
                            }

                        }
                        if (found == false)
                        { Console.WriteLine("Name NOT found"); }

                    }
                    
                }
                //  TODO: Else if the option is a Q or q then quit the program
                //Full Comment End
                else
                {
                    Console.WriteLine("Good-bye!");
                }






            } while (!(userOptionString == "Q") && !(userOptionString == "q"));
        }  // end main
    }  // end program
}  // end namespace