using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreKatas.Tests
{
    [TestFixture]
    internal class BouncingBallKataTests
    {
        [TestCase(3, 3.0, 0.66, 1.5)]
        [TestCase(15, 30.0, 0.66, 1.5)]
        public void TestBouncingBall(int expected, double height, double bounce, double windowHeight)
        {
            Assert.AreEqual(expected, BouncingBallKata.BouncingBall(height, bounce, windowHeight));
        }
    }
}
