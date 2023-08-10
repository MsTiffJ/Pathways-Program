using System;

namespace BankAccountChallenge
{
    class CD : MainAccount
    {
         //Variables =========================================================================

        //Properties ========================================================================
        public double cDIntRate                //Property for CD interest rate
        {get; set;}


        //Constructor========================================================================
        public CD() : base()               //default 
        {
            cDIntRate = 0;
        }
        
        public CD(int newAccountID, double newAccountBalance, string? newAccountType, double newCDIntRate) : base(newAccountID,newAccountBalance,newAccountType)
        {
            cDIntRate = newCDIntRate;
        }
        //Methods   =========================================================================
        
        // To-String ============================================================================
        public override string ToString()
        {
            return base.ToString() + " || CD Interest Rate Percentage: " + cDIntRate + "%";
        }
    } //End of Class

} // End of namespace