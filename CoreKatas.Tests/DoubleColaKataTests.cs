using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreKatas.Tests
{
    class DoubleColaKataTests
    {
        private static List<string> GetQueueNames()
        {
            return new List<string> { "Ben", "Keegan", "Rascal", "Lou", "Liam" };
        }

        [Test]
        public void TestWhoGetsColaOne()
        {
            Assert.AreEqual("Ben", DoubleColaKata.WhoIsNext(GetQueueNames(), 1));
        }

        [Test]
        public void TestWhoGetsColaFour()
        {
            Assert.AreEqual("Lou", DoubleColaKata.WhoIsNext(GetQueueNames(), 4));
        }

        [Test]
        public void TestWhoGetsColaTwelve()
        {
            Assert.AreEqual("Lou", DoubleColaKata.WhoIsNext(GetQueueNames(), 12));
        }

        [Test]
        public void TestWhoGetsColaFiftyTwo()
        {
            Assert.AreEqual("Rascal", DoubleColaKata.WhoIsNext(GetQueueNames(), 52));
        }

        [Test]
        public void TestWhoGetsColaThousand()
        {
            Assert.AreEqual("Rascal", DoubleColaKata.WhoIsNext(GetQueueNames(), 1802));
        }

        [Test]
        public void TestWhoGetsColaLong()
        {
            Assert.AreEqual("Keegan", DoubleColaKata.WhoIsNext(GetQueueNames(), 7230702951));
        }
    }
}
