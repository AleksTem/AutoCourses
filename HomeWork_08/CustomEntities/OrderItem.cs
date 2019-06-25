using Bogus;
using Newtonsoft.Json;
using System;

namespace HomeWork_08
{
    public class OrderItem
    {
        public OrderItem()
        {
        }

        public OrderItem(bool generate)
        {
            if (generate)
            {
                Faker faker = new Faker();
                Product = faker.Commerce.Product();
                Amount = faker.Random.Number(max: 100);
                Price = Math.Round(faker.Random.Decimal(min: 0, 01), 2);
            }
        }

        [JsonProperty("product")]
        public string Product { get; set; }

        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("price")]
        public decimal Price { get; set; }

        [JsonProperty("sum_price")]
        public decimal SumPrice => Price * Amount;

        public override string ToString()
        {
            return $"\t\t{Product} {Amount} pcs. * {Price} = {SumPrice}\n";
        }
    }
}
