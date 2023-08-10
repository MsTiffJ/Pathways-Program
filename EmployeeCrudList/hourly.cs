using System;

namespace  employeeAbstractList                              //Namespace for all files must be the same
{
    class HourlyEmployee : Employee                                  //Class for all files must be unique
    {

//Variables

    public double EHourlyRate                                   //Property for Hourly Employee
    { get; set;}

//Constructor

public HourlyEmployee () : base ()                                     //Same as class name DEFAULT
    {
       EHourlyRate =  0;
    }

public HourlyEmployee (string newLastName, string newFirstName, char newEmployeeType, double newHourlyRate) : base(newLastName,newFirstName,newEmployeeType) //Same as class PASSING A VALUE
    {
        EHourlyRate = newHourlyRate;
    }
public override double GetBonus()
    {
        return EHourlyRate * 40;
        //return 40;
    }
        // To-String

        public override string ToString()
        {
            return base.ToString() + " \nHourly Rate :" + EHourlyRate + " \n";
        }

    }// End of Class
}//End of namespace