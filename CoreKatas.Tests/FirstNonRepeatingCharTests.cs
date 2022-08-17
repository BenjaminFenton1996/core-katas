using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreKatas.Tests
{
    class FirstNonRepeatingCharTests
    {
        [Test]
        public void FirstNonRepeatingLetterTests()
        {
            Assert.AreEqual("a", FirstNonRepeatingChar.FirstNonRepeatingLetter("a"));
            Assert.AreEqual("t", FirstNonRepeatingChar.FirstNonRepeatingLetter("stress"));
            Assert.AreEqual("e", FirstNonRepeatingChar.FirstNonRepeatingLetter("moonmen"));
        }

        [Test]
        public void CountLettersTest()
        {
            Assert.AreEqual(2, FirstNonRepeatingChar.CountLetters("test", 't'));
        }
    }
}
