using System;

namespace BankAccountChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a list of Accounts====================================================
            List<MainAccount> bankingAccountList = new List<MainAccount>();

            //Test Data for Default=========================================================
            //bankingAccountList.Add(new MainAccount());
            //bankingAccountList.Add(new MainAccount(111000222, 50.00, " Main Account"));

            //Test Data for Savings Acct=========================================================
            bankingAccountList.Add(new Savings());
            bankingAccountList.Add(new Savings(211000221, 70.00, " Savings Account", 10));

            //Test Data for Checkings Acct=========================================================
            bankingAccountList.Add(new Checking());
            bankingAccountList.Add(new Checking(311000331, 30.00, " Checking Account", 20));

            //Test Data for CD Acct================================================================
            bankingAccountList.Add(new CD());
            bankingAccountList.Add(new CD(411000441, 40.00, " CD Account", 30));

            //Print the list====================================================================
            foreach (MainAccount anMainAccount in bankingAccountList)
            {
                Console.WriteLine(anMainAccount + " \n");

            } // end foreach

            //Deposit ====================================================================
            Console.WriteLine("Deposit \n");                                   //In the Deposit area
            Console.WriteLine("Enter account number \n");                      //Asking for account number
            int findAccount = Convert.ToInt32(Console.ReadLine());           //store account number to find into a variable
            double newDepositAmount = 0;                                    //variable used to store the deposit amount
            bool found = false;                                              //set boolean found to false (statement right now it is false)
            foreach (MainAccount anMainAccount in bankingAccountList)        //loop to search the account list for the account ID
            {
                if (anMainAccount.accountID == findAccount)                 //if there is a match on the account ID
                {
                    Console.WriteLine(findAccount + " has been found.");    //then message that account ID has been found
                    do
                    {
                        Console.WriteLine("Please enter deposit amount \n");     //ask for the deposit amount
                        newDepositAmount = Convert.ToDouble(Console.ReadLine()); //store the deposit amount
                        //anMainAccount.depositAmount = newDepositAmount;           //setting the main deposit amount for the method
                        if (newDepositAmount > 0)                       //if deposit amount is greater than 0 condition 
                        {
                            anMainAccount.Deposit(newDepositAmount);                                //method for making the deposit
                            Console.WriteLine(anMainAccount + " \n");
                        }
                        else
                            Console.WriteLine("Please enter a deposit amount greater than 0."); //prompt if amount is not greater than 0
                    }
                    while (newDepositAmount <= 0);                   // if deposit is not greater than or equal to 0
                    found = true;                                               //set boolean found to true
                }

            } //end of foreach loop
            if (!(found))
                Console.WriteLine(findAccount + " not found.");

        } //End of Main

    } //End of Class

} // End of namespace
