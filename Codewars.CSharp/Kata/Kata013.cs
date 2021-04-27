using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Codewars.CSharp.Kata
{
    /// <summary>
    /// In mathematics, the factorial of integer n is written as n!. It is equal to the product of n and every integer preceding it. 
    /// For example: 5! = 1 x 2 x 3 x 4 x 5 = 120
    /// Your mission is simple: write a function that takes an integer n and returns the value of n!.
    /// You are guaranteed an integer argument.For any values outside the non-negative range, return null, nil or None (return an empty string "" in C and C++). 
    /// For non-negative numbers a full length number is expected for example, return 25! = "15511210043330985984000000" as a string.
    /// NOTES:
    /// The use of BigInteger or BigNumber functions has been disabled, this requires a complex solution
    /// I have removed the use of require in the javascript language.
    /// </summary>
    public class Kata013
    {
        /// <summary>
        /// My version.
        /// </summary>
        public static string Factorial(int n)
        {
            if (n < 0) { return string.Empty; }

            var resultString = "1";

            foreach (var factor in Enumerable.Range(1, n).ToList())
            {
                var multiplicationResult = "";
                var over = 0;

                foreach (var number in resultString.Reverse())
                {
                    over = Math.DivRem(int.Parse(number.ToString()) * factor + over, 10, out int result);
                    multiplicationResult = $"{result}{multiplicationResult}";
                }

                resultString = over == 0 ? multiplicationResult : $"{over}{multiplicationResult}";
            }

            return resultString;
        }

        #region Best practice according to the community Codewars.

        public static string FactorialBestPractice1(int n)
        {
            if (n < 0) return string.Empty;
            var result = "1";
            for (int i = 2; i <= n; i++)
            {
                result = Multiply(result, i);
            }
            return result;
        }

        private static string Add(string a, string b)
        {
            if (a.Length > b.Length) b = b.PadLeft(a.Length, '0');
            else if (a.Length < b.Length) a = a.PadLeft(b.Length, '0');

            var digits = new char[a.Length + 1];
            var carry = 0;
            for (int i = a.Length - 1; i >= 0; i--)
            {
                var result = a[i] + b[i] + carry - 0x60;
                carry = result / 10;
                result = result % 10;
                digits[i + 1] = (char)('0' + result);
            }
            digits[0] = (char)('0' + carry);
            return new string(digits).TrimStart('0');
        }

        private static string Multiply(string a, int x)
        {
            var result = "0";
            for (int i = 0; i < x; i++)
            {
                result = Add(result, a);
            }
            return result;
        }

        public static string FactorialBestPractice2(int n)
        {
            if (n < 2) return "1";

            List<int> list = new List<int>() { 0, n };

            for (int i = 1; i < n; i++)
                //Convert the 10^1 base system to 10^6 base system
                for (int j = 0; j < list.Count; j++)
                {
                    //Make multiply for all digits of number in 10^6 base system
                    list[j] *= i;
                    if (list[j] / 1000000 >= 1)
                    {


                        //that was where to add 1st number from list
                        if (j == 0)
                        {
                            list.Insert(0, list[j] / 1000000);
                            list[++j] %= 1000000;
                        }
                        //sum 1st digit from list[j] and previus list-number 
                        else
                        {
                            list[j - 1] += list[j] / 1000000;
                            list[j] %= 1000000;
                        }
                    }
                }

            //Make output
            string str = "";
            for (int t = 0; t < list.Count; t++)
                str += list[t].ToString().PadLeft(6, '0');
            return str.TrimStart('0');
        }

        public static string FactorialBestPractice3(int n)
        {
            if (n % 1 != 0 || n < 0)
            {
                return null;
            }
            else if (n == 0 || n == 1)
            {
                return "1";
            }
            else
            {
                char[] prevAns = Factorial(n - 1).ToCharArray();
                IEnumerable<int> digitsMultiplied = prevAns.Select(x => (n * (x - '0')));
                List<int> digits = new List<int>();

                foreach (int element in digitsMultiplied)
                {
                    digits.Add(element);
                }

                for (int index = digits.Count() - 1; index > 0; index--)
                {
                    digits[index - 1] += (digits[index] / 10);
                    digits[index] %= 10;
                }
                StringBuilder answer = new StringBuilder();
                for (int index = 0; index < digits.Count(); index++)
                {
                    answer.Append(digits[index].ToString());
                }
                return answer.ToString();
            }
        }

        #endregion
    }
}
