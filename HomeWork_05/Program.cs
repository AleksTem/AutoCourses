using HomeWork_05.CustomEntities;
using System;

namespace HomeWork_05
{
    class Program
    {
        public static void Main(string[] args)
        {
            Schedule schedule = new Schedule();
            string choice;
            PrintCommands();
            do
            {
                Console.Write("Command: \n");
                choice = Console.ReadLine();

                switch (choice)
                {
                    case "0":
                        PrintCommands();
                        break;
                    case "1":
                        schedule.AddNewTask();
                        break;
                    case "2":
                        schedule.GetTotalTimeForTasks();
                        break;
                    case "3":
                        schedule.SelectTasksByPriority();
                        break;
                    case "4":
                        schedule.PossibleCompletedTasks();
                        break;
                    case "5":
                        break;
                }
            } while (!choice.Equals("5"));
        }

        internal static void PrintCommands()
        {
            Console.WriteLine("Available commands:");
            Console.WriteLine("0 - Print availiable commands");
            Console.WriteLine("1 - Add new Task");
            Console.WriteLine("2 - Get total time to complete tasks");
            Console.WriteLine("3 - List of Tasks with selected priority");
            Console.WriteLine("4 - Possible completed tasks in N days");
            Console.WriteLine("5 - Exit");
            Console.WriteLine();
        }
    }
}
