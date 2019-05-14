using System;

namespace HomeWork_01.Figures
{
    public class CircleFactory : ShapeFactory
    {
        private const double Pi = Math.PI;

        public override Shape Create()
        {
            double shapeRadius;
            int tryCounter = RetryCount;
            bool result = false;
            do
            {
                Console.WriteLine("Enter \"Circle radius\" from 0 to 32000: ");
                result = double.TryParse(Console.ReadLine(), out shapeRadius) && shapeRadius > 0 && shapeRadius <= 32000;
                tryCounter--;
            } while (!result && tryCounter > 0);
            return new Circle(shapeRadius);
        }
    }
}
