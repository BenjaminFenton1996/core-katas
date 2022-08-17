using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreKatas.Tests
{
    [TestFixture]
    class RomanNumeralsKataTests
    {
        [TestCase(1, "I")]
        [TestCase(5, "V")]
        [TestCase(10, "X")]
        [TestCase(18, "XVIII")]
        [TestCase(44, "XLIV")]
        [TestCase(77, "LXXVII")]
        [TestCase(188, "CLXXXVIII")]
        [TestCase(3492, "MMMCDXCII")]
        public void TestRomanNumerals(int value, string expected)
        {
            Assert.AreEqual(expected, RomanNumeralsKata.IntegerToRomanNumerals(value));
        }
    }
}
