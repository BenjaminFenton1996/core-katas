using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreKatas.Tests
{
    [TestFixture]
    class RomanNumeralsKataTests
    {
        [TestCase(1, ExpectedResult = "I")]
        [TestCase(5, ExpectedResult = "V")]
        [TestCase(10, ExpectedResult = "X")]
        [TestCase(18, ExpectedResult = "XVIII")]
        [TestCase(44, ExpectedResult = "XLIV")]
        [TestCase(77, ExpectedResult = "LXXVII")]
        [TestCase(188, ExpectedResult = "CLXXXVIII")]
        [TestCase(3492, ExpectedResult = "MMMCDXCII")]
        public string TestRomanNumerals(int value)
        {
            return RomanNumeralsKata.IntegerToRomanNumerals(value);
        }
    }
}
