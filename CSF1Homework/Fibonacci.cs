using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class Fibonacci
    {

        static void Main(string[] args)
        {

            /* 
             * Write a program that outputs a Fibonacci sequence, starting at 1, until a number that the user inputs is reached
             */

            Console.WriteLine("Welcome to the Fibonacci Counter!\n");

            Console.Write("Please enter a whole number: ");
            int userNbr = Convert.ToInt32(Console.ReadLine());

            int fibNbr;
            int firstNbr = 0;
            int secondNbr = 1;

            do
            {

                Console.WriteLine(fibNbr = firstNbr + secondNbr);

                firstNbr = secondNbr;
                secondNbr = fibNbr;

            } while (secondNbr <= userNbr);

        }//end Main()
    }
}
