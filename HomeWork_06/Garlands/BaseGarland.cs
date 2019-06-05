using HomeWork_06.Bulbs;
using System.Collections.Generic;

namespace HomeWork_06.Garlands
{
    internal abstract class BaseGarland<TBulbType> where TBulbType : Bulb
    {
        protected List<TBulbType> _garland;

        protected BaseGarland(int garlandLength)
        {
            _garland = new List<TBulbType>(garlandLength);
        }

        public abstract void PrintGarlandsStatus(bool evenMinute);

        public void SetLightStatusForCurrentMinute(bool evenMinute)
        {
            for (int i = 0; i < _garland.Count; i++)
            {
                _garland[i].Status = (i % 2 == 0 ^ evenMinute) ? Light.On : Light.Off;
            }
        }
    }
}
