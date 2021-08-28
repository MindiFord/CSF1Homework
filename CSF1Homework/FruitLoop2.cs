using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class FruitLoop2
    {
        static void Main(string[] args)
        {

            /*Declare and initialize an array of any six fruit names (as text). Set up a FOR loop
             * and iterate through them (displaying each value in the console).
             * 
             * For each of the fruit names that you display, on the next line display a number of periods
             * that is equal to the number of the index of the array.
             */

            string[] fruits = { "peach", "plum", "papaya", "pineapple", "pomegranate", "persimmon" };
            string period = ".";

            for (int fruit = 0; fruit < fruits.Length; fruit++)
            {
                Console.WriteLine($"You have a {fruits[fruit]}!");

                Console.WriteLine(period);
                period += ".";
            }

        }//END MAIN
    }
}
