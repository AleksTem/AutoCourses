using Bogus;

namespace HomeWork_08
{
    public class BaseConfig
    {
        public static int ShipmentsCount => new Faker().Random.Int(min: 2, max: 17);
        public static int OrdersCount => new Faker().Random.Int(min: 2, max: 17);
    }
}
