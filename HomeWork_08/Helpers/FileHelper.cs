using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace HomeWork_08
{
    class FileHelper
    {
        public static void WriteShipmentsToJSONFile(List<Shipment> shipments, string shipmentsFilePath = null)
        {
            if (shipments == null)
            {
                throw new Exception("Shipments list not initialized");
            }

            string filePath = shipmentsFilePath ?? BaseConfig.ShipmentsFile;

            if (!File.Exists(filePath))
            {
                File.Create(filePath);
            }

            using (StreamWriter file = new StreamWriter(filePath))
            {
                new JsonSerializer().Serialize(file, shipments);
            }
        }

        public static bool LoadShipmentsFromJSONFile(out List<Shipment> shipments, string shipmentsFilePath = null)
        {
            string filePath = shipmentsFilePath ?? BaseConfig.ShipmentsFile;
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException($"Not found file: {filePath}");
            }


            using (StreamReader file = File.OpenText(filePath))
            {
                JsonSerializer serializer = new JsonSerializer();
                shipments = (List<Shipment>)serializer.Deserialize(file, typeof(List<Shipment>));

                //shipments = JsonConvert.DeserializeObject<List<Shipment>>(string, );

            }
            return true;
        }
    }
}
