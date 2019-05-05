using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HomeWork_05.CustomDefinitions;

namespace HomeWork_05
{
    class Task
    {
        internal string Description { get; set; }
        internal Priority Priority { get; set; }
        internal Complexity Complexity { get; set; }

        public Task()
        {
            Description = RequestDescription();
            Priority = RequestPriority();
            Complexity = RequestComplexity();
        }

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
                Console.Write($"Priority ({PrintDefinition<Priority>()})?: ");
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
                Console.Write($"Complexity ({PrintDefinition<Complexity>()})?: ");
                string _c = Console.ReadLine();
                outcome = Enum.TryParse<Complexity>(_c, true, out result) & Enum.IsDefined(typeof(Complexity), result);
            } while (!outcome);
            return result;
        }

        public override string ToString()
        {
            return $"=====\nTask:{Description}\n Priority: {Enum.GetName(typeof(Priority), Priority)}" +
                $"\n Complexity: {Enum.GetName(typeof(Complexity), Complexity)}\n=====\n";
        }
    }
}
