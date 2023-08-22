using System;

namespace ClubMembership
{
    class Executive : MembershipClub, ISpecialOffer
    {

        //Variable =============================================================================
        public double topTierPurchase = 1000;           //Top Tier amount for cash-back reward
        public double topTierPercent = .35;             //Top Tier percent for cash-back reward
        //Properties ===========================================================================

        public double cashBackPercent                        //property for cash back percentage
        { get; set; }

        //Constructors==========================================================================

        public Executive() : base()               //default 
        {
            cashBackPercent = 0;
        }

        public Executive(string? newMemberID, string? newContactEmail, string? newMembershipType, double newAnnualCost, double newMonthlyPurchases, double newCashBackPercent) : base(newMemberID, newContactEmail, newMembershipType, newAnnualCost, newMonthlyPurchases) //passing through variables
        {
            cashBackPercent = newCashBackPercent;
        }
        //Methods ==============================================================================
        public override double getCashBackReward()
        {
            if(monthlyPurchases >= topTierPurchase)                                     //If $1000 tier is reached
            {
                cashBackPercent = topTierPercent;
                return (monthlyPurchases * topTierPercent) * applyCashCounter;    //Top Tier percentage applied to purchases for reward
                
            } 
            else
            {
                return (monthlyPurchases * cashBackPercent) * applyCashCounter;  //Standard percentage applied to purchases for reward
            }
        }

         public double GetSpecialOffer ()                   //Interface for special offer
        {
            return annualCost*.50;
        }

        // To-String ============================================================================

         public override string ToString()

        {
            return base.ToString() + " || Cash Back Percentage " + (cashBackPercent*100) + "%" + " \n \t \tCash Back balance $" +
            getCashBackReward().ToString("0.00");
        }

    } //End of Class

} //End of Namespace