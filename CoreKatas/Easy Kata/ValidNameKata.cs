using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CoreKatas
{
    public static class ValidNameKata
    {
        /// <summary>
        /// Names must have a length of 4 or more
        /// Names must start with a letter
        /// Names must consist of only letters, numbers and optionally one underscore
        /// Names must not end with an underscore
        /// </summary>
        /// <param name="name">The string to check the validity of as a name</param>
        /// <returns>Bool indicating whether the name is valid or not</returns>
        public static bool IsNameValid(string name)
        {
            if (name.Length < 4)
            {
                return false;
            }
            else if (name.EndsWith("_"))
            {
                return false;
            }
            else if (!char.IsLetter(name.FirstOrDefault()))
            {
                return false;
            }
            else if (name.Where(x => x == '_').Count() > 1)
            {
                return false;
            }
            else if (!Regex.IsMatch(name, @"^[a-zA-Z0-9_]+$"))
            {
                return false;
            }

            return true;
        }
    }
}
