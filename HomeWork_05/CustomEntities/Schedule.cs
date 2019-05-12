﻿

using HomeWork_05.CustomEnums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HomeWork_05.CustomEntities
{
    internal class Schedule
    {
        #region Fields

        private List<Task> _tasks;
        private TaskFactory _factory;
        #endregion Fields

        #region Properties
        public int TotalHours { get; private set; }

        #endregion Properties


        #region Constructors
        public Schedule()
        {
            _tasks = new List<Task>();
            _factory = new TaskFactory();
            TotalHours = 0;
        }

        #endregion Constructors


        #region Methods
        public void AddNewTask()
        {
            Task task = _factory.Create();
            _tasks.Add(task);
            TotalHours += (int)task.Complexity;
            Console.WriteLine("New task added.");
        }

        public void SelectTasksByPriority()
        {
            Priority selectedPriority = Task.RequestPriority();
            List<Task> list = _tasks.FindAll(x => x.Priority.Equals(selectedPriority)).ToList();
            Console.WriteLine($"There is {list.Count} tasks with priority \"{Enum.GetName(typeof(Priority), selectedPriority)}\"");
            foreach (Task task in list)
                Console.WriteLine(task);
        }

        public void GetTotalTimeForTasks()
        {
            Console.WriteLine($"Total time for tasks: {TotalHours} hours.\n");
        }

        public void PossibleCompletedTasks()
        {
            Console.Write("Enter available days:");
            int availableHours = 24 * int.Parse(Console.ReadLine());
            _tasks.Sort((x, y) =>
            {
                if (x.Priority > y.Priority)
                    return -1;
                else if (x.Priority < y.Priority)
                    return 1;
                else return 0;
            });
            Console.WriteLine("Possible complete next tasks:");
            for (int i = 0; i < _tasks.Count; i++)
            {
                availableHours -= (int)_tasks[i].Complexity;
                if (availableHours > 0)
                    Console.Write(_tasks[i]);
                else
                    break;
            }
        }

        public void PrintAllTasks()
        {
            for (int i = 0; i < _tasks.Count; i++)
                Console.WriteLine(_tasks[i]);
        }

        #endregion Methods
    }
}