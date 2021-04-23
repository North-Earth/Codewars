using System.Linq;

namespace Codewars.CSharp.Kata
{
    /*
     * Write an algorithm that takes an array and moves all of the zeros to the end,
     * preserving the order of the other elements.
     */
    public class Kata004
    {
        /// <summary>
        /// My version.
        /// </summary>
        public static int[] MoveZeroes(int[] arr)
        {
            var collectionZeros = arr.Where(x => x == 0);
            var result = arr.Where(a => a != 0).ToList();

            result.AddRange(collectionZeros);

            return result.ToArray();
        }

        #region Best practice according to the community Codewars.

        public static int[] MoveZeroesBestPractice(int[] arr)
        {
            return arr.OrderBy(x => x == 0).ToArray();
        }

        #endregion
    }
}
