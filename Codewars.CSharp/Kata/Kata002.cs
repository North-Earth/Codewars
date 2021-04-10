using System;
using System.Collections.Generic;
using System.Linq;

namespace Codewars.CSharp.Kata
{
    /*
     * Create a function named divisors/Divisors that takes an integer n > 1 and returns an array with all of
     * the integer's divisors(except for 1 and the number itself), from smallest to largest.
     * If the number is prime return the string '(integer) is prime' (null in C#)
     * (use Either String a in Haskell and Result<Vec<u32>, String> in Rust).
     *
     * Example:
     * Kata.Divisors(12) => new int[] {2, 3, 4, 6};
     * Kata.Divisors(25) => new int[] {5};
     * Kata.Divisors(13) => null;
     */

    public static class Kata002
    {
        /*
         * Thoughts:
         * Optimization for large numbers has proven difficult.
         * I have to study math better.
         */

        /// <summary>
        /// My version.
        /// </summary>
        public static int[] Divisors(int n)
        {
            if (n <= 1) { return null; }

            var result = new List<int>(1600);

            for (var i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i != 0) { continue; }

                result.Add(i);

                var inv = n / i;
                if (!result.Contains(inv)) { result.Add(inv); }
            }

            if (!result.Any()) { return null; }

            result.Sort();

            return result.ToArray();
        }

        #region Best practice according to the community Codewars.

        public static int[] DivisorsBestPractice(int n)
        {
            List<int> l = new List<int>();
            for (int i = 2; i <= Math.Sqrt(n); i++) if (n % i == 0) l.Add(i);
            if (l.Count == 0) return null;
            List<int> k = new List<int>(Enumerable.Reverse(l.ToArray().Select(x => n / x).ToArray().Where(x => !l.Contains(x))));
            l.AddRange(k);
            return l.ToArray();
        }

        #endregion
    }
}
