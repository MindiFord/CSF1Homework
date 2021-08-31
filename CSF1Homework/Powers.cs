using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class Powers
    {
        static void Main(string[] args)
        {
            #region Instructions

            /*
             * Using a FOR loop, display the powers of 2 from 1 to 50. (2 to the 1st power through 2 to the 50th power).
             * Use a long variable to store your results.
             * Example: 2 to the 4th power is 2x2x2x2.
             */

            long power = 1;

            for (int i = 1; i < 51; i++)
            {
                Console.WriteLine(Math.Pow(2, power));
                power++;
            }

            #endregion
        }
    }
}
