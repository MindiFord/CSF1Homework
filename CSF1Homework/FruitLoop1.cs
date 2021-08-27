using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class FruitLoop1
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Fruit Loop 1 Lab\n");

            string[] fruits = { "apple", "banana", "canteloupe", "dragonfruit", "elderberry", "fig" };

            for (int i = 0; i < fruits.Length; i++)
            {
                Console.WriteLine(fruits[i]);
            }

        }//END MAIN
    }
}
