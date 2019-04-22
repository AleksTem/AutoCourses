using System;

namespace HomeWork_01.Figures
{
    public class Circle : Shape
    {
        private const double Pi = Math.PI;

        public Circle()
        {
            Console.WriteLine("Circle radius ?");
            var radius = Double.Parse(Console.ReadLine());
            new Circle(radius);
        }

        public Circle(double radius) : base(radius)
        {
        }

        public override double Area() => Pi * Parameter;
    }
}
