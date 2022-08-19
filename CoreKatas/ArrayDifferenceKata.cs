using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreKatas
{
    public static class ArrayDifferenceKata
    {
        public static int[] ArrayDiffPerformant(int[] a, int[] b)
        {
            var processedList = new List<int>();
            for (int i = 0; i < a.Length; i++)
            {
                bool doesExist = false;
                for (int x = 0; x < b.Length; x++)
                {
                    if (a[i] == b[x])
                    {
                        doesExist = true;
                        break;
                    }
                }

                if (!doesExist)
                    processedList.Add(a[i]);
            }

            var processedArray = new int[processedList.Count];
            for (int i = 0; i < processedList.Count; i++)
                processedArray[i] = processedList[i];

            return processedArray;
        }

        public static int[] ArrayDiffClean(int[] a, int[] b)
        {
            return a.Where(x => !b.Contains(x)).ToArray();
        }
    }
}
