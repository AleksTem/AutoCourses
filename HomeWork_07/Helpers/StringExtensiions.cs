using System;
using System.Text.RegularExpressions;

namespace HomeWork_07.Helpers
{
    public static class StringExtensiions
    {
        public static string PrepareForComparison(this string input)
        {
            return input.CleanFromSpecSimbols()
                .ToLower()
                .FirstLetterToUpperCase();
        }

        /// <summary>
        /// Returns the input string with the first character converted to uppercase, or mutates any nulls passed into string.Empty
        /// </summary>
        public static string FirstLetterToUpperCase(this string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }

            char[] a = s.ToCharArray();
            a[0] = char.ToUpper(a[0]);
            return new string(a);
        }

        /// <summary>
        /// Returns the input string without special characters
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string CleanFromSpecSimbols(this string input)
        {
            try
            {
                return Regex.Replace(input, @"[^\w\.@-]", "",
                                     RegexOptions.None, TimeSpan.FromSeconds(1.5));
            }
            catch (RegexMatchTimeoutException)
            {
                return String.Empty;
            }
        }


    }
}
