using System;

namespace  EmployeeCrudChallenge                             //Namespace for all files must be the same
{
    class Employee                                          //Class for all files must be unique
    {
//Variables

    public string RLastName                                 //Property for last name
    { get; set;}

    public string RFirstName                                //Property for first name
    { get; set;}

    public char REmployeeType                               //Property for Employee Type
    { get; set;}

//Constructors

    public Employee()                                       //Same as class name DEFAULT
    {
        RLastName = "Doe";
        RFirstName = "John";
        REmployeeType = 'e';
    }

    public Employee( string newLastName, string newFirstName, char newEmployeeType )    //Same as class PASSING A VALUE
    {
        RLastName = newLastName;
        RFirstName = newFirstName;
        REmployeeType = newEmployeeType;
    }

        //To-String

        public override string ToString()
        {
            return "Last Name: " + RLastName + " \nFirst Name: " + RFirstName + " \nEmployee Type: " + REmployeeType;
        }
    }// End of Class
}//End of namespace