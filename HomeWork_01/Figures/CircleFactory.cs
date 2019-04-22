using System;

namespace HomeWork_01.Figures
{
    public class CircleFactory : ShapeFactory
    {
        private const double Pi = Math.PI;

        public override Shape Create()
        {
            Console.WriteLine("Circle radius?");
            var radius = Double.Parse(Console.ReadLine());
            return new Circle(radius);
        }
    }
}
