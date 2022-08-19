using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CoreKatas
{
    public static class NextSmallerKata
    {
        public static long NextSmaller(long n)
        {
            //Put the number into a List so that we can work with each digit individually
            var integerList = new List<long>();
            while (n != 0)
            {
                integerList.Insert(0, n % 10);
                n /= 10;
            }

            bool foundSmaller = false;
            for (int x = integerList.Count - 2; x >= 0; x--)
            {
                for (int y = integerList.Count - 1; y > x; y--)
                {
                    //Don't want a 0 at the beginning of the processed number
                    if (x == 0 && integerList[y] == 0)
                        continue;

                    //If a smaller number has been found to the right swap them
                    if (integerList[x] > integerList[y])
                    {
                        (integerList[x], integerList[y]) = (integerList[y], integerList[x]);

                        //Order the numbers proceeding the left digit
                        var orderedRemains = new List<long>();
                        for (int z = x + 1; z < integerList.Count; z++)
                        {
                            orderedRemains.Add(integerList[z]);
                        }
                        orderedRemains = orderedRemains.OrderBy(x => x).ToList();

                        //Use the ordered number List to sort the original list
                        for (int z = orderedRemains.Count; z > 0; z--)
                        {
                            integerList[integerList.Count - z] = orderedRemains[z - 1];
                        }

                        foundSmaller = true;
                        break;
                    }
                }

                if (foundSmaller)
                    break;
            }

            if (!foundSmaller)
                return -1;

            var builder = new StringBuilder();
            foreach (var integer in integerList)
                builder.Append(integer);

            return Convert.ToInt64(builder.ToString());
        }
    }
}
