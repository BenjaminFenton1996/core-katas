using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreKatas
{
    public static class ShoppingBasketKata
    {
        /// <summary>
        /// 5% off for two of the same item
        /// 10% off for three of the same item
        /// 20% off for four of the same item
        /// 20% off for four of the same item + 1% off for every item over four items
        /// </summary>
        /// <param name="items">Shopping basket items as a List of strings</param>
        /// <returns>The total price for the basket of items as a decimal</returns>
        public static decimal GetPrice(List<string> items)
        {
            decimal price = 0M;
            foreach (var item in items.Distinct())
            {
                int itemCount = items.Where(x => x == item).Count();
                if (itemCount == 2)
                {
                    price += (5 * itemCount) * 0.95M;
                }
                else if (itemCount == 3)
                {
                    price += (5 * itemCount) * 0.90M;
                }
                else if (itemCount >= 4)
                {
                    price += (5 * itemCount) * (0.80M - (0.01M * (itemCount - 4)));
                }
                else
                {
                    price += 5M * itemCount;
                }
            }
            return price;
        }
    }
}