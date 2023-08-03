using System;

namespace  EmployeeCrudChallenge                             //Namespace for all files must be the same
{
    class Salary : Employee                                  //Class for all files must be unique
    {
//Variables

    public int RSalaryRate                                   //Property for Salary Employee
    { get; set;}

//Constructor

public Salary () : base ()                                     //Same as class name DEFAULT
    {
       RSalaryRate =  0;
    }

public Salary (string newLastName, string newFirstName, char newEmployeeType, int newSalaryRate) : base(newLastName,newFirstName,newEmployeeType) //Same as class PASSING A VALUE
    {
        RSalaryRate = newSalaryRate;
    }

// To-String

        public override string ToString()
        {
            return base.ToString() + " \nSalary Rate :" + RSalaryRate;
        }     
        

            
        
    }// End of Class
}//End of namespace