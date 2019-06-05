namespace HomeWork_06.Bulbs
{
    internal class ColoredBulb : Bulb
    {
        public BulbColor BulbColor { get; set; }

        public ColoredBulb(BulbColor color)
        {
            BulbColor = color;
        }
    }
}
