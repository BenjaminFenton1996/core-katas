using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreKatas
{
    public static class DoubleColaKata
    {
        /// <summary>
        /// Everyone is queueing for a Double Cola, 
        /// when they drink it they double and both the original and clone go to the back of the queue.
        /// This method figures out which person would get the n-th cola
        /// </summary>
        /// <param name="names">The names of the people in the queue</param>
        /// <param name="colaNumber">The n-th can of cola</param>
        /// <returns>The name of the person who drinks the n-th can of cola</returns>
        public static string WhoIsNext(List<string> names, long colaNumber)
        {
            //Use this dictionary to track of how many clones there are of each person without using up loads of memory
            Dictionary<string, long> CloneTracker = new Dictionary<string, long>();
            foreach (var name in names)
            {
                CloneTracker.Add(name, 1);
            }

            for (long i = 0; i < colaNumber;)
            {
                foreach (var name in names.ToList())
                {
                    //Increment i for each clone and check if the cola belongs to one of them
                    for (long x = 1; x <= CloneTracker[name]; x++)
                    {
                        if (i + 1 == colaNumber)
                        {
                            return name;
                        }
                        i++;
                    }

                    CloneTracker[name] = CloneTracker[name] * 2;
                }
            }

            return "";
        }
    }
}
