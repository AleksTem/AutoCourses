using Bogus;
using Newtonsoft.Json;

namespace HomeWork_08
{
    public class Address
    {
        //public Address()
        //{
        //}

        public Address(bool generate)
        {
            if (generate)
            {
                Faker faker = new Faker();
                Country = faker.Address.Country();
                ZipCode = faker.Address.ZipCode();
                Street = faker.Address.StreetAddress(useFullAddress: true);
            }
        }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("zip")]
        public string ZipCode { get; set; }

        [JsonProperty("street")]
        public string Street { get; set; }

        public override string ToString()
        {
            return $"{Country} {ZipCode} {Street}";
        }
    }
}
