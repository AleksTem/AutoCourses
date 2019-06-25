using HomeWork_06.Garlands;
using System;

namespace HomeWork_06
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintWelcome();
            PrintCommands();
            string choice = default(string);
            Tuple<PlainGarland, ColoredGarland> garlands = null;

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
                        garlands = GetUserInput();
                        break;
                    case "2":
                        PrintGarlandsStatus(garlands);

                        break;
                }
            } while (!choice.Equals("3"));

        }

        private static Tuple<PlainGarland, ColoredGarland> GetUserInput()
        {
            int plainGarlandLength = 0;
            int coloredGarlandLength = 0;
            bool result = default(bool);

            do
            {
                Console.Write("Input length for plain garland: ");
                result = int.TryParse(Console.ReadLine(), out plainGarlandLength);
            } while (!(result && plainGarlandLength > 0));
            do
            {
                Console.Write("Input length for colored garland: ");
                result = int.TryParse(Console.ReadLine(), out coloredGarlandLength);
            } while (!(result && coloredGarlandLength > 0));

            PlainGarland plainGarland = new PlainGarland(plainGarlandLength);
            ColoredGarland coloredGarland = new ColoredGarland(coloredGarlandLength);

            return Tuple.Create(plainGarland, coloredGarland);
        }

        private static void PrintWelcome()
        {
            Console.WriteLine("Two Garlands: Plain & Colored.");
            Console.WriteLine("==============================");
        }

        private static void PrintCommands()
        {
            Console.WriteLine("Available commands:");
            Console.WriteLine("0 - Print availiable commands");
            Console.WriteLine("1 - Create Garlands");
            Console.WriteLine("2 - Print garland's status");
            Console.WriteLine("3 - Exit");
            Console.WriteLine();
        }

        private static void PrintGarlandsStatus(Tuple<PlainGarland, ColoredGarland> garlands)
        {
            if (garlands == null)
            {
                Console.WriteLine("Garlands haven't created. Printing impossible.");
                return;
            }
            else
            {
                bool evenMinute = DateTime.Now.Minute % 2 == 0 ? true : false;
                garlands.Item1.PrintGarlandsStatus(evenMinute);
                Console.WriteLine();
                garlands.Item2.PrintGarlandsStatus(evenMinute);
            }

        }
    }
}
