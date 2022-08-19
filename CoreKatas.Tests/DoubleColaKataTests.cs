using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreKatas.Tests
{
    [TestFixture]
    internal class DoubleColaKataTests
    {
        private static string[] GetQueueNames()
        {
            return new string[] { "Ben", "Keegan", "Rascal", "Lou", "Liam" };
        }

        [TestCase("Ben", 1)]
        [TestCase("Lou", 4)]
        [TestCase("Lou", 12)]
        [TestCase("Rascal", 52)]
        [TestCase("Rascal", 1802)]
        [TestCase("Keegan", 7230702951)]
        public void TestWhoGetsCola(string expected, long value)
        {
            Assert.AreEqual(expected, DoubleColaKata.WhoIsNext(GetQueueNames(), value));
        }
    }
}
