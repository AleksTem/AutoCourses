using System;
using System.Collections.Generic;

namespace HomeWork_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Дайте словечко:");
            string input = Console.ReadLine();

            LinkedList<char> word = new LinkedList<char>(input);

            if (CheckForPalindrome(word))
                Console.WriteLine($" Слово \"{input}\" является палиндромом.");
            else
                Console.WriteLine($" Слово \"{input}\" не является палиндромом.");
            Console.ReadKey();
        }

        private static bool CheckForPalindrome(LinkedList<char> chars)
        {
            if (chars.Count <= 1)
            {
                return true;
            }
            else
            {
                if (!chars.First.Value.Equals(chars.Last.Value))
                {
                    return false;
                }
                else
                {
                    chars.RemoveFirst();
                    chars.RemoveLast();
                    return CheckForPalindrome(chars);
                }
            }
        }

    }
}
