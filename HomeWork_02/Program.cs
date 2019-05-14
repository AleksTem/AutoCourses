using HomeWork_01.Figures;
using System;

namespace HomeWork_02
{
    public class Program
    {
        static void Main(string[] args)
        {
            var squareSide = new SquareFactory().Create().Parameter;
            var circleRadius = new CircleFactory().Create().Parameter;

            string result;
            //Круг вписан в квадрат
            if (squareSide >= 2 * circleRadius)
            {
                result = "Circle inscribed in square";
            }
            //Круг описан вокруг квадрата
            else if (Math.Round(Math.Sqrt(2) / 2 * squareSide, 2) <= circleRadius)
            {
                result = "The circle described around the square";
            }
            //Фигуры пересекаются
            else
            {
                result = "Figures intersect";
            }
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
