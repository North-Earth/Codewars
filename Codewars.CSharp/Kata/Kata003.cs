using System;
using System.Collections.Generic;
using System.Linq;

namespace Codewars.CSharp.Kata
{
    /*
     * If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
     * Finish the solution so that it returns the sum of all the multiples of 3 or 5 below the number passed in.
     *
     * Note: If the number is a multiple of both 3 and 5, only count it once.
     */
    public static class Kata003
    {
        /*
         * Thoughts:
         * Very not optimal code :(
         */

        /// <summary>
        /// My version.
        /// </summary>
        public static int Solution(int value)
        {
            var result = new List<int>();

            for (var i = 1; i < Math.Ceiling(value / 3.0d); i++)
            {
                var numbers = new List<int> { (3 * i), (5 * i) };

                result.AddRange(numbers.Where(num => num < value && !result.Contains(num)));
            }

            return result.Sum();
        }

        #region Best practice according to the community Codewars.

        public static int SolutionBestPractice(int n)
        {
            return Enumerable.Range(0, n).Where(e => e % 3 == 0 || e % 5 == 0).Sum();
        }

        #endregion
    }
}
