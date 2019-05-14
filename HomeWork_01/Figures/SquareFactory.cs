using System;

namespace HomeWork_01.Figures
{
    public class SquareFactory : ShapeFactory
    {
        public override Shape Create()
        {
            double squareSide;
            int tryCounter = RetryCount;
            bool result = default(bool);
            do
            {
                Console.WriteLine("Enter \"Square side\" from 0 to 32000: ");
                result = double.TryParse(Console.ReadLine(), out squareSide) && (squareSide > 0) && squareSide <= 32000;
                tryCounter--;
            } while (!result && tryCounter > 0);
            return new Square(squareSide);
        }
    }
}
