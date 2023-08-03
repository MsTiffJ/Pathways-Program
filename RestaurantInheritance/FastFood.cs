using System;

namespace RestaurantClass                              //Namespace for all files must be the same
{
    class FastFood : Restaurant                                 //Class for all files must be unique                  
    {
         public bool RDriveThru
         {get; set;}

    public FastFood () : base()
    {
        RDriveThru = true;
    }
    public FastFood (string newRestaruant, int newRating, bool newDriveThru) : base(newRestaruant,newRating)
    {
        RDriveThru =newDriveThru;
    }

        public override string ToString()
        {
            return base.ToString() + " Drive Thru?: " + RDriveThru;
        }

         
    } //End of Class
} //End of namespace
