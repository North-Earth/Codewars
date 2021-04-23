using Codewars.CSharp.Kata;
using NUnit.Framework;

namespace Codewars.CSharp.UnitTests.Kata
{
    [TestFixture]
    public class Kata001Tests
    {
        [Test]
        public static void Test1()
        {
            Assert.AreEqual("emocleW", Kata001.SpinWords("Welcome"));
        }

        [Test]
        public static void Test2()
        {
            Assert.AreEqual("Hey wollef sroirraw", Kata001.SpinWords("Hey fellow warriors"));
        }

        [Test]
        public static void Test3()
        {
            Assert.AreEqual("This is a test", Kata001.SpinWords("This is a test"));
        }

        [Test]
        public static void Test4()
        {
            Assert.AreEqual("This is rehtona test", Kata001.SpinWords("This is another test"));
        }

        [Test]
        public static void Test5()
        {
            Assert.AreEqual("You are tsomla to the last test", Kata001.SpinWords("You are almost to the last test"));
        }

        [Test]
        public static void Test6()
        {
            Assert.AreEqual("Just gniddik ereht is llits one more", Kata001.SpinWords("Just kidding there is still one more"));
        }
    }
}
