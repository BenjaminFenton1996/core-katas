using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreKatas.Tests
{
    class ValidNameKataTests
    {
        //Names must have a length of 4 or more
        //Names must start with a letter
        //Names must consist of only letters, numbers and optionally one underscore
        //Names must not end with an underscore

        [Test]
        public void TestNameLength()
        {
            Assert.IsTrue(ValidNameKata.IsNameValid("Steve"));
            Assert.IsFalse(ValidNameKata.IsNameValid("Bob"));
        }

        [Test]
        public void TestNameHasValidUnderscores()
        {
            Assert.IsTrue(ValidNameKata.IsNameValid("Steve_Guy"));
            Assert.IsFalse(ValidNameKata.IsNameValid("Steve__Guy"));
            Assert.IsFalse(ValidNameKata.IsNameValid("SteveGuy_"));
        }

        [Test]
        public void TestNameHasValidCharacters()
        {
            Assert.IsTrue(ValidNameKata.IsNameValid("Steve_Guy"));
            Assert.IsTrue(ValidNameKata.IsNameValid("Steve_Guy1"));
            Assert.IsFalse(ValidNameKata.IsNameValid("Steve-Guy"));
        }

        [Test]
        public void TestNameStartsWithLetter()
        {
            Assert.IsTrue(ValidNameKata.IsNameValid("Steve_Guy"));
            Assert.IsFalse(ValidNameKata.IsNameValid("1Steve_Guy"));
            Assert.IsFalse(ValidNameKata.IsNameValid("_Steve_Guy"));
        }
    }
}
