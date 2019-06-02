namespace HomeWork_06.Bulbs
{
    internal class Bulb
    {
        public BulbColor BulbColor { get; set; }
        public bool Status { get; set; }

        public Bulb()
        {
            BulbColor = BulbColor.White;
            Status = false;
        }
    }
}
