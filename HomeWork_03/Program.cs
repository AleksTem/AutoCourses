using System;
using System.Linq;


namespace HomeWork_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new CustomRange(10).Range;

            //Console.WriteLine("\n Selected numbers:");
            //foreach (int i in Array.FindAll(arr, x => (x % 3 == 0) && (x % 5 !=0)))
            //    Console.Write(i + " ");
            //Console.WriteLine("\n------");
            var _sum = Array.FindAll(arr, x => (x % 3 == 0) && (x % 5 != 0)).Sum();
            Console.WriteLine($"Sum of numbers that are divisible by 3 but not divisible by 5 is: {_sum}");
            Console.ReadKey();
        }  
    }
}
