using System;

namespace  EmployeeCrudChallenge                             //Namespace for all files must be the same
{
    class Program                                         //Class for all files must be unique
    {
        static void Main(string[] args)
        {

            Employee Emp1 = new Employee();
            Employee Emp2 = new Employee("Williams", "Tiffany", 'S');
            Console.WriteLine(Emp1);
            Console.WriteLine(Emp2);
            Console.WriteLine();

            Hourly HrEmp1 = new Hourly();
            Hourly HrEmp2 = new Hourly("Jackson", "Larry", 'H', 40);
            Console.WriteLine(HrEmp1);
            Console.WriteLine(HrEmp2);
            Console.WriteLine();

            Salary SalEmp1 = new Salary();
            Salary SalEmp2 = new Salary("Morrow", "Rugenia", 'S', 50000);
            Console.WriteLine(SalEmp1);
            Console.WriteLine(SalEmp2);
            Console.WriteLine(); 
            
        } //End of Main
    }// End of Class
}//End of namspace