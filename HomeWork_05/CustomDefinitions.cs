using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_05
{
    class CustomDefinitions
    {
        public enum Priority
        {
            Low,
            Middle,
            High
        }

        public enum Complexity
        {
            Light = 1,
            Medium = 2,
            Complex = 4
        }

        internal static string PrintDefinition<T>()
        {
            StringBuilder sb = new StringBuilder();
            foreach (int index in Enum.GetValues(typeof(T)))
                sb.Append($"{index}={Enum.GetName(typeof(T), index)} ");
            return sb.ToString();
        }


    }
}
