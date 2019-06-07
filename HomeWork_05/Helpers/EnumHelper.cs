using System;
using System.Reflection;
using System.Text;

namespace HomeWork_05.Helpers
{
    class EnumHelper
    {
        public static string PrintEnumDefinition<TEnum>() where TEnum : struct
        {
            StringBuilder sb = new StringBuilder();
            foreach (int index in Enum.GetValues(typeof(TEnum)))
            {
                sb.Append($"{Enum.GetName(typeof(TEnum), index)}={index} ");
            }
            return sb.ToString();
        }

        public static TEnum RequestForEnumValue<TEnum>() where TEnum : struct
        {
            TEnum result;
            bool parseResult;
            do
            {
                Console.Write($"{typeof(TEnum).Name} ({PrintEnumDefinition<TEnum>()})?: ");
                string _pr = Console.ReadLine();
                parseResult = Enum.TryParse(_pr, ignoreCase: true, result: out result)
                    & Enum.IsDefined(typeof(TEnum), result);
            } while (!parseResult);
            return result;
        }

        public static int GetEnumValueAttribute<TEnum>(Enum value) where TEnum : struct
        {
            // Get the EnumValue attribute value for the enum value
            FieldInfo fi = value.GetType().GetField(value.ToString());
            EnumValueAttribute attribute = (EnumValueAttribute)fi.GetCustomAttribute(typeof(EnumValueAttribute), false);
            return attribute.EnumValue;
        }
    }
}
