using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreKatas.Tests
{
    [TestFixture]
    internal class CalculatorKataTests
    {
        [TestCase(21, "10.5 + 10.5")]
        [TestCase(6, "10 - 4")]
        [TestCase(100, "10 * 10")]
        [TestCase(5, "50 / 10")]
        public void TestCalculator(int expected, string value)
        {
            Assert.AreEqual(expected, CalculatorKata.Calculate(value));
        }
    }
}
