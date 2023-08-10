using System;

namespace FoodInterfaceCRUD                              //Namespace for all files must be the same
    {
        class FineDining : Restaurant, IRating, ICuisine                   //Class inheriting Restaurant 
        {

        //Variables

        public bool RReservation
        { get; set;} 

        public int restRating
        { get; set;}

        public string restCuisine
        {get; set;}

        public void SetRating(int newRating) //interface method
        {
            restRating = newRating;
        }
        public int GetRating()     //interface method
        {
            return restRating;
        }

        public void SetCuisine(string newCuisine) //interface method
        {
            restCuisine = newCuisine;
        }

        public string GetCuisine()  //interface method
        {
            return restCuisine;
        }
        //Default Constructors

        public FineDining()                             //Not passing anything
        {
            RReservation = false;
            restRating = 0;
            restCuisine = null;
        }

        public FineDining(string newRestaurant, bool newReservationRequired, int newRating, string newCuisine) : base(newRestaurant)  //Passing something through
        {
            RReservation = newReservationRequired;
            restRating = newRating;
            restCuisine = newCuisine;
        }

        //To-String

        public override string ToString()
        {
            return base.ToString() + " - Reservation required?: " + RReservation + " - Restaurant Rating:" + restRating + " - Cuisine type:" + restCuisine;
        }


        } //End of class

    } //End of namespace
