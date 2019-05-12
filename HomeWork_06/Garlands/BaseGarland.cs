using HomeWork_06.Bulbs;
using System;
using System.Collections.Generic;

namespace HomeWork_06.Garlands
{
    internal abstract class BaseGarland
    {
        protected Bulb[] _garland;

        protected BaseGarland(int garlandLength)
        {
            _garland = new Bulb[garlandLength];
        }

        public abstract void PrintGarlandsStatus(bool evenMinute);  
    }
}
