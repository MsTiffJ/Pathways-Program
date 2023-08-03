using System;

namespace RestaurantOOP
{
    class Program
    {
        static void Main(string[] args)
        {
//Version 1
            /*
            Restaurant A = new Restaurant();
            A.name = "Taxi's";
            A.cuisine = "American";
            A.rating = 2;

            Restaurant B = new Restaurant();
            B.name = "Broncos";
            B.cuisine = "American";
            B.rating = 4;
            
            Console.WriteLine(A.name);
            Console.WriteLine(A.cuisine);
            Console.WriteLine(A.rating);

            Console.WriteLine(B.name);
            Console.WriteLine(B.cuisine);
            Console.WriteLine(B.rating);
            Console.WriteLine(B.getComment());
            */

//Version 2
            Restaurant A = new Restaurant();

            Restaurant B = new Restaurant();
            B.setName("Broncos");
            B.setCuisine("American");
            B.setRating(4);
            B.setComment("It is Greasy!");

            Restaurant C = new Restaurant();

            Restaurant D = new Restaurant("Asian Wok", "Chinese", 5, "Great Shrimp Fried Rice!");
            

           /* Console.WriteLine(A.getName());
            Console.WriteLine(A.getCuisine());
            Console.WriteLine(A.getRating());
            Console.WriteLine(A.getComment());*/

            //Pre existing To-String Method
            Console.WriteLine(A);
            Console.WriteLine(B);
            Console.WriteLine(C);
            Console.WriteLine(D);

            /*Console.WriteLine(B.getName());
            Console.WriteLine(B.getCuisine());
            Console.WriteLine(B.getRating());
            Console.WriteLine(B.getComment());

            Console.WriteLine(C.getName());
            Console.WriteLine(C.getCuisine());
            Console.WriteLine(C.getRating());
            Console.WriteLine(C.getComment());

            Console.WriteLine(D.getName());
            Console.WriteLine(D.getCuisine());
            Console.WriteLine(D.getRating());
            Console.WriteLine(D.getComment());*/

        }
    }
}