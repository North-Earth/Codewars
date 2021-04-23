using System;
using System.Linq;

namespace Codewars.CSharp.Kata
{
    /*
     * A pangram is a sentence that contains every single letter of the alphabet at least once.
     * For example, the sentence "The quick brown fox jumps over the lazy dog" is a pangram, because
     * it uses the letters A-Z at least once (case is irrelevant).
     *
     * Given a string, detect whether or not it is a pangram. Return True if it is, False if not.
     * Ignore numbers and punctuation.
     */
    public static class Kata005
    {
        /// <summary>
        /// My version.
        /// </summary>
        public static bool IsPangram(string str)
        {
            var letters = Enumerable.Range('a', 26)
                .Select(lts => (char)lts)
                .ToList();

            return letters.All(str.ToLower().Contains);
        }

        #region Best practice according to the community Codewars.

        public static bool IsPangramBestPractice(string str)
        {
            return str.Where(ch => Char.IsLetter(ch)).Select(ch => Char.ToLower(ch)).Distinct().Count() == 26;
        }

        #endregion
    }
}
