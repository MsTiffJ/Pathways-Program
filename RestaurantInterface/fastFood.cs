using System;

namespace FoodInterfaceCRUD                              //Namespace for all files must be the same
    {
        class FastFood : Restaurant, ICuisine, IRating                   //Class inheriting Restaurant 
        {

        //Variables

        public bool RDriveThru
        { get; set;} 

        public string restCuisine
        {get; set;}

        public int restRating
        { get; set;}

        //Default Constructors

        public FastFood()                             //Not passing anything
        {
            RDriveThru = true;
        }
        public void SetCuisine(string newCuisine) //interface method
        {
            restCuisine = newCuisine;
        }

      public void SetRating(int newRating) //interface method
        {
            restRating = newRating;
        }
        public int GetRating()     //interface method
        {
            return restRating;
        }
        public string GetCuisine()  //interface method
        {
            return restCuisine;
        }
        public FastFood(string newRestaurant, bool newDriveThru, string newCuisine) : base(newRestaurant)  //Passing something through
        {
            RDriveThru = newDriveThru;
            restCuisine = newCuisine;
        }

        //To-String

        public override string ToString()
        {
            return base.ToString() + " - Drive through available?: " + RDriveThru + " - Cuisine type:" + restCuisine;
        }


        } //End of class

    } //End of namespace
