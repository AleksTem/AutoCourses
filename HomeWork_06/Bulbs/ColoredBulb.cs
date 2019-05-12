using System;

namespace HomeWork_06.Bulbs
{
    internal class ColoredBulb : Bulb
    {
        private BulbColor _color;

        public string Color => Enum.GetName(typeof(BulbColor), _color);

        public ColoredBulb(BulbColor color, int index) : base (index)
        {
            _color = color;
        }
    }
}
