using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CoreKatas
{
    public static class WeightForWeightKata
    {
        /// <summary>
        /// Orders a series of numbers by their combined digit values (so 19 is 1 + 9 so 20, 80 is 8 + 0 so 8 etc.)
        /// If two numbers result in an identical value (90 and 900 for example) then the strings must be compared meaning 900 takes priority
        /// </summary>
        /// <param name="weights">Weight values separated by spaces</param>
        /// <returns>A string containing the weight values ordered by their digits combined values and by their string weights</returns>
        public static string OrderWeight(string weights)
        {
            var splitWeights = weights.Split(" ");
            var weightsList = new (string weightString, int combinedWeight)[splitWeights.Length];
            for (int i = 0; i < splitWeights.Length; i++)
            {
                int combinedWeight = 0;
                foreach (var weight in splitWeights[i])
                    combinedWeight += Convert.ToInt32(weight.ToString());

                weightsList[i] = (splitWeights[i], combinedWeight);
            }
            weightsList = weightsList.OrderBy(x => x.combinedWeight).ThenBy(x => x.weightString).ToArray();

            var stringBuilder = new StringBuilder();
            for (int i = 0; i < weightsList.Length; i++)
            {
                stringBuilder.Append(weightsList[i].weightString);
                if (i < weightsList.Length - 1)
                    stringBuilder.Append(" ");
            }

            return stringBuilder.ToString();
        }
    }
}
