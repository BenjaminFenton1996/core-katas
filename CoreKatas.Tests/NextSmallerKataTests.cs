using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreKatas.Tests
{
    [TestFixture]
    internal class NextSmallerKataTests
    {
        [TestCase(21, ExpectedResult = 12)]
        [TestCase(907, ExpectedResult = 790)]
        [TestCase(1900769, ExpectedResult = 1900697)]
        [TestCase(531, ExpectedResult = 513)]
        [TestCase(1027, ExpectedResult = -1)]
        [TestCase(441, ExpectedResult = 414)]
        [TestCase(123456798, ExpectedResult = 123456789)]
        [TestCase(1207, ExpectedResult = 1072)]
        [TestCase(100, ExpectedResult = -1)]
        [TestCase(59884848483559L, ExpectedResult = 59884848459853)]
        [TestCase(51226262651257L, ExpectedResult = 51226262627551)]
        public long FixedTests(long n)
        {
            return NextSmallerKata.NextSmaller(n);
        }
    }
}
