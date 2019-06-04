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
                _garland[i] = new Bulb();
            }
        }

        public override void PrintGarlandsStatus(bool evenMinute)
        {
            Console.WriteLine("Plain garland:");
            SetLightStatus(evenMinute);
            for (int i = 0; i < _garland.Count; i++)
            {
                Console.WriteLine($"Bulb {i} is {(_garland[i].Status ? "On" : "Off")}");
            }
        }


    }
}
