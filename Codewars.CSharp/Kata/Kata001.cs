using System;
using System.Linq;

namespace Codewars.CSharp.Kata
{
    /*
     * Write a function that takes in a string of one or more words, and returns the same string, but with all five or
     * more letter words reversed (Just like the name of this Kata). Strings passed in will consist of only letters and spaces.
     * Spaces will be included only when more than one word is present.
     *
     * Examples:
     * spinWords( "Hey fellow warriors" ) => returns "Hey wollef sroirraw"
     * spinWords( "This is a test") => returns "This is a test"
     * spinWords( "This is another test" )=> returns "This is rehtona test"
     */

    public class Kata001
    {
        /// <summary>
        /// My version.
        /// </summary>
        public static string SpinWords(string sentence)
        {
            return string.Join(" ",
                sentence.Split(' ').Select(x => x.Length >= 5
                    ? string.Join("", x.ToCharArray().Reverse())
                    : x));
        }

        #region Best practice according to the community Codewars.

        public static string SpinWordsBestPractice(string sentence)
        {
            return String.Join(" ", sentence.Split(' ').Select(str => str.Length >= 5 ? new string(str.Reverse().ToArray()) : str));
        }

        #endregion
    }
}
