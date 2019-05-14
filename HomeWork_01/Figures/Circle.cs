using System;

namespace HomeWork_01.Figures
{
    public class Circle : Shape
    {
        private const double Pi = Math.PI;

        public Circle(double radius) : base(radius)
        {
        }

        public override double Area() => Math.Round(Pi * Parameter, 2);
    }
}
