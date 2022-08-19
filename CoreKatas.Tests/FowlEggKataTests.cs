using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreKatas.Tests
{
    [TestFixture]
    internal class FowlEggKataTests
    {
        [Test]
        public void TestGooseLayEgg()
        {
            var goose = new Goose();
            Assert.IsNotNull(goose.Lay());
        }

        [Test]
        public void TestGooseEggHatch()
        {
            var goose = new Goose();
            var gooseEgg = goose.Lay();
            Assert.IsInstanceOf<Goose>(gooseEgg.Hatch());
        }

        [Test]
        public void TestGooseEggHatchTwice()
        {
            var goose = new Goose();
            var gooseEgg = goose.Lay();
            gooseEgg.Hatch();
            Assert.IsNull(gooseEgg.Hatch());
        }

        [Test]
        public void TestChickenLayEgg()
        {
            var chicken = new Chicken();
            Assert.IsNotNull(chicken.Lay());
        }

        [Test]
        public void TestChickenEggHatch()
        {
            var chicken = new Chicken();
            var chickenEgg = chicken.Lay();
            Assert.IsInstanceOf<Chicken>(chickenEgg.Hatch());
        }

        [Test]
        public void TestChickenEggHatchTwice()
        {
            var chicken = new Chicken();
            var chickenEgg = chicken.Lay();
            chickenEgg.Hatch();
            Assert.IsNull(chickenEgg.Hatch());
        }
    }
}
