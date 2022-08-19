using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreKatas.Tests
{
    [TestFixture]
    internal class StripCommentsKataTests
    {
        [Test]
        public void StripComments()
        {
            Assert.AreEqual(
                    "apples, pears\ngrapes\nbananas",
                    StripCommentsKata.StripComments("apples, pears # and bananas\ngrapes\nbananas !apples", new string[] { "#", "!" }));

            Assert.AreEqual("a\nc\nd", StripCommentsKata.StripComments("a #b\nc\nd $e f g", new string[] { "#", "$" }));

            Assert.AreEqual("E\n\nF\n\n", StripCommentsKata.StripComments("E\n\nF\n\n#", new string[] { "#", "$" }));
        }
    }
}
