using System;

namespace HomeWork_04
{
    class InputHelper
    {
        public static string GetPhrase(int retryCount)
        {
            string input, result = string.Empty;
            bool inputCheck = true;

            do
            {
                Console.Write("Get a phrase:");
                input = Console.ReadLine();
                retryCount--;
                if (input.Length > 2)
                {
                    inputCheck = false;
                    result = input;
                }
            } while (inputCheck && retryCount > 0);
            return result;
        }
    }
}
