using Bogus;
using System;

namespace HomeWork_08
{
    public class Customer
    {
        public Customer()
        {
            var faker = new Faker();
            ID = faker.Random.Guid();
            Name = faker.Name.FullName();
        }

        public Guid ID { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
