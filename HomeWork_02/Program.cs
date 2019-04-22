using System;
using HomeWork_01.Figures;

namespace HomeWork_02
{
    class Program
    {
        static void Main(string[] args)
        {
            var squareSide = new SquareFactory().Create().Parameter;
            var circleRadius = new CircleFactory().Create().Parameter;
            string result = squareSide > 2 * circleRadius
                ? "Circle fit in a square" : "Square fit in a circle";                
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
