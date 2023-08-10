using System;
using System.Collections.Generic;                       //For Lists

namespace FoodInterfaceCRUD                             //Namespace
{
    class Program                                       //Class
    {

        static void Main(string[] args)                //Main
        {

            //Create a list of Restaurants
            List<Restaurant> restaurantList = new List<Restaurant>();

           // restaurantList.Add(new Restaurant("Mahogany"));
           // restaurantList.Add(new Restaurant("360 Steakhouse"));

            restaurantList.Add(new FineDining("Sullivan's", true, 5, "American"));
            restaurantList.Add(new FineDining("Dover Steakhouse", true, 4, "American"));
            restaurantList.Add(new FineDining());

            restaurantList.Add(new FastFood("Wendy's", true, "American Fast Food"));

            //Print the list
            foreach (Restaurant anRestaurant in restaurantList)
            {
                Console.WriteLine(anRestaurant);
            } // end foreach

            //READING(finding) a restaurant in the list
            //==========================================================================================
            Console.Write("Please enter a restaurant name to find: ");   //ask for restaurant name
            string findName = Console.ReadLine();                       //store answer
            bool found = false;                                         //set boolean found to false (statement right now it is false)
            foreach (Restaurant thisRestaurant in restaurantList)         //loop to search the restaurant list
            {
                if (thisRestaurant.RName == findName)                    //if there is a match on the restaurant name
                {
                    Console.WriteLine(thisRestaurant + " has been found.");   //then write the restaurant name
                    found = true;               //set boolean found to true
                }

            } //end of foreach loop
            if (!(found))
                Console.WriteLine(findName + " is not found.");


            //CREATING(adding) a restaurant to the list
            //==============================================================================================
            Console.Write("Please enter a restaurant name to be added: "); //ask for a restaurant name 
            string newRestaurantName = Console.ReadLine();   //store answer
            Console.Write("Please enter a cuisine type: "); //ask for cuisine type
            string newCuisineType = Console.ReadLine(); //store answer
            Console.Write("Please enter a restaurant type to add (FD or FF): "); //ask for restaurant type for FineDining or FastFood
            string newRestaurantType = Console.ReadLine(); //store answer
            bool newReservationRequired = false;
            bool newDriveThru = true;
            switch (newRestaurantType) //start switch for restaurant type answer
            {
                case "FD":
                case "fd":
                    Console.Write("Please enter if reservation is required (Y or N): "); //ask if reservation required
                    string resRequired = Console.ReadLine();
                    if (resRequired == "Y" || resRequired == "y")   //if required
                    {
                        newReservationRequired = true;
                    }
                    else
                    {
                        newReservationRequired = false;         //if not required
                    }

                    Console.Write("Please enter a rating for new fine dining restaurant: "); //ask for rating
                    int newRestaurantRating = Convert.ToInt16(Console.ReadLine()); //store answer
                    restaurantList.Add(new FineDining(newRestaurantName, newReservationRequired, newRestaurantRating, newCuisineType)); //add to restaurant list
                    Console.WriteLine("New restaurant has been added to the list. Printing out new list.");
                    break;
                case "FF":
                case "ff":
                    Console.Write("Please enter if drive thru is available (Y or N): "); //ask if there is a drive thru
                    string resDriveThru = Console.ReadLine();   //store answer
                    if (resDriveThru == "Y" || resDriveThru == "y") //if there is a drive thru
                    {
                        newDriveThru = true;
                    }
                    else       //if there is not a drive thru
                    {
                        newDriveThru = false;
                    }
                    restaurantList.Add(new FastFood(newRestaurantName, newDriveThru, newCuisineType)); //add to the restaurant list
                    Console.WriteLine("New restaurant has been added to the list. Printing out new list.");
                    break;
                    default:
                    Console.WriteLine("Please enter valid information.");
                    break;
 
            } //end of switch
            //Print the list
            foreach (Restaurant anRestaurant in restaurantList)
            {
                Console.WriteLine(anRestaurant);
            } // end foreach

            //DELETE a restaurant
            //==============================================================================
            Console.Write("Please enter restaurant name to be deleted: ");  //ask for restaurant name to be deleted
            string findRestaurantName = Console.ReadLine();  //store answer
            found = false;
            for (int index = 0; index <restaurantList.Count; index++) //looks through restaurant list
            {
                if((restaurantList[index].RName == findRestaurantName)) //find the restaurant name
                {
                    restaurantList.RemoveAt(index); //remove from the list
                    found = true;
                }

            } //end of for loop
            if (found)
                Console.WriteLine("Restaurant has been deleted.");
            else
                Console.WriteLine("Restaurant not found.");

            //Print the list
            foreach (Restaurant anRestaurant in restaurantList)
            {
                Console.WriteLine(anRestaurant);
            }   

        //Updating the rating of a restaurant
        //=========================================================
        Console.Write("Please enter the restaurant name to be updated. ");
        findRestaurantName = Console.ReadLine();  //store answer
            found = false;
            int newRating = 0;
            for (int index = 0; index <restaurantList.Count; index++) //looks through restaurant list
            {
                if((restaurantList[index].RName == findRestaurantName)) //find the restaurant name
                {
                    Console.WriteLine("Please enter new rating for " + restaurantList[index].RName);
                    newRating = Convert.ToInt32 (Console.ReadLine());
                    restaurantList[index].restRating =newRating;
                    found = true;
                }

            } //end of for loop
            if (found)
                Console.WriteLine("Restaurant has been updated with new rating.");
            else
                Console.WriteLine("Restaurant not found.");

            //Print the list
            foreach (Restaurant anRestaurant in restaurantList)
            {
                Console.WriteLine(anRestaurant);
            }   

        











        } //End of Main

    } //End of class

} // End of namespace
