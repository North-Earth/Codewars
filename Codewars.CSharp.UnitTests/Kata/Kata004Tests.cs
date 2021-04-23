using Codewars.CSharp.Kata;
using NUnit.Framework;
namespace Codewars.CSharp.UnitTests.Kata
{
    [TestFixture]
    public class Kata004Tests
    {
        [Test]
        public void Test()
        {
            Assert.AreEqual(new int[] { 1, 2, 1, 1, 3, 1, 0, 0, 0, 0 }, Kata004.MoveZeroes(new int[] { 1, 2, 0, 1, 0, 1, 0, 3, 0, 1 }));
        }
    }
}
