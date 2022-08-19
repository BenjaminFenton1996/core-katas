using System;
using System.Collections.Generic;
using System.Text;

namespace CoreKatas
{
    public static class StripCommentsKata
    {
        /// <summary>
        /// Takes a string and removes all text after given symbols before the next line, if those symbols exist in the text
        /// </summary>
        /// <param name="text">The text to process and return</param>
        /// <param name="commentSymbols">The symbols to check the text for</param>
        /// <returns>The given text string with all text after the symbols but before the next line removed</returns>
        public static string StripComments(string text, string[] commentSymbols)
        {
            var splitText = text.Split('\n');
            text = "";

            for (int i = 0; i < splitText.Length; i++)
            {
                foreach (var symbol in commentSymbols)
                {
                    var startIndex = splitText[i].IndexOf(symbol);
                    if (startIndex == -1)
                        continue;

                    splitText[i] = splitText[i].Remove(startIndex, splitText[i].Length - startIndex);
                }

                if (i < splitText.Length - 1)
                {
                    text += splitText[i].TrimEnd() + "\n";
                }
                else
                {
                    text += splitText[i];
                }
            }

            return text.TrimEnd(' ');
        }
    }
}
