using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreKatas
{
    public static class CalculatorKata
    {
        public static double Calculate(string expression)
        {
            var numbers = new List<string>();
            var operators = new List<char>();

            expression = expression.Replace(" ", "");
            bool newNumber = true;
            foreach (var character in expression)
            {
                if ((char.IsDigit(character) || character == '.') && newNumber)
                {
                    numbers.Add(character.ToString());
                    newNumber = false;
                }
                else if ((char.IsDigit(character) || character == '.') && !newNumber)
                {
                    numbers[numbers.IndexOf(numbers.LastOrDefault())] += character.ToString();
                }
                else if (!char.IsDigit(character))
                {
                    newNumber = true;
                    operators.Add(character);
                }
            }

            return Evaluate(numbers, operators);
        }

        private static double Evaluate(IList<string> numbers, IList<char> operators)
        {
            double returnVal = 0;
            for (int i = 0; i < operators.Count(); i++)
            {
                if (operators[i] == '+')
                {
                    returnVal = Convert.ToDouble(numbers[i]) + Convert.ToDouble(numbers[i + 1]);
                }
                if (operators[i] == '-')
                {
                    returnVal = Convert.ToDouble(numbers[i]) - Convert.ToDouble(numbers[i + 1]);
                }
                if (operators[i] == '*')
                {
                    returnVal = Convert.ToDouble(numbers[i]) * Convert.ToDouble(numbers[i + 1]);
                }
                if (operators[i] == '/')
                {
                    returnVal = Convert.ToDouble(numbers[i]) / Convert.ToDouble(numbers[i + 1]);
                }
            }

            return returnVal;
        }
    }
}
