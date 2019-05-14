namespace HomeWork_01.Figures
{
    public abstract class Shape
    {
        private readonly double _parameter;

        public double Parameter => _parameter;

        public Shape(double parameter) => _parameter = parameter > 0 ? parameter : 0;

        public abstract double Area();
    }
}
