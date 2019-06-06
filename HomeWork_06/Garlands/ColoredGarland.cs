using HomeWork_06.Bulbs;
using System;

namespace HomeWork_06.Garlands
{
    internal class ColoredGarland : BaseGarland<ColoredBulb>
    {
        public ColoredGarland(int garlandLength) : base(garlandLength)
        {
            int bulbColors = Enum.GetValues(typeof(BulbColor)).Length;

            for (int i = 0; i < garlandLength; i++)
            {
                BulbColor color = (BulbColor)(i % bulbColors);
                _garland.Add(new ColoredBulb(color));
            }
        }

        public override void PrintGarlandsStatus(bool evenMinute)
        {
            SetLightStatusForCurrentMinute(evenMinute);
            Console.WriteLine("Colored garland:");
            for (int i = 0; i < _garland.Count; i++)
            {
                Console.Write($"Bulb #{ i + 1 } ");

                Enum.TryParse(_garland[i].BulbColor.ToString(), out ConsoleColor color);
                Console.ForegroundColor = color;
                Console.Write(_garland[i].BulbColor);
                Console.ResetColor();

                Console.WriteLine($" is {_garland[i].Status}");
            }
        }
    }
}
