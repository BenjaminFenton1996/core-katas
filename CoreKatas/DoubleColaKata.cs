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
        public static string WhoIsNext(string[] names, long colaNumber)
        {
            //Use this dictionary to track how many clones there are of each person without using up loads of memory
            Dictionary<string, long> CloneTracker = new Dictionary<string, long>();
            foreach (var name in names)
            {
                CloneTracker.Add(name, 1);
            }

            for (long i = 0; i < colaNumber;)
            {
                foreach (var name in names.ToList())
                {
                    //Check if the cola belongs to one of the clone groups
                    if (i <= colaNumber && colaNumber <= i + CloneTracker[name])
                    {
                        return name;
                    }
                    i += CloneTracker[name];

                    //Cloning the clones means doubling the tracker counter each time
                    CloneTracker[name] = CloneTracker[name] * 2;
                }
            }

            return "";
        }
    }
}
