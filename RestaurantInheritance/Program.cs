using System;

namespace RestaurantClass                                   //Namespace for all files must be the same
{
    class Program                                           //Class for all files must be unique
    {
        static void Main(string[] args)
        {
            Restaurant rest1 = new Restaurant();
            Restaurant rest2 = new Restaurant("Shuck's", 4);
            Console.WriteLine(rest1);
            Console.WriteLine(rest2);
            Console.WriteLine();
            
            FineDining fine1 = new FineDining();
            FineDining fine2 = new FineDining("Mahogany Prime", 5, true);
            Console.WriteLine(fine1);
            Console.WriteLine(fine2);
            Console.WriteLine();
          
            FastFood fast1 = new FastFood();
            FastFood fast2 = new FastFood("Wendy's", 2, true);
            Console.WriteLine(fast1);
            Console.WriteLine(fast2);
            Console.WriteLine();
            
        } //End of Main
    }// End of Class
}//End of namspace


