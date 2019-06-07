using System;

namespace HomeWork_05
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
    class EnumValueAttribute : Attribute
    {
        public EnumValueAttribute(int value)
        {
            EnumValue = value;
        }

        public int EnumValue { get; }
    }
}
