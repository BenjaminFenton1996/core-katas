using System;
using System.Collections.Generic;
using System.Text;

namespace CoreLearningProject
{
    public static class RomanNumeralsKata
    {
        public static string IntegerToRomanNumerals(int number)
        {
            var romanNumerals = new StringBuilder();

            while (number > 0)
            {
                if (number >= 1000)
                {
                    romanNumerals.Append("M");
                    number -= 1000;
                }
                else if (number >= 900)
                {
                    romanNumerals.Append("CM");
                    number -= 900;
                }
                else if (number >= 500)
                {
                    romanNumerals.Append("D");
                    number -= 500;
                }
                else if (number >= 400)
                {
                    romanNumerals.Append("CD");
                    number -= 400;
                }
                else if (number >= 100)
                {
                    romanNumerals.Append("C");
                    number -= 100;
                }
                else if (number >= 90)
                {
                    romanNumerals.Append("XC");
                    number -= 90;
                }
                else if (number >= 50)
                {
                    romanNumerals.Append("L");
                    number -= 50;
                }
                else if (number >= 40)
                {
                    romanNumerals.Append("XL");
                    number -= 40;
                }
                else if (number >= 10)
                {
                    romanNumerals.Append("X");
                    number -= 10;
                }
                else if (number == 9)
                {
                    romanNumerals.Append("IX");
                    number -= 9;
                }
                else if (number >= 5)
                {
                    romanNumerals.Append("V");
                    number -= 5;
                }
                else if (number == 4)
                {
                    romanNumerals.Append("IV");
                    number -= 4;
                }
                else if (number >= 1)
                {
                    romanNumerals.Append("I");
                    number -= 1;
                }
            }

            return romanNumerals.ToString();
        }
    }
}
