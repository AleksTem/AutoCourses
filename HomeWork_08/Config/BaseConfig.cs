using Bogus;
using System;
using System.IO;

namespace HomeWork_08
{
    public class BaseConfig
    {
        public static int ShipmentsCount => new Faker().Random.Int(min: 2, max: 17);
        public static int OrdersCount => new Faker().Random.Int(min: 2, max: 17);

        static private string _fileName = "Shipments.json";
        static internal string ShipmentsFile => Path.Combine(AppContext.BaseDirectory, @"..\..\Data\", _fileName);
    }
}
