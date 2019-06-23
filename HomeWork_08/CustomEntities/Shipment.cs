using Bogus;

namespace HomeWork_08
{
    public class Shipment
    {
        public Shipment()
        {
            Faker faker = new Faker();
            ID = faker.Random.AlphaNumeric(10);
            Address = new Address();
            Order = new Order();
        }

        public string ID { get; set; }
        public Address Address { get; set; }
        public Order Order { get; set; }

        public new string ToString(bool printWithOrders = false)
        {
            return
                $"\nShipment:\nID: {ID}\n Address: {Address} {(printWithOrders ? $"\n{Order}" : "")}";
        }

    }
}
