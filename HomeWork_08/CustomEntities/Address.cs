using Bogus;

namespace HomeWork_08
{
    public class Address
    {
        public Address()
        {
            FullAddress = new Faker().Address.FullAddress();
        }
        public string FullAddress { get; set; }

        public override string ToString()
        {
            return FullAddress;
        }
    }
}
