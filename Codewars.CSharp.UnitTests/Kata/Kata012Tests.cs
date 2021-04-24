using System;
using System.Collections.Generic;
using System.Text;
using Codewars.CSharp.Kata;
using NUnit.Framework;

namespace Codewars.CSharp.UnitTests.Kata
{
    [TestFixture]
    public class Kata012Tests
    {
        [Test]
        public void HumanReadableTest()
        {
            Assert.AreEqual("00:00:00", Kata012.GetReadableTime(0));
            Assert.AreEqual("00:00:05", Kata012.GetReadableTime(5));
            Assert.AreEqual("00:01:00", Kata012.GetReadableTime(60));
            Assert.AreEqual("23:59:59", Kata012.GetReadableTime(86399));
            Assert.AreEqual("99:59:59", Kata012.GetReadableTime(359999));
        }
    }
}
