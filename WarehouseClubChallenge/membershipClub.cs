using System;

namespace ClubMembership
{
    abstract class MembershipClub
    {

        //Variable =============================================================================

        public double currentPurchase = 0;                     //variable for current purchases
        public double currentReturn = 0;                        //variable for returns
        public int applyCashCounter = 1;                        //variable for cash back method

        //Properties ===========================================================================

        public string? memberID                             // property for membership ID
        { get; set; }

        public string? contactEmail                         // property for primary contact email address
        { get; set; }

        public string? membershipType                       // property for type of membership
        { get; set; }

        public double annualCost                            // property for annual cost
        { get; set; }

        public double monthlyPurchases                      // property for current amount of purchase for the month
        { get; set; }


        //Constructors==========================================================================

        public MembershipClub()                //Not passing anything through(default constructor)
        {

            memberID = "empty";
            contactEmail = "empty";
            membershipType = "empty";
            annualCost = 0;
            monthlyPurchases = 0;

        }

        public MembershipClub( string? newMemberID, string? newContactEmail, string? newMembershipType, double newAnnualCost, double newMonthlyPurchases)  //Passing values through
        {
            memberID = newMemberID;
            contactEmail = newContactEmail;
            membershipType = newMembershipType;
            annualCost = newAnnualCost;
            monthlyPurchases = newMonthlyPurchases;

        }

        //Methods ==============================================================================
        
        
        public abstract double getCashBackReward();                 //method for cashback reward

        public double Purchase (double currentPurchase)             //method for purchases
        {
            applyCashCounter = 1;
            monthlyPurchases = currentPurchase + monthlyPurchases;
            return monthlyPurchases;
        }

        public double Return (double currentReturn)             //method for returns
        {
            monthlyPurchases = monthlyPurchases - currentReturn;
            return monthlyPurchases;
        }

          // To-String ============================================================================

        public override string ToString()

        {
            return "Member ID:  " + memberID + " || Contact Email: " + contactEmail + " || Membership Type: " + membershipType + " \n \t \t|| Annual Cost $" + annualCost.ToString("0.00") + " || Monthly Purchase Amount $" + monthlyPurchases
            .ToString("0.00");

        }

    } //End of Class

} //End of Namespace