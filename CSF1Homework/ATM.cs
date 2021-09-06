using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class ATM
    {
        static void Main(string[] args)
        {
            #region Instructions
            /* 
             * 1. Ask the user to enter an account number for their account
             *    * Continue to ask for account number until they get it right. (Match hard-coded acct number)
             *    * Optionally, lock them out after a certain number of attempts
             *    
             * 2. Ask user for pin. Keep prompting until they get it correct (Match hard-coded password)
             * 
             * 3. Once "logged in", prompt the user with a menu and ask them if they want to do a deposit, a withdrawal, or 
             *    exit the application.
             *    
             * 4. If they choose deposit, ask for amount to be deposited, and display amount deposited
             *    * Ex: "$500 has been withdrawn from account number 12345"
             *    
             * 5. If they choose to withdraw money, ask them for the amount to withdraw and display the amount being
             *    withdrawn
             *    * Ex: $500.00 has been withdrawn from account number 12345
             *   
             * 6. After each transaction (deposit or withdrawal) ask the user if they want to do another 
             *    deposit/withdrawal, or exit the application
             *    
             * 7. When the user exits the application, thank them for their business
             * 
             * OPTIONAL FEATURES:
             * 
             * 8. Keep a running total of the account balance, assuming that the account starts at $0.
             * 
             * 9. Every time the user makes a deposit to - or withdrawal from - the account, the balance
             *    should be updated and displayed
             *    
             * 10. Add a feature to make a balance request that will display their current balance (without needing to make a  
             *     deposit or withdrawal.
             */
            #endregion

            Console.WriteLine("Welcome to Some Bank!!\n\n");
            string accountNbr = "12345";
            bool accountAccess = false;
            bool programRunning = true;
            int accountAttempt = 1;
            decimal amountInAccount = 0;

            do
            {

                Console.Write("Enter your account number: ");
                string userAccount = Console.ReadLine();

                if (accountNbr == userAccount)
                {
                    //proceed to pin
                    string accountPin = "54321";
                    bool pinAccess = false;
                    int pinAttempt = 1;

                    do //Pin access
                    {
                        Console.Write("Enter your pin: ");
                        string userPin = Console.ReadLine();

                        if (accountPin == userPin)
                        {
                            Console.Clear();
                            Console.WriteLine("Welcome to your Some Bank ATM application!\n\n   ");
                            bool userContinue = true;

                            do//Menu
                            {


                                Console.WriteLine("\nWhat would you like to do?\n1) Deposit\n2) Withdrawal\n3) Balance\n4) Exit\n");

                                string userChoice = Console.ReadLine().ToUpper();

                                switch (userChoice)
                                {
                                    case "1":
                                    case "D":
                                    case "DEPOSIT":
                                        Console.Write("\nHow much would you like to deposit? ");
                                        decimal depositAmt = Convert.ToDecimal(Console.ReadLine());
                                        Console.WriteLine($"\n{depositAmt:c} has been deposited into account number {accountNbr}.");
                                        amountInAccount += depositAmt;
                                        break;

                                    case "2":
                                    case "W":
                                    case "WITHDRAWAL":
                                        Console.Write("\nHow much would you like to withdraw? ");
                                        decimal withdrawalAmt = Convert.ToDecimal(Console.ReadLine());
                                        Console.WriteLine($"\n{withdrawalAmt:c} has been withdrawn from account number {accountNbr}.");
                                        amountInAccount -= withdrawalAmt;
                                        break;

                                    case "3":
                                    case "B":
                                    case "BALANCE":
                                        Console.WriteLine($"\nYour current balance is {amountInAccount:c}.");
                                        break;

                                    case "4":
                                    case "E":
                                    case "X":
                                    case "EXIT":
                                        Console.WriteLine($"\nYou currently have {amountInAccount:c} in your account.");
                                        Console.WriteLine("\nThank you for visiting Some Bank!\n");
                                        userContinue = false;
                                        break;

                                    default:
                                        Console.WriteLine("Please enter a valid option.");
                                        break;
                                    
                                }//END SWITCH - MENU
                            } while (userContinue);
                            programRunning = false;
                            pinAccess = true;
                        }//END IF accountPin == userPin

                        else
                        {

                            if (pinAttempt < 3)
                            {

                                Console.WriteLine("Pin incorrect.");
                                pinAttempt++;

                            }

                            else
                            {
                                Console.WriteLine("Too many unsuccessful attempts. Access denied.");
                                pinAccess = true;
                                accountAccess = true;
                                programRunning = false;

                            }

                        }//END ELSE accountPin == userPin

                    } while (pinAccess == false);

                }

                else
                {

                    do
                    {

                        if (accountAttempt < 3)
                        {
                            Console.WriteLine("Account number not recognized.");
                            accountAttempt++;
                            accountAccess = true;
                        }

                        else
                        {
                            Console.WriteLine("Too many unsuccessful attempts. Access Denied.");
                            accountAccess = true;
                            programRunning = false;

                        }
                    } while (accountAccess == false);


                }//END ELSE Account Access

            } while (programRunning == true);


        }//END MAIN
    }
}
