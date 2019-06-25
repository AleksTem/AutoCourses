using Bogus;
using Newtonsoft.Json;
using System;

namespace HomeWork_08
{
    public class Customer
    {
        //public Customer()
        //{
        //}

        public Customer(bool generate)
        {
            if (generate)
            {
                Faker faker = new Faker();
                ID = faker.Random.Guid();
                FirstName = faker.Name.FirstName();
                LastName = faker.Name.LastName();
                Phone = faker.Phone.PhoneNumber();
            }
        }

        [JsonProperty("customer_id")]
        public Guid ID { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}, phone: {Phone}";
        }
    }
}
