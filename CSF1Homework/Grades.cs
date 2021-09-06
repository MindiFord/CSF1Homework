using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class Grades
    {
        static void Main(string[] args)
        {

            #region Instructions
            /*
             * Write a program that asks the user for scores (like they would receive on a test) and then displays each score. The program should stop asking for scores and displays the results when the user enters a negative score.
             */
            #endregion

            string userScores = "";
            string userInputString;
            int userInputInt;
            bool negative = false;

            Console.WriteLine("Please enter the scores you want to record, once at a time. \nEntering a negative number will cause the program to end and display all of the scores you entered.\n");
            do
            {
                userInputString = Console.ReadLine();
                userInputInt = Convert.ToInt32(userInputString);
                    if (userInputInt >= 0)
                    {
                        userScores += "\n" + userInputString;
                    }
                    else
                    {
                    negative = true;
                    }
            } while (negative == false);
            Console.Clear();
            Console.WriteLine($"Your scores: \n{userScores}");

        }
    }
}
