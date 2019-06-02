
using HomeWork_05.CustomEnums;
using HomeWork_05.Helpers;
using System;

namespace HomeWork_05.CustomEntities
{
    public class Task
    {
        #region Properties
        private string _description;
        private readonly Priority _priority;
        private readonly Complexity _complexity;
        #endregion


        #region Fields
        public string Description
        {
            get => _description;
            set
            {
                bool parseResult = default(bool);
                string result;
                do
                {
                    Console.WriteLine("Description: ");
                    result = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(result) || string.IsNullOrEmpty(result))
                    {
                        Console.WriteLine("Description can not be empty");
                    }
                    else
                    {
                        parseResult = true;
                        _description = result;
                    }
                } while (!parseResult);
            }
        }
        public Priority Priority
        {
            get => _priority;
        }
        public Complexity Complexity
        {
            get => _complexity;
        }

        public int Weight { get => 100 * (int)_priority + 10 * (int)_complexity; }
        #endregion Fields

        #region Constructors
        public Task()
        {
            Console.WriteLine("Create New Task.");
            Description = "";
            _priority = Helper.RequestForEnumValue<Priority>();
            _complexity = Helper.RequestForEnumValue<Complexity>();
        }

        #endregion Constructors

        #region Methods
        public override string ToString()
        {
            return $"=====\nTask:{Description}\n Priority: {Enum.GetName(typeof(Priority), Priority)}" +
                $"\n Complexity: {Enum.GetName(typeof(Complexity), Complexity)}\n=====\n";
        }
        #endregion Methods
    }
}
