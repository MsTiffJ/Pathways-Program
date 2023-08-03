using System;

namespace RestaurantClass                              //Namespace for all files must be the same
{
    class FineDining : Restaurant                                 //Class for all files must be unique                  
    {
         public bool RReservation
         {get; set;}

    public FineDining () : base()
    {
        RReservation = false;
    }
    public FineDining (string newRestaruant, int newRating, bool newReservationRequired) : base(newRestaruant,newRating)
    {
        RReservation =newReservationRequired;
    }

        public override string ToString()
        {
            return base.ToString() + " Reservation required?: " + RReservation;
        }

         
    } //End of Class
} //End of namespace
