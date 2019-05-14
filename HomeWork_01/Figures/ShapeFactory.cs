namespace HomeWork_01.Figures
{
    public abstract class ShapeFactory
    {
        protected const int RetryCount = 3;
        public abstract Shape Create();
    }
}
