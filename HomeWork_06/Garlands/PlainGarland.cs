using HomeWork_06.Bulbs;
using System;

namespace HomeWork_06.Garlands
{
    class PlainGarland : BaseGarland
    {
        public PlainGarland(int garlandLenght) : base(garlandLenght)
        {
            for (int i = 0; i < garlandLenght; i++)
            {
                _garland[i] = new Bulb(i);
            }
        }

        public override void PrintGarlandsStatus(bool evenMinute)
        {
            Console.WriteLine("Plain garland:");
            foreach (Bulb x in _garland)
            {
                Console.WriteLine($"Bulb { x.Index } is {x.GetStatus(evenMinute)}");
            }
        }
    }
}
