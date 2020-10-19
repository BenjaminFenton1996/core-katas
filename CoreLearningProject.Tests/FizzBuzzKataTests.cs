using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreLearningProject.Tests
{
    class FizzBuzzKataTests
    {
        [Test]
        public void TestFizzBuzzWithFive()
        {
            Assert.AreEqual("12Fizz4Buzz", FizzBuzzKata.FizzBuzz(5));
        }

        [Test]
        public void TestFizzBuzzWithFifteen()
        {
            Assert.AreEqual("12Fizz4BuzzFizz78FizzBuzz11FizzFizz14FizzBuzz", FizzBuzzKata.FizzBuzz(15));
        }
    }
}