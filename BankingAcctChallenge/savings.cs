using System;

namespace BankAccountChallenge
{
    class Savings : MainAccount, IAnnualAmountEarned
    {
        //Variables =========================================================================


        //Properties ========================================================================
        public double savingsIntRate                //Property for savings interest rate
        { get; set; }


        //Constructor========================================================================
        public Savings() : base()               //default 
        {
            savingsIntRate = 0;
        }
        public double getAnnualAmountEarned()     //interface method
        {
            return savingsIntRate*accountBalance;;
        }
        public Savings(int newAccountID, double newAccountBalance, string? newAccountType, double newSavingsIntRate) : base(newAccountID, newAccountBalance, newAccountType)
        {
            savingsIntRate = newSavingsIntRate;
        }
        //Methods   =========================================================================

        public override double Withdrawal()
        {
            if (withdrawalAmount < accountBalance)          //if Withdrawal amount is less than the account balance
            {
                accountBalance -= withdrawalAmount;
                return accountBalance;
            }
            else
            {
                Console.WriteLine("Please enter a withdrawal amount less than account balance."); //prompt if amount is less than amount in acct 
                return -99999;
            }
        }
        // To-String ============================================================================
        public override string ToString()
        {
            return base.ToString() + " || Savings Interest Rate Percentage: " + (savingsIntRate*100) + "%" + " || Annual Income Earned $: " + getAnnualAmountEarned();
        }

    } //End of Class

} // End of namespace