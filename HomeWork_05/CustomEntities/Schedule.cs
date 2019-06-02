

using HomeWork_05.CustomEnums;
using HomeWork_05.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HomeWork_05.CustomEntities
{
    internal class Schedule
    {
        #region Fields

        private List<Task> _tasks;
        #endregion Fields

        #region Properties
        public int TotalHours { get; private set; }

        #endregion Properties


        #region Constructors
        public Schedule()
        {
            _tasks = new List<Task>();
            TotalHours = 0;
        }

        #endregion Constructors


        #region Methods
        public void AddNewTask()
        {
            Task task = new Task();
            _tasks.Add(task);
            TotalHours += (int)task.Complexity;
            Console.WriteLine("New task added.");
        }

        public void SelectTasksByPriority()
        {
            Priority selectedPriority = Helper.RequestForEnumValue<Priority>();
            List<Task> list = _tasks.FindAll(x => x.Priority.Equals(selectedPriority)).ToList();
            Console.WriteLine($"There is {list.Count} tasks with priority \"{Enum.GetName(typeof(Priority), selectedPriority)}\"");
            foreach (Task task in list)
            {
                Console.WriteLine(task);
            }
        }

        public void GetTotalTimeForTasks()
        {
            Console.WriteLine($"Total time for tasks: {TotalHours} hours.\n");
        }

        public void PossibleCompletedTasks()
        {
            Console.Write("Enter available days:");
            int availableHours = 8 * int.Parse(Console.ReadLine());
            _tasks.Sort((x, y) =>
            {
                //if (x.Priority > y.Priority)
                if (x.Weight > y.Weight)
                {
                    return -1;
                }
                //else if (x.Priority < y.Priority)
                else if (x.Weight < y.Weight)
                {
                    return 1;
                }
                else return 0;
            });
            Console.WriteLine("Possible complete next tasks:");
            for (int i = 0; i < _tasks.Count; i++)
            {
                int taskDuration = (int)_tasks[i].Complexity;
                if (availableHours >= taskDuration)
                {
                    Console.Write(_tasks[i]);
                    availableHours -= taskDuration;
                }
            }
        }

        public void PrintAllTasks()
        {
            for (int i = 0; i < _tasks.Count; i++)
            {
                Console.WriteLine(_tasks[i]);
            }
        }

        #endregion Methods
    }
}
