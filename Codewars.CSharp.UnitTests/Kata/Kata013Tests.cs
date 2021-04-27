using Codewars.CSharp.Kata;
using NUnit.Framework;

namespace Codewars.CSharp.UnitTests.Kata
{
    [TestFixture]
    public class Kata013Tests
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual("120", Kata013.Factorial(5));
            Assert.AreEqual("1", Kata013.Factorial(1));
            Assert.AreEqual("362880", Kata013.Factorial(9));
            Assert.AreEqual("1307674368000", Kata013.Factorial(15));
            Assert.AreEqual("15511210043330985984000000", Kata013.Factorial(25));
        }
    }
}
