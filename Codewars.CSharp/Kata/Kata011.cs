using System.Linq;

namespace Codewars.CSharp.Kata
{
    /// <summary>
    /// Write a function that takes a string of parentheses, and determines if the order of the parentheses is valid. 
    /// The function should return true if the string is valid, and false if it's invalid.
    /// </summary>
    public class Kata011
    {
        public static bool ValidParentheses(string input)
        {
            var chars = input
                .Where(c => c.Equals('(') || c.Equals(')'))
                .ToList();

            if (chars.Count % 2 != 0) { return false; }

            for (int i = 0; i < chars.Count / 2; i++)
            {
                if (chars.First() != '(' || chars.Last() != ')')
                {
                    return false;
                }

                chars.Remove(chars.First());
                chars.Remove(chars.Last());
            }

            return true;
        }

        #region Best practice according to the community Codewars.

        public static bool ValidParenthesesBestPractice1(string input)
        {
            int parentheses = 0;
            foreach (char t in input)
            {
                if (t == '(')
                {
                    parentheses++;
                }
                else if (t == ')')
                {
                    parentheses--;

                    if (parentheses < 0)
                    {
                        return false;
                    }
                }
            }

            return parentheses == 0;
        }

        public static bool ValidParenthesesBestPractice2(string input)
        {
            var count = 0;
            foreach (var c in input)
            {
                if (count == -1)
                    return false;
                if (c == '(')
                    count++;
                if (c == ')')
                    count--;
            }
            return count == 0;
        }

        public static bool ValidParenthesesBestPractice3(string input)
        {
            input = string.Concat(input.Where(x => "()".Contains(x)));
            while (input.Contains("()"))
            {
                input = input.Replace("()", "");
            }

            return !input.Any();
        }

        #endregion
    }
}
