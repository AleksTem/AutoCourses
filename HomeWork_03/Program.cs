using System;
using System.Linq;


namespace HomeWork_03
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] arr = new CustomRange(10).Range;
            long _sum = Array.FindAll(arr, x => (x % 3 == 0) && (x % 5 != 0)).Sum();
            Console.WriteLine($"Sum of numbers that are divisible by 3 but not divisible by 5 is: {_sum}");
            Console.ReadKey();
        }
    }
}
