using System;

namespace HomeWork_06.Bulbs
{
    internal class ColoredBulb : PlainBulb
    {
        #region Fields
        private BulbColor _color;

        #endregion Fields

        #region Properties
        public string Color => Enum.GetName(typeof(BulbColor), _color);

        #endregion Properpies

        #region Constructors

        public ColoredBulb(BulbColor color)
        {
            _color = color;
        }

        #endregion Constructors

        #region Methods
        #endregion Methods
    }
}
