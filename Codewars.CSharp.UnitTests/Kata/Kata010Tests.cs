using Codewars.CSharp.Kata;
using NUnit.Framework;

namespace Codewars.CSharp.UnitTests.Kata
{
    [TestFixture]
    public class Kata010Tests
    {
        [Test, Description("Sample Tests")]
        public void Test()
        {
            Assert.AreEqual("128.114.17.104", Kata010.UInt32ToIP(2154959208));
            Assert.AreEqual("0.0.0.0", Kata010.UInt32ToIP(0));
            Assert.AreEqual("128.32.10.1", Kata010.UInt32ToIP(2149583361));
        }
    }
}
