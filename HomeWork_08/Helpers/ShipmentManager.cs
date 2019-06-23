using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace HomeWork_08
{
    class ShipmentManager
    {
        List<Shipment> shipments;


        public void GenerateShipments()
        {
            shipments = new List<Shipment>(BaseConfig.ShipmentsCount);
            for (int i = 0; i < BaseConfig.ShipmentsCount - 1; i++)
            {
                shipments.Add(new Shipment());
            }
            string json = JsonConvert.SerializeObject(shipments, Formatting.Indented);
        }

        public void PrintShipments(bool withOrders = false)
        {
            if (shipments == null)
            {
                throw new ArgumentNullException("Shipments List not defined");
            }
            else if (shipments.Count == 0)
            {
                throw new Exception("Shipments list is empty");
            }
            else
            {
                shipments.ForEach(shipment => Console.WriteLine(shipment.ToString(withOrders)));

            }
        }

        public void WriteShipmentsToFile()
        {
            FileHelper.WriteShipmentsToJSONFile(shipments);
        }

        public bool LoadShipmentsFromExistingFile()
        {
            return FileHelper.LoadShipmentsFromJSONFile(out shipments);
        }
    }
}
