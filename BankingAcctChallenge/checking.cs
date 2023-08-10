using System;

namespace BankAccountChallenge
{
    class Checking : MainAccount
    {
        //Variables =========================================================================

        //Properties ========================================================================
        public double checkingsIntRate                //Property for checking interest rate
        {get; set;}


        //Constructor========================================================================
        public Checking() : base()               //default 
        {
            checkingsIntRate = 0;
        }
        
        public Checking(int newAccountID, double newAccountBalance, string? newAccountType, double newCheckingsIntRate) : base(newAccountID,newAccountBalance,newAccountType)
        {
            checkingsIntRate = newCheckingsIntRate;
        }
        //Methods   =========================================================================
        
        // To-String ============================================================================
        public override string ToString()
        {
            return base.ToString() + " || Checking Interest Rate Percentage: " + checkingsIntRate + "%";
        }


    } //End of Class

} // End of namespace