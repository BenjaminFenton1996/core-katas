using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreKatas.Tests
{
    [TestFixture]
    internal class ValidNameKataTests
    {      
        [TestCase(true, "Steve_Guy")]
        [TestCase(true, "Steve_Guy1")]
        [TestCase(false, "Bob")]
        [TestCase(false, "Steve__Guy")]
        [TestCase(false, "SteveGuy_")]
        [TestCase(false, "1Steve_Guy")]
        [TestCase(false, "_Steve_Guy")]
        public void TestNameValid(bool expected, string value)
        {
            Assert.AreEqual(expected, ValidNameKata.IsNameValid(value));
        }
    }
}
