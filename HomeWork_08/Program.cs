using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace HomeWork_08
{
    class Program
    {
        static void Main(string[] args)
        {
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
                        GenerateShipments();
                        //WriteShipmentsToFile();
                        break;
                    case "2":
                        //PrintShipments();

                        break;
                }
            } while (!choice.Equals("3"));

        }

        public static void GenerateShipments()
        {
            List<Shipment> shipments = new List<Shipment>(BaseConfig.ShipmentsCount);
            for (int i = 0; i < BaseConfig.ShipmentsCount - 1; i++)
            {
                shipments.Add(new Shipment());
            }
            string json = JsonConvert.SerializeObject(shipments, Formatting.Indented);
            Console.WriteLine(json);
        }

        private static void PrintCommands()
        {
            Console.WriteLine("Available commands:");
            Console.WriteLine("0 - Print availiable commands");
            Console.WriteLine("1 - Generate list of Shipments");
            Console.WriteLine("2 - Print Shipments ");
            Console.WriteLine("3 - Exit");
            Console.WriteLine();
        }
    }
}
