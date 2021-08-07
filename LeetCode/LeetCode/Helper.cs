using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.LeetCode
{
    class Helper
    {
        /// <summary>
        /// Uses the console to read an integer. Can specify an optional lower and upper bound.
        /// </summary>
        /// <returns>a user specified integer</returns>
        public static int ReadInteger(int lower = int.MinValue, int upper = int.MaxValue)
        {
            int n;
            while (true) // limit input only to digits between 1 and 10000
            {
                Console.Write("Enter a number between 1 and 10,000: ");
                if (int.TryParse(Console.ReadLine(), out n) && (n >= lower && n <= upper))
                {
                    Console.Clear();
                    break;
                }
                else
                {
                    Console.Clear();
                }
            }
            return n;
        }
    }
}
