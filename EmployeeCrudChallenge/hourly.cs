using System;

namespace  EmployeeCrudChallenge                             //Namespace for all files must be the same
{
    class Hourly : Employee                                  //Class for all files must be unique
    {

//Variables

    public double EHourlyRate                                   //Property for Hourly Employee
    { get; set;}

//Constructor

public Hourly () : base ()                                     //Same as class name DEFAULT
    {
       EHourlyRate =  0;
    }

public Hourly (string newLastName, string newFirstName, char newEmployeeType, double newHourlyRate) : base(newLastName,newFirstName,newEmployeeType) //Same as class PASSING A VALUE
    {
        EHourlyRate = newHourlyRate;
    }
public override double Bonus()
    {
        return EHourlyRate * 40;
    }
        // To-String

        public override string ToString()
        {
            return base.ToString() + " \nHourly Rate :" + EHourlyRate;
        }

    }// End of Class
}//End of namespace