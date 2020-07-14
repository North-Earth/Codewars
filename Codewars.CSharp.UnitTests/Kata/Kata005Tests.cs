using Codewars.CSharp.Kata;
using NUnit.Framework;

namespace Codewars.CSharp.UnitTests.Kata
{
    [TestFixture]
    public class Kata005Tests
    {
        [Test]
        public void SampleTests()
        {
            Assert.AreEqual(true, Kata005.IsPangram("The quick brown fox jumps over the lazy dog."));
        }
    }
}
