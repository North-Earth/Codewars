using System.Diagnostics;
using Codewars.CSharp.Kata;
using NUnit.Framework;

namespace Codewars.CSharp.UnitTests.Kata
{
    [TestFixture]
    public class Kata002Tests
    {
        [TestCase(new int[] { 3, 5 }, 15)]
        [TestCase(new int[] { 2, 4, 8 }, 16)]
        [TestCase(new int[] { 11, 23 }, 253)]
        [TestCase(new int[] { 2, 3, 4, 6, 8, 12 }, 24)]
        [TestCase(new int[] { 2, 4, 349, 698, 1396, 1538281, 3076562, 6153124, 536860069, 1073720138 }, 2147440276)]
        [TestCase(null, 13 )]

        public void SampleTest(int[] expected, int number)
        {
            var actual = Kata002.Divisors(number);
            Assert.AreEqual(expected, actual);
        }
    }
}
