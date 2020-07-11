using Codewars.CSharp.Kata;
using NUnit.Framework;

namespace Codewars.CSharp.UnitTests.Kata
{
    [TestFixture]
    public class Kata003Tests
    {
        [TestCase(0, 0)]
        [TestCase(3, 4)]
        [TestCase(8, 6)]
        [TestCase(23, 10)]
        [TestCase(78, 20)]

        public void Test(int expected, int number)
        {
            var actual = Kata003.Solution(number);
            Assert.AreEqual(expected, actual);
        }
    }
}
