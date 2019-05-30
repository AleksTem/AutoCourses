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
            string phrase = CleanInput(input);
            return Reverse(phrase).Equals(phrase);
        }

        public static string Reverse(string source)
        {
            var ary = source.ToCharArray();
            Array.Reverse(ary);
            return new string(ary);
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
