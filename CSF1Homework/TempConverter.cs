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
            #region Instructions

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

            #endregion

            bool repeat = true;
            Console.WriteLine("Welcome to Temperature Converter!");

            do
            {

                Console.WriteLine("\nWhich would you like to do? (Enter 1 or 2)\n1) Convert Celcius to Fahrenheit\n2) Convert Fahrenheit to Celcius");
                string userChoice = Console.ReadLine();

                switch (userChoice)
                {
                    case "1":
                        Console.WriteLine("\nEnter a temperature in Celcius to convert to Fahrenheit: ");
                        double userInputC = Convert.ToDouble(Console.ReadLine());

                        double cToF = userInputC * (9.0 / 5.0) + 32;
                        Console.WriteLine($"{userInputC} degrees Celcius converts to {cToF} degrees Fahrenheit.");
                        break;

                    case "2":
                        Console.WriteLine("\nEnter a temperature in Fahrenheit to convert to Celcius: ");
                        double userInputF = Convert.ToDouble(Console.ReadLine());

                        double fToC = (userInputF - 32) / (9.0 / 5.0);
                        Console.WriteLine($"{userInputF} degrees Fahrenheit converts to {fToC} degrees Celcius");
                        break;

                    default:
                        Console.WriteLine("\nPlease enter a valid response.");
                        break;
                }

                Console.WriteLine("\nDo you have another conversion? (Y/N)");

                string anotherConversion = Console.ReadLine().ToUpper();

                Console.Clear();

                switch (anotherConversion)
                {
                    case "Y":
                    case "YES":
                        continue;

                    case "N":
                    case "NO":
                        Console.WriteLine("Thank you for using Temperature Converter!");
                        repeat = false;
                        break;
                    default:
                        break;
                }

            } while (repeat);



        }
    }
}
