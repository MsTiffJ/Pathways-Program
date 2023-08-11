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
        public override double Withdrawal()
        {
            if(withdrawalAmount <= (accountBalance * .5))                   //if account withdrawal is 50% of account balance
             {
             accountBalance -= withdrawalAmount;
             return accountBalance;
             }
            else
            {
                Console.WriteLine("Please enter a valid amount less than or equal to half of account balance");
                return -999999;                                      //obscure value to trigger a message
            } 
        }
        // To-String ============================================================================
        public override string ToString()
        {
            return base.ToString() + " || Checking Interest Rate Percentage: " + (checkingsIntRate*100) + "%";
        }


    } //End of Class

} // End of namespace