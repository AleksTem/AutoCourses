namespace HomeWork_06.Bulbs
{
    internal class Bulb
    {
        public Light Status { get; set; }

        public Bulb()
        {
            Status = Light.Off;
        }
    }
}
