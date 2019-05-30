using System;

namespace HomeWork_04
{
    class Program
    {
        private const int RetryCount = 3;
        static void Main(string[] args)
        {
            string choice;
            Console.WriteLine("Check for Palindrom\n");
            PrintCommands();
            do
            {
                Console.Write("Command: ");
                choice = Console.ReadLine();

                switch (choice)
                {
                    case "0":
                        PrintCommands();
                        break;
                    case "1":
                        CheckPhraseOnPalindrom();
                        break;
                    case "2":
                        break;
                }
            } while (!choice.Equals("2"));
        }

        private static void PrintCommands()
        {
            Console.WriteLine("\nAvailable commands:");
            Console.WriteLine("0 - Print availiable commands");
            Console.WriteLine("1 - Check phrase for palindrome");
            Console.WriteLine("2 - Exit");
            Console.WriteLine();
        }

        private static void CheckPhraseOnPalindrom()
        {
            string inputPhrase = InputHelper.GetPhrase(RetryCount);
            if (new PalindromAnalizer().CheckForPalindrome(inputPhrase))
            {
                Console.WriteLine($"Phrase \"{inputPhrase}\" is palindrome.");
            }
            else
            {
                Console.WriteLine($"Phrase \"{inputPhrase}\" is not a palindrome.");
            }
        }



    }
}
