using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreKatas.Tests
{
    [TestFixture]
    internal class FirstNonRepeatingCharTests
    {
        [TestCase("a", "a")]
        [TestCase("t", "stress")]
        [TestCase("e", "moonmen")]
        public void FirstNonRepeatingLetterTests(string expected, string value)
        {
            Assert.AreEqual(expected, FirstNonRepeatingChar.FirstNonRepeatingLetter(value));
        }

        [Test]
        public void CountLettersTest()
        {
            Assert.AreEqual(2, FirstNonRepeatingChar.CountLetters("test", 't'));
        }
    }
}
