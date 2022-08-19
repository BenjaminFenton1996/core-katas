using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreKatas
{
    public class FirstNonRepeatingChar
    {
        public static string FirstNonRepeatingLetter(string s)
        {
            foreach (char c in s)
            {
                if (CountLetters(s, c) == 1)
                {
                    return c.ToString();
                }
            }
            return "";
        }

        public static int CountLetters(string s, char c)
        {
            return s.Where(x => x.ToString().ToLower() == c.ToString().ToLower()).Count();
        }
    }
}
