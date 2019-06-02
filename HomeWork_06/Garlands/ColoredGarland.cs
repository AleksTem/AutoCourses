using HomeWork_06.Bulbs;
using System;
using System.Collections.Generic;

namespace HomeWork_06.Garlands
{
    class ColoredGarland : BaseGarland
    {
        private new List<ColoredBulb> _garland;

        public ColoredGarland(int garlandLength) : base(garlandLength)
        {
            _garland = new ColoredBulb[garlandLength];
            int bulbColors = Enum.GetValues(typeof(BulbColor)).Length;
            int step = bulbColors - 1;

            for (int j = 1; j < bulbColors; j++)
            {
                BulbColor color = Enum.IsDefined(typeof(BulbColor), j) ? (BulbColor)j : BulbColor.White;
                for (int i = j - 1; i < garlandLength; i += step)
                {
                    _garland[i] = new ColoredBulb(color, i);
                }
            }
        }

        public override void PrintGarlandsStatus(bool evenMinute)
        {
            Console.WriteLine("Colored garland:");
            SetLightStatus(evenMinute);
            for (int i = 0; i < _garland.Count; i++)
            {
                ConsoleColor currentColor = Console.BackgroundColor;
                Console.BackgroundColor = (ConsoleColor)_garland[i].BulbColor;
                Console.WriteLine($"Bulb { i } ({_garland[i].BulbColor}) is {(_garland[i].Status ? "On" : "Off")}");
                Console.BackgroundColor = currentColor;
            }
        }


    }
}
