using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class Fizzbuzz
    {
        static void Main(string[] args)
        {
            /*
             * Write a program that counts up from 1 to a number that the user enters. Any time a number divisible by three
             * would display, print the word "Fizz" instead. Any time you would normally display a number that is divisible
             * by 5, instead display the word "Buzz". Any time you would normally display a number that is divisible by 
             * both 3 & 5, display "FizzBuzz".
             */

            Console.WriteLine("Welcome to FizzBuzz!!\n");

            Console.Write("Please enter a whole number: ");

            int userNbr = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= userNbr; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }

                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }

            }//end for
        }//end Main()
    }
}
