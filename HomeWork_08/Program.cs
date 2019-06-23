using System;

namespace HomeWork_08
{
    class Program
    {
        static void Main(string[] args)
        {
            ShipmentManager instance = new ShipmentManager();
            Console.WriteLine("Task 8: JSON/XML Serialization/Deserialization");
            PrintCommands();
            string choice = default(string);
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
                        instance.GenerateShipments();
                        instance.WriteShipmentsToFile();
                        break;
                    case "2":
                        instance.LoadShipmentsFromExistingFile();
                        break;
                    case "3":
                        instance.PrintShipments(IsPrintWithOrder());
                        break;
                }
            } while (!choice.Equals("4"));

        }

        private static void PrintCommands()
        {
            Console.WriteLine("Available commands:");
            Console.WriteLine("0 - Print availiable commands");
            Console.WriteLine("1 - Generate and write to file list of Shipments");
            Console.WriteLine("2 - Load list of Shipments from existing file");
            Console.WriteLine("3 - Print Shipments ");
            Console.WriteLine("4 - Exit");
            Console.WriteLine();
        }
        private static bool IsPrintWithOrder()
        {
            Console.Write("Print with Orders? (Y/N): ");
            string userInput = Console.ReadLine();
            if (userInput.Equals("y") || userInput.Equals("Y"))
            {
                return true;
            }
            return false;
        }
    }
}
