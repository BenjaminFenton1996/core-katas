using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreKatas.Tests
{
    class ShoppingBasketKataTests
    {
        [Test]
        public void BuyingOneItemTest()
        {
            var items = new List<string>
            {
                "Bread"
            };
            Assert.AreEqual(5M, ShoppingBasketKata.GetPrice(items));
        }

        [Test]
        public void BuyingTwoItemsTest()
        {
            var items = new List<string>
            {
                "Bread",
                "Milk"
            };
            Assert.AreEqual(10M, ShoppingBasketKata.GetPrice(items));
        }

        [Test]
        public void BuyingTwoOfSameItemTest()
        {
            var items = new List<string>
            {
                "Bread",
                "Bread"
            };
            Assert.AreEqual(9.5M, ShoppingBasketKata.GetPrice(items));
        }

        [Test]
        public void BuyingThreeOfSameItemTest()
        {
            var items = new List<string>
            {
                "Bread",
                "Bread",
                "Bread"
            };
            Assert.AreEqual(13.5M, ShoppingBasketKata.GetPrice(items));
        }

        [Test]
        public void BuyingFourOfSameItemTest()
        {
            var items = new List<string>
            {
                "Bread",
                "Bread",
                "Bread",
                "Bread"
            };
            Assert.AreEqual(16M, ShoppingBasketKata.GetPrice(items));
        }

        [Test]
        public void BuyingFourOfSameItemAndAnotherItemTest()
        {
            var items = new List<string>
            {
                "Bread",
                "Bread",
                "Bread",
                "Bread",
                "Milk"
            };
            Assert.AreEqual(21M, ShoppingBasketKata.GetPrice(items));
        }

        [Test]
        public void BuyingTenOfSameItemTest()
        {
            var items = new List<string>
            {
                "Bread",
                "Bread",
                "Bread",
                "Bread",
                "Bread",
                "Bread",
                "Bread",
                "Bread",
                "Bread",
                "Bread"
            };
            Assert.AreEqual(37M, ShoppingBasketKata.GetPrice(items));
        }

        [Test]
        public void BuyingFiveSameFiveDifferentItemsTest()
        {
            var items = new List<string>
            {
                "Bread",
                "Bread",
                "Bread",
                "Bread",
                "Bread",
                "Milk",
                "Milk",
                "Milk",
                "Milk",
                "Milk"
            };
            Assert.AreEqual(39.5M, ShoppingBasketKata.GetPrice(items));
        }
    }
}
