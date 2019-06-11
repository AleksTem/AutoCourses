using System.Collections.Generic;

namespace HomeWork_08
{
    public class Order
    {
        public int ID { get; set; }
        public Customer Customer { get; set; }
        public List<OrderItem> Goods { get; set; }
    }
}
