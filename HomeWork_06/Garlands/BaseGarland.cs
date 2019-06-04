using HomeWork_06.Bulbs;
using System.Collections.Generic;

namespace HomeWork_06.Garlands
{
    internal abstract class BaseGarland
    {
        protected List<Bulb> _garland;

        protected BaseGarland(int garlandLength)
        {
            _garland = new List<Bulb>(garlandLength);
            for (int i = 0; i < garlandLength; i++)
            {
                _garland.Add(new Bulb());
            }
        }

        public abstract void PrintGarlandsStatus(bool evenMinute);

        public virtual void SetLightStatus(bool evenMinute)
        {
            for (int i = 0; i < _garland.Count; i++)
            {
                _garland[i].Status = (i % 2 == 0 ^ evenMinute) ? true : false;
            }
        }
    }
}
