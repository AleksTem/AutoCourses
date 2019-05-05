using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Priority_Queue;
using static HomeWork_05.CustomDefinitions;

namespace HomeWork_05
{
    class Program
    {
        enum Complexity
        {
            Low = 1,
            Middle = 2,
            High = 4
        };

        static void Main(string[] args)
        {
            var schedule = new Schedule();
            string choice;
            PrintCommands();
            do
            {
                Console.Write("Command: ");
                choice = Console.ReadLine();

                switch (choice)
                {
                    case "0":
                        PrintCommands();
                        break;
                    case "1":
                        schedule.AddTask();
                        break;
                    case "2":
                        schedule.SelectTotalTimeForTasks();
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

        static void PrintCommands()
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
