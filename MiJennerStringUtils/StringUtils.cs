using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MiJenner
{
    public static class StringUtils
    {
        public static int CountWords(string input)
        {
            string[] words = input.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            return words.Length;
        }

        public static int CountWords2(string input)
        {
            // Define a regular expression pattern to match non-word characters.
            // Use the \p{L} Unicode category to match any letter (including international characters).
            string pattern = @"[^\p{L}\s]+";

            // Use the regular expression to replace non-word characters with spaces.
            string cleanedInput = Regex.Replace(input, pattern, " ");

            // Split the cleaned input string by whitespace characters and remove any empty entries.
            string[] words = cleanedInput.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            return words.Length;
        }

        public static bool IsBinaryString(string input)
        {
            foreach (char c in input)
            {
                if (c != '0' && c != '1')
                {
                    return false;
                }
            }
            return true;
        }

        public static bool IsNumeric(string input)
        {
            return double.TryParse(input, out _);
        }

        public static string RemoveWhitespace(string input)
        {
            return string.Join("", input.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries));
        }

    }
}
