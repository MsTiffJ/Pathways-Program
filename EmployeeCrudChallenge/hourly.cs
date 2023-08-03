using System;

namespace  EmployeeCrudChallenge                             //Namespace for all files must be the same
{
    class Hourly : Employee                                  //Class for all files must be unique
    {

//Variables

    public double RHourlyRate                                   //Property for Hourly Employee
    { get; set;}

//Constructor

public Hourly () : base ()                                     //Same as class name DEFAULT
    {
       RHourlyRate =  0;
    }

public Hourly (string newLastName, string newFirstName, char newEmployeeType, double newHourlyRate) : base(newLastName,newFirstName,newEmployeeType) //Same as class PASSING A VALUE
    {
        RHourlyRate = newHourlyRate;
    }

        // To-String

        public override string ToString()
        {
            return base.ToString() + " \nHourly Rate :" + RHourlyRate;
        }

    }// End of Class
}//End of namespace