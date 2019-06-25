using Bogus;
using System;
using System.IO;

namespace HomeWork_08
{
    public class BaseConfig
    {
        public static int ShipmentsCount => new Faker().Random.Int(min: 1, max: 5);

        public static int OrdersCount => new Faker().Random.Int(min: 1, max: 3);
        public static int ItemsCount => new Faker().Random.Int(min: 2, max: 6);

        static private string _fileName = "Shipments.json";
        static internal string ShipmentsFile => Path.Combine(AppContext.BaseDirectory, @"..\..\Data\", _fileName);
        //static internal string JsonSchemaFile => Path.Combine(AppContext.BaseDirectory, @"..\..\Data\", "JSONSchema.json");
    }
}
