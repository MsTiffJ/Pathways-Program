using System;

namespace FoodInterfaceCRUD                              //Namespace for all files must be the same
    {
        class Restaurant
        {
           //Variables
           public string RName                  //Property for Restaurant name
           { get; set;}

            public int restRating
            { get; set;}

           //Default Constructor

           public Restaurant()                      //Not passing anything default
            {
           RName = null;
            }

            public Restaurant(string newRestaurant)  //Passing something through
            {
                RName = newRestaurant;
            }


        //To-String

        public override string ToString()           //Base
        {
            return "Restaurant Name: " + RName;
        }

        } // End of Restaurant

    } //End of namespace



