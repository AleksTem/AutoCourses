using System;

namespace HomeWork_01.Figures
{
    public class SquareFactory : ShapeFactory
    {
        public override Shape Create()
        {
            Console.WriteLine("Square side?");
            double side = Double.Parse(Console.ReadLine());
            return new Square(side);
        }
    }
}
