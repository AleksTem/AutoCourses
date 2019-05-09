using HomeWork_06.Bulbs;
using System;
using System.Collections.Generic;

namespace HomeWork_06.Garlands
{
    class ColoredGarland : BaseGarland
    {
        private List<ColoredBulb> _coloredGarland;
        public ColoredGarland(int garlandLength)
        {
            _coloredGarland = new List<ColoredBulb>(garlandLength);
            for (j = 1; j <= 4)
                for (int i = Enum. ; i < garlandLength; i += 4)
                {
                    var color =
                        i % 4 == 0 ? BulbColor.Blue :
                        i % 3 == 0 ? BulbColor.Green :
                        i % 2 == 0 ? BulbColor.Yellow :
                        BulbColor.Red;
                    _coloredGarland[i] = new ColoredBulb(color);
                }
        }
    }
}
