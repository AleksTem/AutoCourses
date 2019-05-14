using HomeWork_01.Figures;
using System;

namespace HomeWork_01
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Square area: {new SquareFactory().Create().Area()}");
            Console.WriteLine($"Circle area: {new CircleFactory().Create().Area()}");
            Console.ReadKey();
        }
    }
}
