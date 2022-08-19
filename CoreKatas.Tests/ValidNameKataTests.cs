using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreKatas.Tests
{
    [TestFixture]
    internal class ValidNameKataTests
    {
        //Names must have a length of 4 or more
        //Names must start with a letter
        //Names must consist of only letters, numbers and optionally one underscore
        //Names must not end with an underscore
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
