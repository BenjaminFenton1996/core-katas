using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CoreKatas
{
    public static class ValidNameKata
    {
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
