using System;

namespace ClubMembership
{
    class Corporate : MembershipClub
    {

        //Variable =============================================================================

        //Properties ===========================================================================

        public double cashBackPercent                        //property for cash back percentage
        { get; set; }

        //Constructors==========================================================================

        public Corporate() : base()               //default 
        {
            cashBackPercent = 0;
        }

        public Corporate(string? newMemberID, string? newContactEmail, string? newMembershipType, double newAnnualCost, double newMonthlyPurchases, double newCashBackPercent) : base(newMemberID, newContactEmail, newMembershipType, newAnnualCost, newMonthlyPurchases) //passing through variables
        {
            cashBackPercent = newCashBackPercent;
        }

        //Methods ==============================================================================
        public override double getCashBackReward()                          //cash back reward method
        {
            return (monthlyPurchases * cashBackPercent) * applyCashCounter;
        }
        // To-String ============================================================================
         public override string ToString()

        {
            return base.ToString() + " || Cash Back Percentage " + (cashBackPercent*100) + "%" + " \n \t \tCash Back balance $" +
            getCashBackReward().ToString("0.00");
        }

    } //End of Class

} //End of Namespace