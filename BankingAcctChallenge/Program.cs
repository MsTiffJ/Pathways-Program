using System;

namespace BankAccountChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
             bool userOption;
            string? userOptionString;
            
            //Create a list of Accounts====================================================
            List<MainAccount> bankingAccountList = new List<MainAccount>();

            //Test Data for Default=========================================================
            //bankingAccountList.Add(new MainAccount());
            //bankingAccountList.Add(new MainAccount(111000222, 50.00, " Main Account"));

            //Test Data for Savings Acct=========================================================
            bankingAccountList.Add(new Savings());
            bankingAccountList.Add(new Savings(211000221, 70.00, " Savings Account", .10));

            //Test Data for Checkings Acct=========================================================
            bankingAccountList.Add(new Checking());
            bankingAccountList.Add(new Checking(311000331, 30.00, " Checking Account", .20));

            //Test Data for CD Acct================================================================
            bankingAccountList.Add(new CD());
            bankingAccountList.Add(new CD(411000441, 40.00, " CD Account", .30));

            //Print the list====================================================================
            foreach (MainAccount anMainAccount in bankingAccountList)
            {
                Console.WriteLine(anMainAccount + " \n");

            } // end foreach
            do
            {
                // Get a valid input
                do
                {
                    //  Initialize variables

                    userOption = false;

                    // Provide the user a menu of options

                    Console.WriteLine("Choose a list option: ");
                    Console.WriteLine("L: List all of the accounts");
                    Console.WriteLine("D: Perform a deposit transaction.");
                    Console.WriteLine("W: Perform a withdrawal transaction.");
                    Console.WriteLine("Q: Quit banking needs.");
                    //  Get a user option (valid means its on the menu)

                    userOptionString = Console.ReadLine();

                    userOption = (userOptionString == "L" || userOptionString == "l" ||
                                userOptionString == "D" || userOptionString == "d" ||
                                userOptionString == "W" || userOptionString == "w" ||
                                userOptionString == "Q" || userOptionString == "q");
                    if (!userOption)
                    {
                        Console.WriteLine("Please enter a valid option.");
                    }

                }
                while (!userOption);
                //If the option is L or l then Load the single text file into the program.

                if (userOptionString == "L" || userOptionString == "l")
                {
                    Console.WriteLine("Printing a list of all accounts."); ;

                    foreach (MainAccount anMainAccount in bankingAccountList)
                    {
                        Console.WriteLine(anMainAccount + " \n");

                    } // end foreach
                } //end of if for L
                  //Deposit ====================================================================

                else if (userOptionString == "D" || userOptionString == "d")
                {
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
                } //End of D Option
                //Withdrawal======================================================================
                else if (userOptionString == "W" || userOptionString == "w")
                {
                    Console.WriteLine("Withdrawal \n");                                   //In the Withdrawal area
                    Console.WriteLine("Enter account number \n");                      //Asking for account number
                    int findAccount = Convert.ToInt32(Console.ReadLine());           //store account number to find into a variable
                    double newWithdrawalAmount = 0;                                    //variable used to store the Withdrawal amount
                    bool found = false;
                    double result = 0;                                              //set boolean found to false (statement right now it is false)
                    foreach (MainAccount anMainAccount in bankingAccountList)        //loop to search the account list for the account ID
                    {
                        if (anMainAccount.accountID == findAccount)                 //if there is a match on the account ID
                        {
                            Console.WriteLine(findAccount + " has been found.");    //then message that account ID has been found
                            do
                            {
                                Console.WriteLine("Please enter Withdrawal amount \n");     //ask for the Withdrawal amount
                                newWithdrawalAmount = Convert.ToDouble(Console.ReadLine()); //store the Withdrawal amount
                                anMainAccount.withdrawalAmount = newWithdrawalAmount;
                                result = anMainAccount.Withdrawal();                 //method for making the Withdrawal
                                Console.WriteLine(anMainAccount + " \n");

                            }
                            while (result < 0);                 // if Withdrawal is greater than or equal to acct balance
                            found = true;                                               //set boolean found to true

                        }

                    } //end of foreach loop
                    if (!(found))
                        Console.WriteLine(findAccount + " not found.");
                }// End of W Option
                //Finish the Q option======================================================================== 

                //Else if the option is a Q or q then quit the program
                else
                {
                    Console.WriteLine("Good-bye!");
                }
                //Finish the Q option 
            }//End of Main do while
            while (!(userOptionString == "Q") && !(userOptionString == "q")); //End of do while loop


        } //End of Main

    } //End of Class

} // End of namespace
