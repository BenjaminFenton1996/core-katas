using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreKatas.Tests
{
    [TestFixture]
    internal class ArrayDifferenceKataTests
    {
        [Test]
        public void TestDifferencePerformant()
        {
            Assert.AreEqual(new int[] { 2 }, ArrayDifferenceKata.ArrayDiffPerformant(new int[] { 1, 2 }, new int[] { 1 }));
            Assert.AreEqual(new int[] { 2, 2 }, ArrayDifferenceKata.ArrayDiffPerformant(new int[] { 1, 2, 2 }, new int[] { 1 }));
            Assert.AreEqual(new int[] { 1 }, ArrayDifferenceKata.ArrayDiffPerformant(new int[] { 1, 2, 2 }, new int[] { 2 }));
            Assert.AreEqual(new int[] { 1, 2, 2 }, ArrayDifferenceKata.ArrayDiffPerformant(new int[] { 1, 2, 2 }, new int[] { }));
            Assert.AreEqual(new int[] { }, ArrayDifferenceKata.ArrayDiffPerformant(new int[] { }, new int[] { 1, 2 }));
            Assert.AreEqual(new int[] { 3 }, ArrayDifferenceKata.ArrayDiffPerformant(new int[] { 1, 2, 3 }, new int[] { 1, 2 }));
        }

        [Test]
        public void TestDifferenceClean()
        {
            Assert.AreEqual(new int[] { 2 }, ArrayDifferenceKata.ArrayDiffClean(new int[] { 1, 2 }, new int[] { 1 }));
            Assert.AreEqual(new int[] { 2, 2 }, ArrayDifferenceKata.ArrayDiffClean(new int[] { 1, 2, 2 }, new int[] { 1 }));
            Assert.AreEqual(new int[] { 1 }, ArrayDifferenceKata.ArrayDiffClean(new int[] { 1, 2, 2 }, new int[] { 2 }));
            Assert.AreEqual(new int[] { 1, 2, 2 }, ArrayDifferenceKata.ArrayDiffClean(new int[] { 1, 2, 2 }, new int[] { }));
            Assert.AreEqual(new int[] { }, ArrayDifferenceKata.ArrayDiffClean(new int[] { }, new int[] { 1, 2 }));
            Assert.AreEqual(new int[] { 3 }, ArrayDifferenceKata.ArrayDiffClean(new int[] { 1, 2, 3 }, new int[] { 1, 2 }));
        }
    }
}
