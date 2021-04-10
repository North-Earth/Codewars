using System.Collections.Generic;
using Codewars.CSharp.Kata;
using NUnit.Framework;

namespace Codewars.CSharp.UnitTests.Kata
{
    [TestFixture]
    public class Kata008Tests
    {
        private static IEnumerable<TestCaseData> testCases
        {
            get
            {
                yield return new TestCaseData(1)
                                .Returns(true)
                                .SetDescription("1 is narcissitic");
                yield return new TestCaseData(371)
                                .Returns(true)
                                .SetDescription("371 is narcissitic");
                yield return new TestCaseData(370)
                                .Returns(true)
                                .SetDescription("370 is narcissitic");
                yield return new TestCaseData(153)
                                .Returns(true)
                                .SetDescription("153 is narcissitic");
                yield return new TestCaseData(1634)
                                .Returns(true)
                                .SetDescription("1634 is narcissitic");
                yield return new TestCaseData(154)
                                .Returns(false)
                                .SetDescription("154 is not narcissitic");
                yield return new TestCaseData(378)
                                .Returns(false)
                                .SetDescription("378 is not narcissitic");
                yield return new TestCaseData(999)
                                .Returns(false)
                                .SetDescription("999 is not narcissitic");
            }
        }

        [Test, TestCaseSource("testCases")]
        public bool Test(int n) => Kata008.Narcissistic(n);
    }
}
