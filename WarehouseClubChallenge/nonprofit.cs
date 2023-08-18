using System;

namespace ClubMembership
{
    class NonProfit : MembershipClub
    {

        //Variable =============================================================================

        //Properties ===========================================================================
        public double cashBackPercent                        //property for cash back percentage
        { get; set; }

        public char orgType                                 //property for organizational type
        { get; set; }


        //Constructors==========================================================================

        public NonProfit() : base()               //default 
        {
            cashBackPercent = 0;
        }

        public NonProfit(string? newMemberID, string? newContactEmail, string? newMembershipType, double newAnnualCost, double newMonthlyPurchases, double newCashBackPercent, char newOrgType) : base(newMemberID, newContactEmail, newMembershipType, newAnnualCost, newMonthlyPurchases) //passing through variables
        {
            cashBackPercent = newCashBackPercent;
            orgType = newOrgType;
        }

        //Methods ==============================================================================

        //applyCashCounter Variable is used to determine when a cashback reward has been applied
        
        public override double getCashBackReward()                          //cash back reward method
        {
            if (orgType == 'M' || orgType == 'm' || orgType == 'E' || orgType == 'e')       //if org type is military or education 
            {
                return (monthlyPurchases * (cashBackPercent*2)) * applyCashCounter;         //double the cashback percent and multiply by monthly purchases to get the reward amount
            }
            else
            {
                return (monthlyPurchases * cashBackPercent) * applyCashCounter;             //multiply the cashback percent by monthly purchases to get the reward amount
            }
        }
        // To-String ============================================================================
         public override string ToString()

        { 
            return base.ToString() + " || Cash Back Amount " + (cashBackPercent*100) + "%" + " \n \t \tCash Back balance $" +
            getCashBackReward().ToString("0.00");
        }

    } //End of Class

} //End of Namespace