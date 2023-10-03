using System; 
using System.Text; 

namespace MiJenner
{
    public static class StringUtils
    {
        public static char[] charactersToReplace = { '\'', '"', '!', '|', '+', '-', '*', '/', '\\', '#', '$', '%', '&', '^', '(', ')', '[', ']', '{', '}', '.', ',', ';', '–', '—', '–',
                '>', '<', '=' };

        public static int CountWords(string input)
        {
            input = ReplaceSpecialCharactersWithSpace(input);
            string[] words = input.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            return words.Length;
        }

        public static string ReplaceSpecialCharactersWithNothing(string input)
        {
            StringBuilder result = new StringBuilder(input);

            foreach (char character in charactersToReplace)
            {
                result.Replace(character.ToString(), string.Empty);
            }

            return result.ToString();
        }

        public static string ReplaceSpecialCharactersWithSpace(string input)
        {
            StringBuilder result = new StringBuilder(input);

            foreach (char character in charactersToReplace)
            {
                result.Replace(character, ' ');
            }

            return result.ToString();
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
