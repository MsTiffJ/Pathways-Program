using System;

namespace ClubMembership
{
    class Regular : MembershipClub
    {

        //Variable =============================================================================

        //Properties ===========================================================================

        public double cashBackPercent                        //property for cash back percentage
        { get; set; }

        //Constructors==========================================================================

        public Regular() : base()               //default 
        {
            cashBackPercent = 0;
        }

        public Regular(string? newMemberID, string? newContactEmail, string? newMembershipType, double newAnnualCost, double newMonthlyPurchases, double newCashBackPercent) : base(newMemberID, newContactEmail, newMembershipType, newAnnualCost, newMonthlyPurchases) //passing through variables
        {
            cashBackPercent = newCashBackPercent;
        }


        //Methods ==============================================================================
        public override double getCashBackReward()              //Method for cashback reward
        {
            return (monthlyPurchases * cashBackPercent) * applyCashCounter;
        }

        public double GetSpecialOffer ()                    //Interface for special offer
        {
            return annualCost*.25;
        }
        // To-String ============================================================================

         public override string ToString()

        {
            return base.ToString() + " || Cash Back Percentage " + (cashBackPercent * 100) + "%" + " \n \t \tCash Back balance $" +
            getCashBackReward().ToString("0.00");
        }

    } //End of Class

} //End of Namespace