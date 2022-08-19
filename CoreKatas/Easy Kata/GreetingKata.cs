using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace CoreKatas
{
    //https://github.com/testdouble/contributing-tests/wiki/Greeting-Kata
    public static class GreetingKata
    {
        //Accept one name
        public static string Greet(string name)
        {
            //If name is empty or null
            if (string.IsNullOrEmpty(name))
            {
                return "Hello, my friend.";
            }

            //If name has any commas
            if (name.Contains(","))
            {
                Greet(name.Split(','));
            }

            //If name is all uppercase
            if (IsUpperCase(name))
            {
                return string.Format("HELLO {0}!", name);
            }

            //If name contains lowercase characters
            return string.Format("Hello, {0}.", name);
        }

        //Accept multiple names in a List
        public static string Greet(List<string> names)
        {
            if (names.Count == 1)
            {
                return Greet(names[0]);
            }

            var greeting = new StringBuilder();
            var upperCaseMeeting = new StringBuilder();
            names = SplitAtCommas(names);
            var upperCaseNames = SeperateUpperCaseText(ref names);
            for (int i = 0; i < names.Count; i++)
            {
                if (i == 0)
                {
                    greeting.Append(string.Format("Hello, {0}", names[i]));
                }
                else if (i == names.Count - 1)
                {
                    greeting.Append(string.Format(" and {0}.", names[i]));
                }
                else
                {
                    greeting.Append(string.Format(", {0}", names[i]));
                }
            }

            for (int i = 0; i < upperCaseNames.Count; i++)
            {
                if(upperCaseNames.Count == 1)
                {
                    upperCaseMeeting.Append(string.Format(" AND HELLO {0}!", upperCaseNames[i]));
                }
                else if (i == 0)
                {
                    upperCaseMeeting.Append(string.Format(" AND HELLO {0}", upperCaseNames[i]));
                }
                else if (i == upperCaseNames.Count - 1)
                {
                    upperCaseMeeting.Append(string.Format(" AND {0}!", upperCaseNames[i]));
                }
                else
                {
                    upperCaseMeeting.Append(string.Format(", {0}", upperCaseNames[i]));
                }                
            }


            return greeting.ToString() + upperCaseMeeting.ToString();
        }

        //Accept multiple names in an Array
        public static string Greet(string[] names)
        {
            var namesList = new List<string>();
            for (int i = 0; i < names.Length; i++)
            {
                namesList.Add(names[i]);
            }
            return Greet(namesList);
        }

        //Check if a string contains only uppercase characters
        public static bool IsUpperCase(string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                if (!char.IsUpper(text[i]))
                {
                    return false;
                }
            }
            return true;
        }

        //Seperates out all upper case strings into a new array
        public static List<string> SeperateUpperCaseText(ref List<string> stringList)
        {
            var lowerCaseStrings = new List<string>();
            var upperCaseStrings = new List<string>();
            foreach (var text in stringList)
            {
                if (IsUpperCase(text))
                {
                    upperCaseStrings.Add(text);
                }
                else
                {
                    lowerCaseStrings.Add(text);
                }
            }
            stringList = lowerCaseStrings;
            return upperCaseStrings;
        }

        //Split strings in a List if they contain commas
        public static List<string> SplitAtCommas(List<string> stringList)
        {
            var processedStringList = new List<string>();
            foreach (var text in stringList)
            {
                if (text.Contains(",") && !Regex.Match(text, "\"(.*?)\"").Success)
                {
                    var splitTexts = text.Split(',');
                    foreach (var splitText in splitTexts)
                    {
                        processedStringList.Add(splitText.Trim());
                    }
                }
                else
                {
                    processedStringList.Add(text.Replace("\"", string.Empty));
                }
            }
            return processedStringList;
        }
    }
}