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
            _garland = new List<ColoredBulb>(garlandLength);
            int bulbColors = Enum.GetValues(typeof(BulbColor)).Length;

            for (int i = 0; i < garlandLength; i++)
            {
                BulbColor color = (BulbColor)(i % bulbColors);
                _garland.Add(new ColoredBulb(color));
            }
        }

        public override void PrintGarlandsStatus(bool evenMinute)
        {
            Console.WriteLine("Colored garland:");
            SetLightStatus(evenMinute);
            for (int i = 0; i < _garland.Count; i++)
            {
                ConsoleColor color;
                Enum.TryParse(_garland[i].BulbColor.ToString(), out color);

                Console.Write($"Bulb #{ i } ");
                Console.ForegroundColor = color;
                Console.Write(_garland[i].BulbColor);
                Console.ResetColor();
                Console.WriteLine($" is {_garland[i].Status}");
            }
        }

        public override void SetLightStatus(bool evenMinute)
        {
            for (int i = 0; i < _garland.Count; i++)
            {
                _garland[i].Status = (i % 2 == 0 ^ evenMinute) ? Light.On : Light.Off;
            }
        }


    }
}
