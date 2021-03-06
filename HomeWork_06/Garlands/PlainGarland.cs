﻿using HomeWork_06.Bulbs;
using System;

namespace HomeWork_06.Garlands
{
    class PlainGarland : BaseGarland<Bulb>
    {
        public PlainGarland(int garlandLenght) : base(garlandLenght)
        {
            for (int i = 0; i < garlandLenght; i++)
            {
                _garland.Add(new Bulb());
            }
        }

        public override void PrintGarlandsStatus(bool evenMinute)
        {
            SetLightStatusForCurrentMinute(evenMinute);
            Console.WriteLine("Plain garland:");
            for (int i = 0; i < _garland.Count; i++)
            {
                Console.WriteLine($"Bulb {i + 1} is {_garland[i].Status}");
            }
        }
    }
}
