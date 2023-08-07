using System;

namespace EmployeeCrudChallenge                             //Namespace for all files must be the same
{
    class Program                                         //Class for all files must be unique
    {
        static void Main(string[] args)
        {

            //Declare variables

            bool userOption;
            string? userOptionString;

                Employee Emp1 = new Employee();
                Employee Emp2 = new Employee("Williams", "Tiffany", 'S');
                //Console.WriteLine(Emp1);
                //Console.WriteLine(Emp2);
                //Console.WriteLine();

                Hourly HrEmp1 = new Hourly();
                Hourly HrEmp2 = new Hourly("Jackson", "Larry", 'H', 40);
                
                //Console.WriteLine(HrEmp1);
                //Console.WriteLine(HrEmp2);
                //Console.WriteLine();

                Salary SalEmp1 = new Salary();
                Salary SalEmp2 = new Salary("Morrow", "Rugenia", 'S', 50000);
                Salary SalTemp = new Salary();
                //Console.WriteLine(SalEmp1);
                //Console.WriteLine(SalEmp2);
                //Console.WriteLine();

                //Create employee array

                Employee[] employeeArray = new Employee[25];

                //Initialize each index of employee array to blank employee object 

                for (int index = 0; index < employeeArray.Length; index++)
                {
                    employeeArray[index] = new Employee();
                }

                //Place sample data in array

                employeeArray[1] = Emp1;
                employeeArray[4] = Emp2;
                employeeArray[10] = HrEmp1;
                employeeArray[14] = HrEmp2;
                employeeArray[20] = SalEmp1;
                employeeArray[24] = SalEmp2;

                employeeArray[2].ELastName = "Test Name";
                employeeArray[2].EFirstName = "First Name";

            //Main do loop
            do
            {

                // TODO: Get a valid input
                do
                {
                    //  Initialize variables

                    userOption = false;

                    //  TODO: Provide the user a menu of options

                    Console.WriteLine("Choose a list option: ");
                    Console.WriteLine("L: Load the single text file into the program.");
                    Console.WriteLine("S: Store the current employee information in the text file.");
                    Console.WriteLine("C: Add an employee.");
                    Console.WriteLine("R: Print a list of all the employees including their calculated bonus.");
                    Console.WriteLine("U: Update information for an employee.");
                    Console.WriteLine("D: Delete an employee.");
                    Console.WriteLine("Q: Quit the program.");

                    //  TODO: Get a user option (valid means its on the menu)

                    userOptionString = Console.ReadLine();

                    userOption = (userOptionString == "L" || userOptionString == "l" ||
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

                //If the option is L or l then Load the single text file into the program.

                if (userOptionString == "L" || userOptionString == "l")
                {
                    Console.WriteLine("Load the single text file into the program. ");
                }
                // Finish the L option   
                //Else if the option is an S or s to store the current employee information in the text file

                else if (userOptionString == "S" || userOptionString == "s")
                {
                    Console.WriteLine("Store the current employee information in the text file.");
                }
                //Finish the S option


  
//Else if the option is a C or c Add an employee

                if (userOptionString == "C" || userOptionString == "c")
                {
                    Console.WriteLine("Add an employee.");
                    bool found = false;   
                    Char TempType;
                    Hourly TempHourly = new Hourly();
                    Salary TempSalary = new Salary();

                    for (int index = 0; index < employeeArray.Length; index++)
                    {

                        if (((employeeArray[index].ELastName) == null) && (found==false))
                        {
                            Console.WriteLine("Please enter the employee type.");                           //Request the employee type
                            TempType = Convert.ToChar(Console.ReadLine());        //Get the employee type
    
                            Console.WriteLine(index);
                            Console.WriteLine("Please enter the first name of Employee.");                  //Request the employee's first name
                              if(TempType == 'H'||TempType == 'h')
                                    TempHourly.EFirstName=Console.ReadLine();

                                else
                                    TempSalary.EFirstName =Console.ReadLine();                           //Get the employee's first name
                            

                            Console.WriteLine("Please enter the last name of the Employee.");               //Request the employee's last name
                              if(TempType == 'H'||TempType == 'h')
                                    TempHourly.ELastName=Console.ReadLine();

                                else
                                    TempSalary.ELastName =Console.ReadLine();

                              if(TempType == 'H'||TempType == 'h')
                                    TempHourly.EEmployeeType=TempType;

                                else
                                    TempSalary.EEmployeeType =TempType;
                           
                                Console.WriteLine("Please enter the Hourly Rate/Annual Salary of the Employee.");       //Request the employee's rate or salary
                                if(TempType == 'H'||TempType == 'h')
                                    TempHourly.EHourlyRate=Convert.ToDouble(Console.ReadLine());

                                else
                                    TempSalary.ESalaryRate=Convert.ToInt32(Console.ReadLine());

                                if(TempType == 'H'||TempType == 'h')
                                    employeeArray[index]=TempHourly;

                                else
                                    employeeArray[index]=TempSalary;

                            
                               
                      found = true;
                        }
                    }
                    Console.WriteLine();
                    if (found == false)
                    { Console.WriteLine("Employee list is full. "); }
                }
//Finish the C option



//Else if the option is an R or r Print a list of all the employees including their calculated bonus

                else if (userOptionString == "R" || userOptionString == "r")
                {
                    Console.WriteLine("Print a list of all the employees including their calculated bonus.");

                    for (int index = 0; index < employeeArray.Length; index++)
                    {

                        if (!((employeeArray[index].ELastName) == null))
                        {
                            Console.WriteLine(employeeArray[index]);
                            Console.WriteLine();
                        }
                    }
                    Console.WriteLine();
                }
//Finish the R option
//Else if the option is a U or u Update information for an employee
                //Full Comment Start 
                else if (userOptionString == "U" || userOptionString == "u")

                {
                    Console.WriteLine("Update information for an employee");
                    Console.WriteLine("Enter first name of employee");
                    string? newFirstName = Console.ReadLine();
                    Console.WriteLine("Enter last name of employee");
                    string? newLastName = Console.ReadLine();
                    bool found = false;


                    for (int index = 0; index < employeeArray.Length; index++)
                    {

                        if (employeeArray[index].ELastName == newLastName && employeeArray[index].EFirstName == newFirstName && found == false)
                        {
                            
                            Console.WriteLine("Employee found. Select F to update First Name or select L to update Last name. \n");
                            string? nameChoice = Console.ReadLine();
                            if (nameChoice == "F" || nameChoice == "f")
                            {
                              Console.WriteLine("Please enter the new first name of Employee.");
                              newFirstName = Console.ReadLine();
                              employeeArray[index].EFirstName = newFirstName;
                              Console.WriteLine("The first name of the employee has been updated.");  
                            }
                            else
                            {
                              Console.WriteLine("Please enter the new last name of Employee.");
                              newLastName = Console.ReadLine();
                              employeeArray[index].ELastName = newLastName;
                              Console.WriteLine("The last name of the employee has been updated.");  
                            }

                            found = true;
                        }
                    }
                    Console.WriteLine();
                    if (found == false)
                        Console.WriteLine("Employee not found in list. \n");
                }
//Finish the U option

//Else if the option is a D or d Delete an employee.

                else if (userOptionString == "D" || userOptionString == "d")
                {
                    Console.WriteLine("Delete employee from List.");
                    Console.WriteLine("Enter first name of employee");
                    string? newFirstName = Console.ReadLine();
                    Console.WriteLine("Enter last name of employee");
                    string? newLastName = Console.ReadLine();
                    bool found = false;


                    for (int index = 0; index < employeeArray.Length; index++)
                    {

                        if (employeeArray[index].ELastName == newLastName && employeeArray[index].EFirstName == newFirstName && found == false)
                        {
                            employeeArray[index] = Emp1;
                            Console.WriteLine("Employee removed from list. \n");
                            found = true;
                        }
                    }
                    Console.WriteLine();
                    if (found == false)
                        Console.WriteLine("Employee not found in list. \n");
                }
//Finish the D option

//Else if the option is a Q or q then quit the program
                else
                {
                    Console.WriteLine("Good-bye!");
                }
//Finish the Q option 

            }
            while (!(userOptionString == "Q") && !(userOptionString == "q")); //End of do while loop

        } //End of Main
    }// End of Class
}//End of namspace