using Bogus;

namespace HomeWork_08
{
    public class Address
    {
        public string FullAddress { get => new Faker().Address.FullAddress(); }
    }
}
