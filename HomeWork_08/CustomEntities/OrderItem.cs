using Bogus;

namespace HomeWork_08
{
    public class OrderItem
    {
        public OrderItem()
        {
            Faker faker = new Faker();
            Product = faker.Commerce.Product();
            Amount = faker.Random.Number(max: 100);
        }

        public string Product { get; set; }
        public int Amount { get; set; }
    }
}
