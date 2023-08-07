using System;

namespace  EmployeeCrudChallenge                             //Namespace for all files must be the same
{
    class Salary : Employee                                  //Class for all files must be unique
    {
//Variables

    public int ESalaryRate                                   //Property for Salary Employee
    { get; set;}

//Constructor

public Salary () : base ()                                     //Same as class name DEFAULT
    {
       ESalaryRate =  0;
    }

public Salary (string newLastName, string newFirstName, char newEmployeeType, int newSalaryRate) : base(newLastName,newFirstName,newEmployeeType) //Same as class PASSING A VALUE
    {
        ESalaryRate = newSalaryRate;
    }
public override double Bonus()
    {
        return ESalaryRate * .1;
    }
// To-String

        public override string ToString()
        {
            return base.ToString() + " \nSalary Rate :" + ESalaryRate;
        }     
        

            
        
    }// End of Class
}//End of namespace