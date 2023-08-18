using System;

namespace ClubMembership
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables====================================================================

            bool userOption;
            string? userOptionString;
            double membershipAnnualAdd = 0;
            double cashBackRewardPercent = 0;
            double newAnnualCost = 0;
            double currentPurchase = 0;
            double newPurchaseAmount = 0;
            double newReturnAmount = 0;

            //Create a list of Accounts====================================================
            List<MembershipClub> membershipAccountList = new List<MembershipClub>();

            //Test Data for Regular Acct=========================================================
            //membershipAccountList.Add(new Regular());
            membershipAccountList.Add(new Regular("Reg000111", "regularacct@warehouse.com", " Regular Account", 50, 30, .1));

            //Test Data for NonProfit Acct=========================================================
            //membershipAccountList.Add(new NonProfit());
            membershipAccountList.Add(new NonProfit("NonP000333", "nonprofitacct@warehousenonp.org", " Non-Profit Account", 200, 75, .2, 'M'));

            //Test Data for Executive Acct=========================================================
            // membershipAccountList.Add(new Executive());
            membershipAccountList.Add(new Executive("Exec000222", "executiveacct@warehouseexec.biz", " Executive Account", 300, 1200, .3));

            //Test Data for Corporate Acct=========================================================
            //membershipAccountList.Add(new Corporate());
            membershipAccountList.Add(new Corporate("Corp000444", "corporateacct@warehousecorp.com", " Corporate Account", 400, 150, .4));

            //Print the list====================================================================

            foreach (MembershipClub anMembershipClub in membershipAccountList)
            {
                Console.WriteLine(anMembershipClub + " \n");
            } // end foreach



            do
            {
                //Get a valid input===========================================================
                do
                {

                    //  Initialize variables=======================================================

                    userOption = false;


                    // Provide the user a menu of options=======================================

                    Console.WriteLine("Choose a list option: ");
                    Console.WriteLine("C: Create a new membership and add to membership list");
                    Console.WriteLine("R: Read all of the memberships in the membership list");
                    Console.WriteLine("U: Update an existing membership");
                    Console.WriteLine("D: Delete an existing membership");
                    Console.WriteLine("L: List all of the accounts");
                    Console.WriteLine("P: Perform a Purchase transaction.");
                    Console.WriteLine("T: Perform a Return transaction.");
                    Console.WriteLine("A: Apply Cash Back reward");
                    Console.WriteLine("Q: Quit banking needs.");
                    //  Get a user option=========================================================

                    userOptionString = Console.ReadLine();

                    userOption = (userOptionString == "C" || userOptionString == "c" ||
                                userOptionString == "R" || userOptionString == "r" ||
                                userOptionString == "U" || userOptionString == "u" ||
                                userOptionString == "D" || userOptionString == "d" ||
                                userOptionString == "L" || userOptionString == "l" ||
                                userOptionString == "P" || userOptionString == "p" ||
                                userOptionString == "T" || userOptionString == "t" ||
                                userOptionString == "A" || userOptionString == "a" ||
                                userOptionString == "Q" || userOptionString == "q");

                    if (!userOption)
                    {
                        Console.WriteLine("Please enter a valid option.");

                    }

                } //End of Input do while loop
                while (!userOption);

                //If User Option is L or l Start=============================================
                if (userOptionString == "L" || userOptionString == "l")
                {
                    Console.WriteLine("Printing a list of all accounts.");

                    foreach (MembershipClub anMembershipClub in membershipAccountList)       //For each item in the list 
                    {
                        Console.WriteLine(anMembershipClub + " \n");                          //Print 
                    }

                } //End of if for L option ==================================================
                //If User option is C or c Start=============================================
                else if (userOptionString == "C" || userOptionString == "c")
                {
                    char orgField = 'X';                                                        //Variables
                    double initialPurchase = 0;
                    bool parse = false;
                    string? memberTypeShort;
                    Console.WriteLine("What is the primary contact email for this new account?");       //ask for Email
                    string? primaryEmailAdd = Console.ReadLine();                                       //store email answer

                    Console.WriteLine("Please enter new membership annual cost");               //ask for annual cost
                    do                                                                  //do while loop for error checking in all areas
                    {
                        try                                                             //make sure the entry is a number
                        {
                            membershipAnnualAdd = Convert.ToDouble(Console.ReadLine());          //store annual cost answer
                            parse = true;                                                       //if its a number then set parse to true
                        }
                        catch (Exception e)                                                 //standard system exception
                        {
                            Console.WriteLine("Please enter a valid number for membership annual cost"); //catch if entry is not a number output message
                            parse = false;                                                  //if its not a number then set parse to false
                        }
                    }
                    while(parse == false);                                                  //keep doing this until a valid number is entered
                    
                    do
                    {                                                                           //Get membership type
                        Console.WriteLine("Please enter the new membership type you would like to add. (R/r-Regular, N/n-Non Profit, E/e-Executive, C/c-Corporate)");
                        memberTypeShort = Console.ReadLine();                                   //store answer
                        userOption = (memberTypeShort == "C" || memberTypeShort == "c" ||       //set options for membership type
                                   memberTypeShort == "R" || memberTypeShort == "r" ||
                                   memberTypeShort == "N" || memberTypeShort == "n" ||
                                   memberTypeShort == "E" || memberTypeShort == "e");

                        if (!userOption)                                                        //if user option is not selected 
                        {
                            Console.WriteLine("Please enter a valid membership type.");                  //give error message

                        }
                    } //End of do loop
                    while (!userOption);                                                        //if user option is selected
                    Console.WriteLine("Please enter cash back reward percentage");              //ask for cash back percentage
                    do
                    {
                        try
                        {
                            cashBackRewardPercent = Convert.ToDouble(Console.ReadLine());        //store answer
                            parse = true;
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Please enter a valid number for cash back reward percentage");
                            parse = false;
                        }
                    }
                    while(parse == false);

                    
                    int matchCount = 0;                                                         //variables
                    string? membershipID;
                    Random memNbr = new Random();                                               //generating a random integer
                    int num = memNbr.Next();                                                // that will be used to create the membership id
                    switch (memberTypeShort)                                                //start switch for membership type useroptions
                    {
                        case "R":
                        case "r":
                            membershipID = "Reg" + num.ToString();                          // concatenating a string for the membership ID
                            foreach (MembershipClub anMembershipClub in membershipAccountList)  // a loop to check all member ID's in the list
                            {
                                if(anMembershipClub.memberID == membershipID)               // if there is a match between the list member IDs and the new ID being created 
                                {matchCount ++;}                                            //increase the match count by one
                                else
                                {matchCount += 0;}                                          //otherwise do not increase
                            }
                            if(matchCount == 0)                                             //if the match is 0 (if the new memberid is unique)
                            {
                                membershipAccountList.Add(new Regular(membershipID, primaryEmailAdd, " Regular Account", membershipAnnualAdd, initialPurchase, cashBackRewardPercent));
                                Console.WriteLine("Account " + membershipID + " has been added."); // then add the new member ID and create a new record
                            }
                            break;                                                              //continue for each switch case

                        case "N":
                        case "n":
                            membershipID = "NonP" + num.ToString();
                            Console.WriteLine("Please indicate organizational type. M/m-Military or E/e-Educational");
                            orgField = Convert.ToChar(Console.ReadLine()!);
                            foreach (MembershipClub anMembershipClub in membershipAccountList)
                            {
                                if(anMembershipClub.memberID == membershipID)
                                {matchCount ++;}
                                else
                                {matchCount += 0;}
                            }
                            if(matchCount == 0)
                            {
                                membershipAccountList.Add(new NonProfit(membershipID, primaryEmailAdd, " Non-Profit Account", membershipAnnualAdd, initialPurchase, cashBackRewardPercent, orgField));
                                Console.WriteLine("Account " + membershipID + " has been added.");
                            }
                            break;

                        case "E":
                        case "e":
                            membershipID = "Exec" + num.ToString();
                            foreach (MembershipClub anMembershipClub in membershipAccountList)
                            {
                                if(anMembershipClub.memberID == membershipID)
                                {matchCount ++;}
                                else
                                {matchCount += 0;}
                            }
                            if(matchCount == 0)
                            {
                                membershipAccountList.Add(new Executive(membershipID, primaryEmailAdd, " Executive Account", membershipAnnualAdd, initialPurchase, cashBackRewardPercent));
                                Console.WriteLine("Account " + membershipID + " has been added. \n");
                            }
                            break;

                        case "C":
                        case "c":
                            membershipID = "Corp" + num.ToString();
                            foreach (MembershipClub anMembershipClub in membershipAccountList)
                            {
                                if(anMembershipClub.memberID == membershipID)
                                {matchCount ++;}
                                else
                                {matchCount += 0;}
                            }
                            if(matchCount == 0)
                            {
                                membershipAccountList.Add(new Corporate(membershipID, primaryEmailAdd, " Corporate Account", membershipAnnualAdd, initialPurchase, cashBackRewardPercent));
                                Console.WriteLine("Account " + membershipID + " has been added.");
                            }
                            break;
                        default:
                            Console.WriteLine("Please enter valid information.");
                            break;
                    }

                }

                //End of C option ===========================================================

                //If User option is R or r Start=============================================

                else if (userOptionString == "R" || userOptionString == "r")
                {
                    foreach (MembershipClub anMembershipClub in membershipAccountList)
                    {
                        Console.WriteLine(anMembershipClub.membershipType + " \n");                 //Print the Membership type in each line
                    } // end foreach
                } // End of else if
                //End of option R==============================================================
                //If User Option is U or u Start================================================
                else if (userOptionString == "U" || userOptionString == "u")

                {
                    Console.WriteLine("Please enter the Membership ID you would like to update");  //Ask for memberid to update
                    string? findMembershipID = Console.ReadLine();                                  //store the answer
                    Console.WriteLine("What would you like to update? (E/e for Contact Email or M/m for Membership Cost)"); //ask what needs to be updated
                    string? updateAnswer = Console.ReadLine();                                      //store the answer
                    bool found = false;
                    bool parse = false;                             
                    for (int index = 0; index < membershipAccountList.Count; index++)
                    {
                        if (membershipAccountList[index].memberID == findMembershipID)              //find memeberid
                        {
                            if (updateAnswer == "E" || updateAnswer == "e")                          //if updating email
                            {
                                Console.WriteLine("Enter the new primary contact email address for " + findMembershipID); //ask for new email for memberid
                                string? newContactEmail = Convert.ToString(Console.ReadLine());  //store answer
                                membershipAccountList[index].contactEmail = newContactEmail;     //replace old email with new email entered
                                found = true;
                            }
                            else if (updateAnswer == "M" || updateAnswer == "m")                        //if updating membership cost
                            {
                                Console.WriteLine("Enter the new Annual Membership Cost for " + findMembershipID); //ask for new membership cost for memberid
                                do
                                {
                                    try
                                    {
                                        newAnnualCost = Convert.ToDouble(Console.ReadLine());                //store new info
                                        parse = true;
                                    }
                                    catch (Exception e)
                                    {
                                        Console.WriteLine("Please enter a valid number for membership annual cost");
                                        parse = false;
                                    }
                                }
                                while(parse == false);
                                
                                
                                membershipAccountList[index].annualCost = newAnnualCost;                    //replace old membership cost with new
                                found = true;
                            }
                            else
                            {
                                Console.WriteLine("Please enter a valid option.");                      //error checking for update choices
                                found = false;
                            }

                        }
                    }//End of for loop
                    if (found)
                        Console.WriteLine(findMembershipID + " has been updated.");                     //after updates are done return member id and updated status
                    else
                        Console.WriteLine(findMembershipID + " has not been updated.");


                }//End of option U

                //If User option is D or d Start=================================================

                else if (userOptionString == "D" || userOptionString == "d")

                {
                    Console.WriteLine("Please enter the Membership ID you would like to delete");  //ask for  memberid to be deleted
                    string? findMembershipID = Console.ReadLine();                                  //store answer
                    bool found = false;
                    for (int index = 0; index < membershipAccountList.Count; index++)               //search through list 
                    {
                        if (membershipAccountList[index].memberID == findMembershipID)              //if memberid is found
                        {
                            membershipAccountList.RemoveAt(index);                                  //delete from list
                            found = true;   
                        }
                    }
                    if (found)
                        Console.WriteLine("Member ID has been deleted");                            //output to inform memberid is deleted
                    else
                        Console.WriteLine("Member ID has not been found");                      //output if memberid is not found
                }
                //End of option D ==========================================================
                //If User Option is P=========================================================
                else if (userOptionString == "P" || userOptionString == "p")
                {
                    Console.WriteLine("Please enter the Membership ID for which you would like to apply a purchase"); //ask for memberid to apply purchase
                    string? findMembershipID = Console.ReadLine();                                                      //store the answer
                    bool found = false;
                    bool parse = false; 
                    for (int index = 0; index < membershipAccountList.Count; index++)
                    {
                        if (membershipAccountList[index].memberID == findMembershipID)
                        {
                            do
                            {
                                Console.WriteLine("How much is the purchase amount?");                      //ask for purchase amount
                                do
                                {
                                    try
                                    {
                                        newPurchaseAmount = Convert.ToDouble(Console.ReadLine());                   //store answer
                                        parse = true;
                                    }
                                    catch (Exception e)
                                    {
                                        Console.WriteLine("Please enter a valid number for purchase amount");
                                        parse = false;
                                    }
                                }
                                while(parse == false);
                                
                                if (newPurchaseAmount > 0)                                                  //if purchase amount is greater than 0
                                {
                                    currentPurchase = newPurchaseAmount;                                    //add new purchase amount to current amount
                                    membershipAccountList[index].Purchase(currentPurchase);                 //use purchase method and add to list
                                    Console.WriteLine(newPurchaseAmount + " has been added to " + findMembershipID + " The new balance is " + membershipAccountList[index].monthlyPurchases);
                                }
                                else
                                {
                                    Console.WriteLine("Please enter a purchase amount greater than 0.");            //if amount is less than 0 give error
                                }
                            } //End of do while
                            while (newPurchaseAmount <= 0);                   // if purchase amount is not greater than or equal to 0
                            found = true;
                        }

                    } //End of for loop
                    if (!(found))
                        Console.WriteLine(findMembershipID + " not found.");

                } //End of Else if for P
                // End of Option P================================================================
                //If User Option is T=============================================================
                else if (userOptionString == "T" || userOptionString == "t")
                {
                    Console.WriteLine("Please enter the Membership ID for which you would like to apply a return");  //ask for memberid
                    string? findMembershipID = Console.ReadLine();                                                  //store answer
                    bool found = false;
                    bool parse = false;
                    double currentReturn = 0;
                    for (int index = 0; index < membershipAccountList.Count; index++)
                    {
                        if (membershipAccountList[index].memberID == findMembershipID)
                        {
                            do
                            {
                                Console.WriteLine("How much is the return amount?");                        //ask for return amount
                                do
                                {
                                    try
                                    {
                                        newReturnAmount = Convert.ToDouble(Console.ReadLine());                     //store answer
                                        parse = true;
                                    }
                                    catch (Exception e)
                                    {
                                        Console.WriteLine("Please enter a valid number for return amount");
                                        parse = false;
                                    }
                                }
                                while(parse == false);
                                
                                if (newReturnAmount > 0)                                                    //return amount is greater than 0
                                {
                                    currentReturn = newReturnAmount;                                        //subtract return amount to current amount
                                    membershipAccountList[index].Return(currentReturn);                     //use return method 
                                    Console.WriteLine(newReturnAmount + " has been subtracted from " + findMembershipID + " The remaining balance is " + membershipAccountList[index].monthlyPurchases);
                                }
                                else
                                {
                                    Console.WriteLine("Please enter a return amount greater than 0.");   // if return amount is not greater than or equal to 0
                                }
                            } //End of do while
                            while (newReturnAmount <= 0);                   // if return amount is not greater than or equal to 0
                            found = true;
                        }
                    }
                    if (!(found))
                        Console.WriteLine(findMembershipID + " not found.");                    //if memberid is NOT found

                } //End of Else if for T
                  // End of Option T================================================================
                  //If User Option is A=============================================================
                else if (userOptionString == "A" || userOptionString == "a")
                {
                    Console.WriteLine("Please enter the Membership ID for which you would like to apply for Cash Back"); //asking for memberid
                    string? findMembershipID = Console.ReadLine();                                                      //store answer
                    for (int index = 0; index < membershipAccountList.Count; index++)
                    {
                        if (membershipAccountList[index].memberID == findMembershipID)
                        {
                            Console.WriteLine(findMembershipID + " has been located. " + membershipAccountList[index].getCashBackReward() + " is available to apply. ");
                           do
                           {
                            Console.WriteLine("Would you like to apply the Cash Back? Y/y-Yes or N/n-No");          //ask to apply for cash back yes or no
                            string? cashBackAnswer = Console.ReadLine();                                            //store answer
                            userOption = (cashBackAnswer == "Y" || cashBackAnswer == "y" ||                         //answer options
                                   cashBackAnswer == "N" || cashBackAnswer == "n");

                                if (cashBackAnswer == "Y" || cashBackAnswer == "y")                                 //if yes option chosen
                                {
                                    Console.WriteLine("Cash-back reward request for membership " + findMembershipID +   //confirm the reward request with memberid and the amount is acceptable
                                        " in the amount of $" + membershipAccountList[index].getCashBackReward() + " has been granted.");
                                    membershipAccountList[index].applyCashCounter = 0;                                  //zero out the cash back by multiple by 0
                                    Console.WriteLine("Cash Back balance is now " + membershipAccountList[index].getCashBackReward() + "."); //confirm the balance is now 0

                                }
                                else if (cashBackAnswer == "N" || cashBackAnswer == "n")                                //if option is no for apply cash back
                                {
                                    Console.WriteLine("Cash Back has NOT been applied");                            //no action has been taken
                                }
                                else 
                                {
                                    Console.WriteLine("Please enter a valid option.");                          //making sure there is a valid option

                                }
                            } //End of do loop
                            while (!userOption);

                        }

                    }

                }


                // End of Option A================================================================

            } //End of Main do while loop
            while (!(userOptionString == "Q") && !(userOptionString == "q")); //End of do while loop    

        } //End of Main

    } //End of Class

} //End of Namespace
