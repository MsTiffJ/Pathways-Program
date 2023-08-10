using System;

namespace BankAccountChallenge
{
    class Savings : MainAccount
    {
        //Variables =========================================================================

        //Properties ========================================================================
        public double savingsIntRate                //Property for savings interest rate
        {get; set;}


        //Constructor========================================================================
        public Savings() : base()               //default 
        {
            savingsIntRate = 0;
        }
        
        public Savings(int newAccountID, double newAccountBalance, string? newAccountType, double newSavingsIntRate) : base(newAccountID,newAccountBalance,newAccountType)
        {
            savingsIntRate = newSavingsIntRate;
        }
        //Methods   =========================================================================
        
        // To-String ============================================================================
        public override string ToString()
        {
            return base.ToString() + " || Savings Interest Rate Percentage: " + savingsIntRate + "%";
        }

    } //End of Class

} // End of namespace