using HomeWork_06.Bulbs;
using System;
using System.Collections.Generic;

namespace HomeWork_06.Garlands
{
    class ColoredGarland : BaseGarland
    {
        private ColoredBulb[] _garland;
        
        public ColoredGarland(int garlandLength) : base (garlandLength)
        {
            _garland = new ColoredBulb[garlandLength];
            int bulbColors = Enum.GetValues(typeof(BulbColor)).Length;
            int step = bulbColors - 1;

            for (int j = 1; j < bulbColors; j++)
            {
                BulbColor color = Enum.IsDefined(typeof(BulbColor), j) ? (BulbColor)j : BulbColor.NoColor;
                for (int i = j-1; i < garlandLength; i += step)
                {
                    _garland[i] = new ColoredBulb(color, i);
                }
            }            
        }

        public override void PrintGarlandsStatus(bool evenMinute)
        {
            Console.WriteLine("Colored garland:");
            foreach (ColoredBulb x in _garland)
            {
                Console.WriteLine($"Bulb { x.Index } ({x.Color}) is {x.GetStatus(evenMinute)}");
            }
        }
    }
}
