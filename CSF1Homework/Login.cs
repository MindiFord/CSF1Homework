﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class Login
    {
        static void Main(string[] args)
        {

            #region Instructions
            /*
             * 1) Ask the user for thier username
             * 2) If it matches your one hard-coded, correct username, tell the user that they have access. If not, 
             *    tell the user that they have been denied access.
             * 3) Make sure the usernames (hard-coded & user input) are case sensitive (uppercase & lowercase)
             */
            #endregion
            #region Additional Functionality
            /* 
             * ADDITIONAL FUNCTIONALITY:
             * 4) Encase the username functionality in a loop that allows the user to make another attept if the 
             *    previous attempt was unsuccessful.
             * 5) Extend the loop functionality to deny access to the user if they enter the wrong username 3 times.
             * 6) Extend updated username functionality to ask for a password if the user entered the correct username.
             *    Deny access if the password is entered incorrectly 3 times. 
             *    (Note: 3 attempts at username, if the correct username is entered, give 3 attempts for the
             *    correct password.)
             */
            #endregion
            bool login = false;
            do
            {

                string username = "Username1";
                bool accessDeniedUser = false;//condition for DO WHILE username
                int usernameAttempt = 1;//counter for IF username
                do
                {

                    Console.Write("Enter your username: ");
                    string userInput = Console.ReadLine();

                    if (username == userInput)
                    {

                        //username is correct. Now they need to match password.
                        bool accessDeniedPass = false;
                        string password = "12345";
                        int passwordAttempt = 1;

                        do
                        {

                            Console.Write("Enter your password: ");
                            string userPassword = Console.ReadLine();

                            if (password == userPassword)
                            {
                                Console.WriteLine("Access Granted. Thank you for logging in!");
                                accessDeniedUser = true;
                                accessDeniedPass = true;
                                login = true;
                            }//END IF - PASSWORD ACCESS GRANTED

                            else
                            {

                                if (passwordAttempt < 3)
                                {
                                    Console.WriteLine("Password Incorrect. Please try again.");
                                    passwordAttempt++;
                                }

                                else
                                {
                                    Console.WriteLine("Too many unsuccessful attempts. Please contact our customer service department.");
                                    accessDeniedPass = true;

                                }

                            }//END ELSE - PASSWORD INCORRECCT

                        } while (accessDeniedPass == false);


                    }//END IF -USER ACCESS GRANTED


                    else //we're here if they incorrectly input username
                    {


                        if (usernameAttempt < 3)
                        {
                            Console.WriteLine("Username not recognized.");
                            usernameAttempt++;
                        }

                        else
                        {
                            Console.WriteLine("Too many unsuccessful attempts. Access denied.");
                            accessDeniedUser = true;
                            login = true;
                        }//END ELSE - USER ACCESS DENIED

                    }//END ELSE - INCORRECT USERNAME
                } while (accessDeniedUser == false);

            } while (login == false);

        }//END MAIN
    }
}
