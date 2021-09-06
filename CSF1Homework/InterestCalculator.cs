using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class InterestCalculator
    {
        static void Main(string[] args)
        {
            /*
             * Write a program to calculate interest for a given amount. The program should ask the user for a beginning 
             * balance, interest rate, and a number of years. Print the amount of money they would have (after the 
             * specified number of years) if the money is compounded annually with no additional deposits.
             * 
             * For example:
             * Enter the beginning balance: 1000.00
             * Enter the interest rate percentage: 5
             * Enter the number of years: 2
             * The amount you will have in 2 years is $1102.50.
             */

            Console.WriteLine("Interest Calculator\n");

            Console.Write("Enter the beginning balance: ");
            decimal begBalance = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Enter the interest rate percentage (ex: 5): ");
            decimal intRate = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Enter the number of years: ");
            int years = Convert.ToInt32(Console.ReadLine());

            int interestYears = 1;
            decimal balance = 0;

            do
            {
                if (interestYears == 1)
                {
                    balance = begBalance + (begBalance * (intRate / 100));
                }

                else
                {
                    balance = balance + (balance * (intRate / 100));
                }


                interestYears++;
            } while (interestYears <= years);

            Console.WriteLine($"\n\nThe amount you will have in {years} years is {balance:c}");
        }
    }
}
