using System;
using System.Text.RegularExpressions;

namespace HomeWork_04
{
    class PalindromAnalizer
    {
        public bool CheckForPalindrome(string input)
        {
            if (input.Equals(string.Empty))
            {
                return false;
            }
            string phrase = CleanInput(input).ToLower();
            return Reverse(phrase).Equals(phrase);
        }

        public static string Reverse(string source)
        {
            char[] ary = source.ToCharArray();
            char[] result = new char[ary.Length];
            for (int i = 0, j = ary.Length - 1; i < ary.Length; i++, j--)
            {
                result[i] = ary[j];
            }
            return new string(result);
        }

        private static string CleanInput(string strIn)
        {
            try
            {
                return Regex.Replace(strIn, @"[^\w\.@-]", "",
                                     RegexOptions.None, TimeSpan.FromSeconds(1.5));
            }
            catch (RegexMatchTimeoutException)
            {
                return String.Empty;
            }
        }
    }
}
