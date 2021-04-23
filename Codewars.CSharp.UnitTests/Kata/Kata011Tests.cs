using Codewars.CSharp.Kata;
using NUnit.Framework;

namespace Codewars.CSharp.UnitTests.Kata
{
    [TestFixture]
    public class Kata011Tests
    {
        [Test]
        public void SampleTest1()
        {
            Assert.AreEqual(true, Kata011.ValidParentheses("()"));
        }

        [Test]
        public void SampleTest2()
        {
            Assert.AreEqual(false, Kata011.ValidParentheses(")(((("));
        }

        [Test]
        public void SampleTest3()
        {
            Assert.AreEqual(false, Kata011.ValidParentheses("((hi(hi) (hi(hi))("));
        }

        [Test]
        public void SampleTest4()
        {
            Assert.AreEqual(false, Kata011.ValidParentheses("hi(hi))("));
        }
    }
}
