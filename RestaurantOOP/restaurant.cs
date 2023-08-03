using System;

namespace RestaurantOOP
{
    class Restaurant
    {
        //Variables
//Version 1
        /*
        public string? name;                                //Attribute
        public string? cuisine;                             //Attribute
        public int rating;                                  //Attribute
        public string? comment = "This food is delicious!!";//Attribute
        public string getComment()                          //Method
        {return comment;}
        */

//Version 2
        private string name;                //Private(local) Default Attribute
        private string cuisine;                //Private(local) Default Attribute
        private int rating;                             //Private(local) Default Attribute
        private string comment;             //Private(local) Default Attribute
        
        //Default Constructor
        public Restaurant()
        {
           name = "Undefined Name"; 
           cuisine = "Undefined Cuisine"; 
           rating = -1;
           comment = "Undefined Comment";
        }
        public Restaurant(string newName, string newCuisine, int newRating, string newComment)
        {
           name = newName; 
           cuisine = newCuisine; 
           rating = newRating;
           comment = newComment;
        }
        
        public string getName()                             //Public Method giving access to Private attribute Name
        {
            return name;                                    //Returns default for attribute name
        }
        public void setName(string newName)                 //Public method giving access to Private attribute Name
        {                                                   
            name = newName;                                 //Reassign/change the value of name
        }
        public string getCuisine()                         //Public Method giving access to Private attribute Cuisine
        {
            return cuisine;                                 //Returns default for attribute name
        }
        public void setCuisine(string newCuisine)           //Public method giving access to Private attribute Cuisine
        {
            cuisine = newCuisine;                           //Reassign/change the value of cuisine
        }
        public int getRating()                              //Public Method giving access to Private attribute Rating
        {
            return rating;                                   //Returns default for attribute rating
        }
        public void setRating(int newRating)                //Public method giving access to Private attribute Rating
        {
            rating = newRating;                             //Reassign/change the value of rating
        }
        public string getComment()                             //Public Method giving access to Private attribute Comment
        {
            return comment;                                     //Returns default for attribute comment
        }
        public void setComment(string newComment)               //Public method giving access to Private attribute Comment
        {
            comment = newComment;                               //Reassign/change the value of comment
        }

        //To-String
        public override string ToString()
        {
           return "Restaraunt: " + name + " rating: " + rating + " \ncuisine:" + cuisine + " comment:" + comment +"\n\n";
        }

    }
}
