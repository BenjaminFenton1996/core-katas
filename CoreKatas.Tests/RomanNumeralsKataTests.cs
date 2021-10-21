using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreKatas.Tests
{
    class RomanNumeralsKataTests
    {
        [Test]
        public void TestOneToRomanNumerals()
        {
            Assert.AreEqual("I", RomanNumeralsKata.IntegerToRomanNumerals(1));
        }

        [Test]
        public void TestFiveToRomanNumerals()
        {
            Assert.AreEqual("V", RomanNumeralsKata.IntegerToRomanNumerals(5));
        }

        [Test]
        public void TestTenToRomanNumerals()
        {
            Assert.AreEqual("X", RomanNumeralsKata.IntegerToRomanNumerals(10));
        }

        [Test]
        public void TestEighteenToRomanNumeral()
        {
            Assert.AreEqual("XVIII", RomanNumeralsKata.IntegerToRomanNumerals(18));
        }

        [Test]
        public void TestFourtyFourToRomanNumeral()
        {
            Assert.AreEqual("XLIV", RomanNumeralsKata.IntegerToRomanNumerals(44));
        }

        [Test]
        public void TestSeventySevenToRomanNumeral()
        {
            Assert.AreEqual("LXXVII", RomanNumeralsKata.IntegerToRomanNumerals(77));
        }

        [Test]
        public void TestHundredEightyEightToRomanNumeral()
        {
            Assert.AreEqual("CLXXXVIII", RomanNumeralsKata.IntegerToRomanNumerals(188));
        }

        [Test]
        public void TestFiveHundredFourtyNineToRomanNumeral()
        {
            Assert.AreEqual("DXLIX", RomanNumeralsKata.IntegerToRomanNumerals(549));
        }

        [Test]
        public void TestThreeThousandFourHundredNinetyTwoToRomanNumeral()
        {
            Assert.AreEqual("MMMCDXCII", RomanNumeralsKata.IntegerToRomanNumerals(3492));
        }
    }
}
