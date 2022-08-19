using CoreKatas;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace CoreKatas.Tests
{
    [TestFixture]
    internal class GreetingKataTests
    {
        [TestCase("Bob", "Hello, Bob.")]
        [TestCase("", "Hello, my friend.")]
        [TestCase("BOB", "HELLO BOB!")]
        public void TestGreet(string value, string expected)
        {
            Assert.AreEqual(expected, GreetingKata.Greet(value));
        }

        [Test]
        public void TestGreetWithTwoNames()
        {
            string[] names = new string[] { "Bob", "David" };
            Assert.AreEqual("Hello, Bob and David.", GreetingKata.Greet(names));
        }

        [Test]
        public void TestGreetWithMultipleNames()
        {
            string[] names = new string[] { "Bob", "David", "Terrance" };
            Assert.AreEqual("Hello, Bob, David and Terrance.", GreetingKata.Greet(names));
        }

        [Test]
        public void TestGreetWithMultipleNamesAndUppercase()
        {
            string[] names = new string[] { "Bob", "DAVID", "Terrance", "TYLER", "LIAM", "Steve" };
            Assert.AreEqual("Hello, Bob, Terrance and Steve. AND HELLO DAVID, TYLER AND LIAM!", GreetingKata.Greet(names));
        }

        [Test]
        public void TestGreetWithMultipleNamesAndUppercaseAndCommas()
        {
            string[] names = new string[] { "Bob", "DAVID", "Terrance, Kyle", "TYLER", "LIAM", "Steve" };
            Assert.AreEqual("Hello, Bob, Terrance, Kyle and Steve. AND HELLO DAVID, TYLER AND LIAM!", GreetingKata.Greet(names));
        }

        [Test]
        public void TestGreetWithMultipleNamesAndUppercaseAndEscapedCommas()
        {
            string[] names = new string[] { "Bob", "\"David, Liam\"" };
            Assert.AreEqual("Hello, Bob and David, Liam.", GreetingKata.Greet(names));
        }

        [Test]
        public void TestIsStringAllUppercase()
        {
            Assert.AreEqual(false, GreetingKata.IsUpperCase("test"));
            Assert.AreEqual(true, GreetingKata.IsUpperCase("TEST"));
        }

        [Test]
        public void TestUpperCaseSeperator()
        {
            var stringList = new List<string>
            {
                "lower case",
                "UPPERCASE",
                "Mixed Case"
            };

            var upperCaseStrings = GreetingKata.SeperateUpperCaseText(ref stringList);
            Assert.AreEqual(1, upperCaseStrings.Count);
            Assert.AreEqual(2, stringList.Count);
        }

        [Test]
        public void TestSplitAtCommas()
        {
            var stringList = new List<string>
            {
                "Test",
                "Test,Test",
                "Test"
            };

            stringList = GreetingKata.SplitAtCommas(stringList);
            Assert.AreEqual(4, stringList.Count);
        }
    }
}