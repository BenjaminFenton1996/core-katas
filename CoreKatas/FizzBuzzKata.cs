using System;
using System.Collections.Generic;
using System.Text;

namespace CoreKatas
{
    public static class FizzBuzzKata
    {
        public static string FizzBuzz(int count)
        {
            var fizzBuzzString = new StringBuilder();
            for (int i = 1; i <= count; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    fizzBuzzString.Append("FizzBuzz");
                }
                else if (i % 3 == 0 || i.ToString().Contains("3"))
                {
                    fizzBuzzString.Append("Fizz");
                }
                else if (i % 5 == 0 || i.ToString().Contains("5"))
                {
                    fizzBuzzString.Append("Buzz");
                }
                else
                {
                    fizzBuzzString.Append(i);
                }
            }
            return fizzBuzzString.ToString();
        }
    }
}
