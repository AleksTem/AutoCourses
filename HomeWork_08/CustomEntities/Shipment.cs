using Bogus;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_08
{
    public class Shipment
    {
        public Shipment()
        {
        }

        public Shipment(bool genetrate)
        {
            if (genetrate)
            {
                int ordersCount = BaseConfig.OrdersCount;
                Faker faker = new Faker();
                ID = faker.Random.AlphaNumeric(10);
                Customer = new Customer(true);
                Address = new Address(true);

                OrdersList = new List<Order>(ordersCount);
                for (int i = 0; i < ordersCount; i++)
                {
                    OrdersList.Add(new Order(true));
                }
            }
        }

        [JsonProperty("shipment_id")]
        public string ID { get; set; }

        [JsonProperty("address")]
        public Address Address { get; set; }

        [JsonProperty("customer")]
        public Customer Customer { get; set; }

        [JsonProperty("order_list")]
        public List<Order> OrdersList { get; set; }

        public string ToString(bool printWithOrders = false)
        {
            string baseStr = $"\nShipment:\nID: {ID}\n Customer: {Customer}\nAddress: {Address}";
            if (printWithOrders)
            {
                StringBuilder strBuilder = new StringBuilder();
                strBuilder.Append(baseStr);
                OrdersList.ForEach(order => strBuilder.Append(order));
                return strBuilder.ToString();
            }
            else
            {
                return baseStr;
            }
        }
    }
}
