using System;

namespace RestaurantClass                              //Namespace for all files must be the same
{
    class Restaurant                                   //Class for all files must be unique                  
    {
        //Variables
        public string RName                            //Property for Restaurant Name
        { get; set; }
        public int RRating                             //Property for Rating
        { get; set; }

        //Default Constructor
        public Restaurant()                            //Same as class name
        {
            RName = null;
            RRating = -1;
        }
        public Restaurant (string newRestaruant, int newRating)
        {
            RName = newRestaruant;
            RRating = newRating;
        }
       

        
        //To-String
        public override string ToString()
        {
            return "Restaraunt: " + RName + " Rating:" + RRating;
        }
    } //end of class
   
} //end of namspace