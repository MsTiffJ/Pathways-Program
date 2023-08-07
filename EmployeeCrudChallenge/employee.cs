using System;

namespace  EmployeeCrudChallenge                             //Namespace for all files must be the same
{
    class Employee                                          //Class for all files must be unique
    {
//Variables

    public string ELastName                                 //Property for last name
    { get; set;}

    public string EFirstName                                //Property for first name
    { get; set;}

    public char EEmployeeType                               //Property for Employee Type
    { get; set;}

//Constructors

    public Employee()                                       //Same as class name DEFAULT
    {
        ELastName = null;
        EFirstName = null;
        EEmployeeType = ' ';
    }

    public Employee( string newLastName, string newFirstName, char newEmployeeType )    //Same as class PASSING A VALUE
    {
        ELastName = newLastName;
        EFirstName = newFirstName;
        EEmployeeType = newEmployeeType;
    }

    public virtual double Bonus()
    {
        return 0;
    }
        //To-String

        public override string ToString()
        {
            return "Last Name: " + ELastName + " \nFirst Name: " + EFirstName + " \nEmployee Type: " + EEmployeeType + " \nBonus: " + Bonus(); 
        }
    }// End of Class
}//End of namespace