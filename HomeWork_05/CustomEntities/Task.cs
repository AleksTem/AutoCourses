
using HomeWork_05.CustomEnums;
using System;
using System.Text;

namespace HomeWork_05.CustomEntities
{
    internal class Task
    {
        #region Fields
        internal string Description { get; set; }
        internal Priority Priority { get; set; }
        internal Complexity Complexity { get; set; }
        #endregion Fields

        #region Constructors
        internal Task()
        {
            Description = RequestDescription();
            Priority = RequestPriority();
            Complexity = RequestComplexity();
        }

        #endregion Constructors

        #region Methods
        internal static string RequestDescription()
        {
            Console.WriteLine("Create New Task.");
            Console.WriteLine("Description: ");
            return Console.ReadLine();
        }

        internal static Priority RequestPriority()
        {
            Priority result;
            bool outcome;
            do
            {
                Console.Write($"Priority ({PrintEnumDefinition<Priority>()})?: ");
                string _pr = Console.ReadLine();
                outcome = Enum.TryParse<Priority>(_pr, true, out result) & Enum.IsDefined(typeof(Priority), result);
            } while (!outcome);

            return result;
        }

        internal static Complexity RequestComplexity()
        {
            Complexity result;
            bool outcome;
            do
            {
                Console.Write($"Complexity ({PrintEnumDefinition<Complexity>()})?: ");
                string _c = Console.ReadLine();
                outcome = Enum.TryParse<Complexity>(_c, true, out result) & Enum.IsDefined(typeof(Complexity), result);
            } while (!outcome);
            return result;
        }

        internal static string PrintEnumDefinition<T>()
        {
            StringBuilder sb = new StringBuilder();
            foreach (int index in Enum.GetValues(typeof(T)))
                sb.Append($"{index}={Enum.GetName(typeof(T), index)} ");
            return sb.ToString();
        }

        internal override string ToString()
        {
            return $"=====\nTask:{Description}\n Priority: {Enum.GetName(typeof(Priority), Priority)}" +
                $"\n Complexity: {Enum.GetName(typeof(Complexity), Complexity)}\n=====\n";
        }
        #endregion Methods
    }
}
