using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_04
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] temp;
            string word;
            Console.WriteLine("Введите тестируемое на \"палиндромность\" слово");
            word = Console.ReadLine();
            temp = word.ToCharArray();
            Array.Reverse(temp);
            var dd = temp.ToString();
            if (dd.Equals(word))
            {
                Console.WriteLine("Это палиндром");
            }
            else
            {
                Console.WriteLine("Это не палиндром");
            }
            Console.ReadKey();
        }
    }
}
