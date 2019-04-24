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

            string result;
            if (squareSide > 2 * circleRadius)
            {
                result = "Circle fit in a square";
            }
            else if (Math.Sqrt(2) * squareSide / 4 < circleRadius)
            {
                result = "Square fit in a circle";
            }
            else
            {
                result = "Figures intersect";
            }
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
