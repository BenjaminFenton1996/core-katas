using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreKatas
{
    public static class ArrayDifferenceKata
    {
        /// <summary>
        /// Takes two arrays (a and b) and removes all occurrences of values in b from a and returns the result
        /// This function is slightly faster but has many more lines
        /// </summary>
        /// <param name="a">Array to perform the difference operation on</param>
        /// <param name="b">All occurrences of values in this array will be removed from array a</param>
        /// <returns>Array a with all values that existed in b removed</returns>
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

        /// <summary>
        /// Takes two arrays (a and b) and removes all occurrences of values in b from a and returns the result
        /// This function accomplishes the task in few lines but is slightly slower
        /// </summary>
        /// <param name="a">Array to perform the difference operation on</param>
        /// <param name="b">All occurrences of values in this array will be removed from array a</param>
        /// <returns>Array a with all values that existed in b removed</returns>
        public static int[] ArrayDiffClean(int[] a, int[] b)
        {
            return a.Where(x => !b.Contains(x)).ToArray();
        }
    }
}
