using CoreKatas.Medium_Kata;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreKatas.Tests
{
    [TestFixture]
    internal class WeightForWeightKataTests
    {
        [TestCase("2000 103 123 4444 99", "103 123 4444 99 2000")]
        [TestCase("11 11 2000 10003 22 123 1234000 44444444 9999", "2000 10003 1234000 44444444 9999 11 11 22 123")]
        public void TestWeightForWeight(string expected, string value)
        {
            Assert.AreEqual(expected, WeightForWeightKata.OrderWeight(value));
        }
    }
}
