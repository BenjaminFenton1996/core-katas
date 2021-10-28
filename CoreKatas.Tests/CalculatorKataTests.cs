using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreKatas.Tests
{
    public class CalculatorKataTests
    {
        [Test]
        public void TestSimpleAddition()
        {
            Assert.AreEqual(21, CalculatorKata.Calculate("10.5 + 10.5"));
        }

        [Test]
        public void TestSimpleSubtraction()
        {
            Assert.AreEqual(6, CalculatorKata.Calculate("10 - 4"));
        }

        [Test]
        public void TestSimpleMultiplication()
        {
            Assert.AreEqual(100, CalculatorKata.Calculate("10 * 10"));
        }

        [Test]
        public void TestSimpleDivision()
        {
            Assert.AreEqual(5, CalculatorKata.Calculate("50 / 10"));
        }
    }
}
