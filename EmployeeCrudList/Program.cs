using System;
using System.Collections.Generic;                               //For Lists

namespace employeeAbstractList                                  //Namespace for Lists
{
    class Program                                               //Class
    {
        static void Main(string[] args)                         //Start of Main
        {
            //Declare variables
            bool userOption;
            string? userOptionString;

            List<Employee> employeeList = new List<Employee>();             //Create a list of Employees

            employeeList.Add(new HourlyEmployee("Jack", "T.J.", 'H', 25)); // Add Hourly Employee

            employeeList.Add(new SalaryEmployee("Will", "A.L.", 'S', 50000)); //Add Salary Employee

            employeeList.Add(new SalaryEmployee("Will", "B.L.", 'S', 50000)); //Add Salary Employee

            List<HourlyEmployee> hourlyEmployeeList = new List<HourlyEmployee>();  // Create a list of Hourly Employees

            hourlyEmployeeList.Add(new HourlyEmployee("Foye", "Sheritta", 'H', 20.25)); //Add Hourly employee to hourly list test

            hourlyEmployeeList.Add(new HourlyEmployee("Minor", "Song", 'H', 15.25)); //Add Hourly employee to hourly list test

            List<SalaryEmployee> salaryEmployeeList = new List<SalaryEmployee>();  //Create a list of Salary Employees to test

            salaryEmployeeList.Add(new SalaryEmployee("Patrick", "Ced", 'S', 75000)); //Add Salary employee to salary list to test

            salaryEmployeeList.Add(new SalaryEmployee("Jackson", "Larry", 'S', 95000)); //Add Salary employee to salary list to test

            do   //Main do/while loop
            {


                do //Get valid input do/while loop
                {
                    //  Initialize variables

                    userOption = false;

                    //  TODO: Provide the user a menu of options

                    Console.WriteLine("Choose a list option: ");
                    //Console.WriteLine("L: Load the single text file into the program.");
                    //Console.WriteLine("S: Store the current employee information in the text file.");
                    Console.WriteLine("C: Add an employee.");
                    Console.WriteLine("R: Print a list of all the employees including their calculated bonus.");
                    Console.WriteLine("U: Update information for an employee.");
                    Console.WriteLine("D: Delete an employee.");
                    Console.WriteLine("Q: Quit the program.");

                    //  TODO: Get a user option (valid means its on the menu)

                    userOptionString = Console.ReadLine();

                    userOption =
                                (userOptionString == "C" || userOptionString == "c" ||
                                userOptionString == "R" || userOptionString == "r" ||
                                userOptionString == "U" || userOptionString == "u" ||
                                userOptionString == "D" || userOptionString == "d" ||
                                userOptionString == "Q" || userOptionString == "q");
                    //userOptionString == "L" || userOptionString == "l" ||
                    //userOptionString == "S" || userOptionString == "s" ||

                    if (!userOption)
                    {
                        Console.WriteLine("Please enter a valid option.");
                    }

                } while (!userOption); //End of valid input do/while loop

                //OPTION "C" if the option is a C or c Add an employee

                if (userOptionString == "C" || userOptionString == "c")
                {
                    Console.WriteLine("You have chosen to add an employee.");

                    Console.WriteLine("Please enter last name of new employee");       //Get Last name of employee
                    string? ELastName = Console.ReadLine();
                    //Console.WriteLine(ELastName);

                    Console.WriteLine("Please enter first name of new employee");       //Get First name of employee
                    string? EFirstName = Console.ReadLine();
                    //Console.WriteLine(EFirstName);

                    char employeeType;                                                  //Get Employee type
                    Console.WriteLine("Please enter employee type H/h for hourly or S/s for salary.");
                    employeeType = Convert.ToChar(Console.ReadLine());
                    //Console.WriteLine(employeeType);
                    if (employeeType == 'H' || employeeType == 'h')
                    {
                        Console.WriteLine("Please enter hourly rate for employee.");  //Asking for hourly rate
                        double EHourlyRate = Convert.ToDouble(Console.ReadLine());
                        hourlyEmployeeList.Add(new HourlyEmployee(ELastName, EFirstName, employeeType, EHourlyRate));
                    }

                    else if (employeeType == 'S' || employeeType == 's')
                    {
                        Console.WriteLine("Please enter salary rate for employee.");  //Asking for salary rate
                        int ESalaryRate = Convert.ToInt32(Console.ReadLine());
                        salaryEmployeeList.Add(new SalaryEmployee(ELastName, EFirstName, employeeType, ESalaryRate));
                    }

                    else
                    {
                        Console.WriteLine("Please enter a valid option.");
                    }
                }
                //FINISH option "C"
                //OPTION "R" if the option is a R or r Add an employee

                else if (userOptionString == "R" || userOptionString == "r")
                {
                    Console.WriteLine("Printing a list of all the employees including their calculated bonus.");

                    foreach (Employee anEmployee in employeeList)                       //Print the Employee List
                    {
                        Console.WriteLine(anEmployee);

                    }  // end foreach 

                    foreach (HourlyEmployee anEmployee in hourlyEmployeeList)           //Print the Hourly List
                    {
                        Console.WriteLine(anEmployee + " \n");

                    }  // end foreach  

                    foreach (SalaryEmployee anEmployee in salaryEmployeeList)           //Print the Salary List
                    {
                        Console.WriteLine(anEmployee);
                    }  // end foreach 

                } //End of "R" Option
                  //FINISH Option "R"
                  //OPTION "U" if the option is a U or u Update information for an employee

                else if (userOptionString == "U" || userOptionString == "u")
                {
                    Console.WriteLine("You have chosen to update information for an employee.");
                    Console.WriteLine("Please enter last name of the current employee that you will like to update");       //Get Last name of employee
                    string? findLastName = Console.ReadLine();
                    //Console.WriteLine(ELastName);

                    Console.WriteLine("Please enter first name of current employee that you will like to update");       //Get First name of employee
                    string? findFirstName = Console.ReadLine();
                    //Console.WriteLine(EFirstName);
                    bool empFound = false;          //Variable for finding the employee
                    int e = 0;
                    
                    foreach (Employee emp in employeeList)//Searching the list for employee that I am adding
                    {
                        //Console.WriteLine("At Position {0}: ", e);
                        //Console.WriteLine(emp.ELastName);
                        if (findLastName.Equals(emp.ELastName)) //If employee is found
                        {
                            Console.WriteLine("Employee found. Select F to update First Name or select L to update Last name. \n");
                            string? nameChoice = Console.ReadLine();
                            if (nameChoice == "F" || nameChoice == "f")  //Select the First name to update
                            {
                                Console.WriteLine("Please enter the new first name of Employee.");  //Ask for first name
                                string? newFirstName = Console.ReadLine();  //Taking in their selection
                                emp.EFirstName = newFirstName; //Updating the First name
                                Console.WriteLine("The first name of the employee has been updated.");
                            }
                            else
                            {
                                Console.WriteLine("Please enter the new last name of Employee."); //Ask for last name
                                string? newLastName = Console.ReadLine(); //Taking in their selection
                                emp.ELastName = newLastName;  //Updating the Last name
                                Console.WriteLine("The last name of the employee has been updated.");
                            }
                            empFound = true;  //Set found set to true
                            e++; //Incrementing the for each loop
                        }
                    }
                    if (empFound == false)   //If name is not found then print message
                    { Console.WriteLine("Employee not found."); }
                } //End of U option

                //Finish the Q option 

            } //End of do portion of do/while loop(code is enclosed)
            while (!(userOptionString == "Q") && !(userOptionString == "q")); //End of do while loop

        } //End of Main

    } //End of class

} //End of namespace

