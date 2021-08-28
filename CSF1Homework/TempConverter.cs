using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class TempConverter
    {
        static void Main(string[] args)
        {
            /*
             * 1. Write a program that asks the user for a temperature in Celcius and converts it to Fahrenheit.
             *    (fah = cel * (9.0/5.0) + 32)
             *    
             * 2. Write additional functionality that asks the user for a Fehrenheit temp and converts it to Celcius
             *    (cel = (fah - 32) / (9.0/5.0))
             *    
             * 3. Build out a menu that allows the user to choose whether they want to convert C to F or F to C
             * 
             * 4. Extend the functionality to ask the user if they have another conversion once you have shown them
             *    their initial result. Reload the menu if they choose yes.
             */

            bool repeat = true;

            do
            {

                Console.WriteLine("Which would you like to do? (Enter 1 or 2)\n1) Convert Celcius to Fahrenheit\n2) Convert Fahrenheit to Celcius");
                string userChoice = Console.ReadLine();

                switch (userChoice)
                {
                    case "1":
                        Console.WriteLine("Enter a temperature in Celcius to convert to Fahrenheit: ");
                        double userInputC = Convert.ToDouble(Console.ReadLine());

                        double cToF = userInputC * (9.0 / 5.0) + 32;
                        Console.WriteLine(cToF);
                        break;

                    case "2":
                        Console.WriteLine("Enter a temperature in Fahrenheit to convert to Celcius: ");
                        double userInputF = Convert.ToDouble(Console.ReadLine());

                        double fToC = (userInputF - 32) / (9.0 / 5.0);
                        Console.WriteLine(fToC);
                        break;

                    default:
                        Console.WriteLine("Please enter a valid response.");
                        break;
                }

                Console.WriteLine("Do you have another conversion? (Y/N)");

                string anotherConversion = Console.ReadLine().ToUpper();

                switch (anotherConversion)
                {
                    case "Y":
                    case "YES":
                        continue;

                    case "N":
                    case "NO":
                        repeat = false;
                        break;
                    default:
                        break;
                }

            } while (repeat);



        }
    }
}
