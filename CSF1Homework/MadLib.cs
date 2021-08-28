using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class MadLib
    {
        static void Main(string[] args)
        {

            /*
             * Create a "mad lib" that asks the user for various pieces of information. Store the information as
             * strings. Once the information has been collected, output a story using the stored information.
             */

            Console.WriteLine("Let's do a MadLib!! Here's how you play. I'll ask for a type of word and you choose anything you want! Then I'll print a silly story for you using your words.\n\nQuick Tips:\nA noun is a person, place, or thing.\nEx: teacher, palace, bag\n\nA verb is an action.\nEx: run, jump, swim\n\nAn adverb usually ends in \"ly\" and describes an action.\nEx: quickly, busily, slowly\n\nAn adjective describes a person, place, or thing.\nEx: fuzzy, silly, cold\n\nThe Blob\n\n");

            Console.Write("Enter an adjective: ");
            string input1 = Console.ReadLine();

            Console.Write("Enter a noun (place): ");
            string input2 = Console.ReadLine();

            Console.Write("Enter a plural noun: ");
            string input3 = Console.ReadLine();

            Console.Write("Enter a color: ");
            string input4 = Console.ReadLine();

            Console.Write("Enter a plural noun: ");
            string input5 = Console.ReadLine();

            Console.Write("Enter a verb-ing: ");
            string input6 = Console.ReadLine();

            Console.Write("Enter a verb: ");
            string input7 = Console.ReadLine();

            Console.Write("Enter a verb-ed: ");
            string input8 = Console.ReadLine();

            Console.Write("Enter an adjective: ");
            string input9 = Console.ReadLine();

            Console.Write("Enter a color: ");
            string input10 = Console.ReadLine();

            Console.Write("Enter an adverb: ");
            string input11 = Console.ReadLine();

            Console.Write("Enter a noun: ");
            string input12 = Console.ReadLine();

            Console.Write("Enter a verb: ");
            string input13 = Console.ReadLine();

            Console.Write("Enter a verb-ing: ");
            string input14 = Console.ReadLine();

            Console.Write("Enter a verb-ing: ");
            string input15 = Console.ReadLine();

            Console.Write("Enter a plural noun: ");
            string input16 = Console.ReadLine();

            Console.Write("Enter a plural noun: ");
            string input17 = Console.ReadLine();

            Console.Write("Enter a verb: ");
            string input18 = Console.ReadLine();

            Console.Write("Enter a verb-ed: ");
            string input19 = Console.ReadLine();

            Console.Write("Enter a verb: ");
            string input20 = Console.ReadLine();

            Console.Write("\n\nOK!! Here comes your story!\n\n");

            Console.WriteLine($"It all started with a {input1} explosion at the {input2}, with {input3} and {input4} {input5} {input6} everywhere. The scientists did their best to {input7} the lab but they must have {input8} something wrong. Soon after, a {input9} {input10} blob was seen very {input11} moving down {input12} Street. The police did not know what to {input13} about it, so they let The Blob keep {input14}. But The Blob kep {input15} everything in it's path, including {input16} and {input17}. Nobody could {input18} The Blob, so the townspeople {input19} for it to {input20} somewhere else.");
        }
    }
}
