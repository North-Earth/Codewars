using System.Linq;

namespace Codewars.CSharp.Kata
{
    /// <summary>
    /// Your goal in this kata is to implement a difference function, which subtracts one list from another and returns the result.
    /// It should remove all values from list a, which are present in list b.
    /// </summary>
    public static class Kata006
    {
        /// <summary>
        /// My version.
        /// </summary>
        public static int[] ArrayDiff(int[] a, int[] b) => a.Where(item => !b.Contains(item)).ToArray();

        /// <summary>
        /// Best practice according to the community Codewars.
        /// </summary>
        public static int[] ArrayDiffBestPractice(int[] a, int[] b)
        {
            return a.Where(n => !b.Contains(n)).ToArray();
        }
    }
}
