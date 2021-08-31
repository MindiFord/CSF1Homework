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

            //HOOOOWWWWWW do I capture the different variables??

            int score = 0;

            do
            {

                Console.Write("Enter a score: ");
                score = Convert.ToInt32(Console.ReadLine());

            } while (score >= 0);

            Console.WriteLine(score);

        }
    }
}
