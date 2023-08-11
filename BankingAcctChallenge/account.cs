using System;

namespace BankAccountChallenge
{
    abstract class MainAccount
    {
       //Variable ===============================================================

       public double withdrawalAmount = 0;

      //Properties ===============================================================
      public int accountID              //property for account identification
      { get; set;}

      public double accountBalance      //property for account balance
      {get; set;}

      public string? accountType         //property for account type
      {get; set;}

      //Constructors===================================================================

      public MainAccount()                //Not passing anything through(default constructor)
      {

        accountID = -1;
        accountBalance = 0;
        accountType = "Empty";
        

      }

      public MainAccount(int newAccountID, double newAccountBalance, string? newAccountType) //passing values through
      {
        accountID = newAccountID;
        accountBalance = newAccountBalance;
        accountType = newAccountType;

      }

    //Methods ==============================================================================
     public double Deposit(double depositAmount)                 //Default method for performing deposits
     {
     
        accountBalance += depositAmount;
        return accountBalance;
        
       
     }
     public abstract double Withdrawal();
     

    // To-String ============================================================================

        public override string ToString()
        {
            return "Account Type:  " + accountType + " || Account number: " + accountID + " || Balance of $: " + accountBalance.ToString("0.00");
        }

        

    } //End of Class

} // End of namespace
