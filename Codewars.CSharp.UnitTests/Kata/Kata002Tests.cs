using Codewars.CSharp.Kata;
using NUnit.Framework;

namespace Codewars.CSharp.UnitTests.Kata
{
    [TestFixture]
    public class Kata002Tests
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual(new int[] { 3, 5 }, Kata002.Divisors(15));
            Assert.AreEqual(new int[] { 2, 4, 8 }, Kata002.Divisors(16));
            Assert.AreEqual(new int[] { 11, 23 }, Kata002.Divisors(253));
            Assert.AreEqual(new int[] { 2, 3, 4, 6, 8, 12 }, Kata002.Divisors(24));
            Assert.AreEqual(new int[] { 2, 4, 349, 698, 1396, 1538281, 3076562, 6153124, 536860069, 1073720138 }, Kata002.Divisors(2147440276));
            Assert.AreEqual(null, Kata002.Divisors(13));
        }
    }
}
