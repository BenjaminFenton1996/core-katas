using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreKatas.Tests
{
    class ShoppingBasketKataTests
    {
        [Test]
        public void TestBuyingOneItem()
        {
            var items = new List<string>
            {
                "Bread"
            };
            Assert.AreEqual(5M, ShoppingBasketKata.GetPrice(items));
        }

        [Test]
        public void TestBuyingTwoItems()
        {
            var items = new List<string>
            {
                "Bread",
                "Milk"
            };
            Assert.AreEqual(10M, ShoppingBasketKata.GetPrice(items));
        }

        [Test]
        public void TestBuyingTwoOfSameItem()
        {
            var items = new List<string>
            {
                "Bread",
                "Bread"
            };
            Assert.AreEqual(9.5M, ShoppingBasketKata.GetPrice(items));
        }

        [Test]
        public void TestBuyingThreeOfSameItem()
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
        public void TestBuyingFourOfSameItem()
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
        public void TestBuyingFourOfSameItemAndAnotherItem()
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
        public void TestBuyingTenOfSameItem()
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
        public void TestBuyingFiveSameFiveDifferentItems()
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
