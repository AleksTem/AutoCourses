using Newtonsoft.Json;
using Newtonsoft.Json.Schema;
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

            // load JSchema directly from a file
            using (StreamReader file = File.OpenText(BaseConfig.JsonSchemaFile))
            using (JsonTextReader reader = new JsonTextReader(file))
            {
                JSchema schema = JSchema.Load(reader);
            }


            //List<Shipment> shipments;
            using (StreamReader file = File.OpenText(filePath))
            {
                JsonSerializer serializer = new JsonSerializer();
                shipments = (List<Shipment>)serializer.Deserialize(file, typeof(List<Shipment>));
                serializer.
            }

            shipments.ForEach(x.)

            return true;
        }
    }
}
