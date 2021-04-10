using System;
using System.Collections.Generic;
using System.Linq;

namespace Codewars.CSharp.Kata
{
    /// <summary>
    /// A Narcissistic Number is a positive number which is the sum of its own digits, 
    /// each raised to the power of the number of digits in a given base. 
    /// In this Kata, we will restrict ourselves to decimal (base 10).
    /// 
    /// For example, take 153 (3 digits), which is narcisstic: 1^3 + 5^3 + 3^3 = 1 + 125 + 27 = 153 
    /// and 1652 (4 digits), which isn't: 1^4 + 6^4 + 5^4 + 2^4 = 1 + 1296 + 625 + 16 = 1938
    /// 
    /// The Challenge: Your code must return true or false depending upon whether 
    /// the given number is a Narcissistic number in base 10.
    /// 
    /// Error checking for text strings or other invalid inputs is not required, 
    /// only valid positive non-zero integers will be passed into the function.
    /// </summary>
    public class Kata008
    {
        /// <summary>
        /// My version.
        /// </summary>
        public static bool Narcissistic(int value)
        {
            var numbers = value
                .ToString()
                .ToArray();

            return numbers
                .Select(n => Math.Pow(char.GetNumericValue(n), numbers.Length))
                .Sum().Equals(value);
        }

        /// <summary>
        /// Best practice according to the community Codewars.
        /// </summary>
        public static bool NarcissisticBestPractice1(int value)
        {
            var str = value.ToString();
            return str.Sum(c => Math.Pow(Convert.ToInt16(c.ToString()), str.Length)) == value;
        }

        /// <summary>
        /// Best practice according to the community Codewars.
        /// </summary>
        public static bool NarcissisticBestPractice2(int value)
        {
            var lstInt = value.ToString().Select(x => int.Parse(x.ToString())).ToList();
            double resultTemp = 0;

            lstInt.ForEach(x =>
            {
                resultTemp += Math.Pow(x, lstInt.Count);
            });

            return resultTemp == value;
        }


        /// <summary>
        /// Best practice according to the community Codewars.
        /// </summary>
        public static bool NarcissisticBestPractice3(int value)
        {
            string digits = value.ToString();
            double sumOfPoweredDigits = 0;

            foreach (char digit in digits)
            {
                sumOfPoweredDigits += Math.Pow(Char.GetNumericValue(digit), digits.Length);
            }

            return (int)sumOfPoweredDigits == Int32.Parse(digits);
        }

        private static readonly HashSet<int> nNums = new HashSet<int>
        {
            0, 1, 2, 3, 4, 5, 6, 7, 8, 9,
            153, 370, 371, 407,
            1634, 8208, 9474,
            54748, 92727, 93084,
            548834,
            1741725, 4210818, 9800817, 9926315,
            24678050, 24678051, 88593477,
            146511208, 472335975, 534494836, 912985153,
        };

        /// <summary>
        /// Best practice according to the community Codewars.
        /// </summary>
        public static bool NarcissisticBestPractice4(int value) =>
          nNums.Contains(value);
    }
}
