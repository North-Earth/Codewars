using System;
using System.Linq;

namespace Codewars.CSharp.Kata
{
    /// <summary>
    /// ROT13 is a simple letter substitution cipher that replaces a letter with the letter 13 letters after it in the alphabet. 
    /// ROT13 is an example of the Caesar cipher.
    /// Create a function that takes a string and returns the string ciphered with Rot13.
    /// If there are numbers or special characters included in the string, they should be returned as they are. 
    /// Only letters from the latin/english alphabet should be shifted, like in the original Rot13 "implementation".
    /// </summary>
    public class Kata009
    {
        /// <summary>
        /// My version.
        /// </summary>
        public static string Rot13(string message)
        {
            return string.Join(string.Empty, message
                .Select(s => (s > 'Z' && s < 'a') || s > 'z' || s < 'A'
                        ? s : (s + 13) > 'z' ? (char)(s + 13 - 26) : (s >= 'a' || s + 13 <= 'Z')
                        ? (char)(s + 13) : (char)(s + 13 - 26)));
        }

        #region Best practice according to the community Codewars.

        public static string Rot13BestPractice1(string message)
        {
            string result = "";
            foreach (var s in message)
            {
                if ((s >= 'a' && s <= 'm') || (s >= 'A' && s <= 'M'))
                    result += Convert.ToChar((s + 13)).ToString();
                else if ((s >= 'n' && s <= 'z') || (s >= 'N' && s <= 'Z'))
                    result += Convert.ToChar((s - 13)).ToString();
                else result += s;
            }
            return result;
        }

        public static string Rot13BestPractice2(string message)
        {
            return String.Join("", message.Select(x => char.IsLetter(x) ? (x >= 65 && x <= 77) || (x >= 97 && x <= 109) ? (char)(x + 13) : (char)(x - 13) : x));
        }

        #endregion
    }
}
