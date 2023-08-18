using System;

namespace BankAccountChallenge
{
    class CD : MainAccount, IAnnualAmountEarned
    {
         //Variables =========================================================================
        public double penaltyAmount = .1;                           //10% penalty for withdrawing from CD
        //Properties ========================================================================
        public double cDIntRate                //Property for CD interest rate
        {get; set;}

        //public double annualAmountEarned
         //   { get; set;}


        //Constructor========================================================================
        public CD() : base()               //default 
        {
            cDIntRate = 0;
        }
       // public void setAnnualAmountEarned(double newAnnualAmountEarned) //interface method
       // {
        //    newAnnualAmountEarned = cDIntRate*accountBalance;
            
       // }
        public double GetAnnualAmountEarned()     //interface method
        {
            return cDIntRate*accountBalance;;
        }
        public CD(int newAccountID, double newAccountBalance, string? newAccountType, double newCDIntRate) : base(newAccountID,newAccountBalance,newAccountType)
        {
            cDIntRate = newCDIntRate;

        }
        //Methods   =========================================================================
        public override double Withdrawal()
        {
            if(withdrawalAmount +(withdrawalAmount * penaltyAmount) < accountBalance )                   //if account withdrawal and penalty can be covered by the account balance
             {
             accountBalance -= withdrawalAmount +(withdrawalAmount * penaltyAmount);
             return accountBalance;
             }
            else
            {
                Console.WriteLine("Please enter a valid amount that includes the 10% penalty and is available in your account balance");
                return -999999;                                      //obscure value to trigger a message
            } 
        }
        // To-String ============================================================================
        public override string ToString()
        {
            return base.ToString() + " || CD Interest Rate Percentage: " + (cDIntRate*100) + "%" + " || Annual Income Earned $: " + GetAnnualAmountEarned();
        }
    } //End of Class

} // End of namespace