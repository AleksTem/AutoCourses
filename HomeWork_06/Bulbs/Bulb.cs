using System;

namespace HomeWork_06.Bulbs
{
    internal class Bulb
    {
        public int Index { get; private set; }

        public Bulb(int index)
        {
            Index = index;
        }

        public Light GetStatus(bool evenMinute)
        {
            return !(Index % 2 == 0 ^ evenMinute) ? Light.On : Light.Off;
        }
    }
}
