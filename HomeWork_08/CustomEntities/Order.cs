using System.Collections.Generic;

namespace HomeWork_08
{
    public class Order
    {
        private static int counterID = 1;

        public Order()
        {
            ID = counterID++;
            Customer = new Customer();
            Goods = new List<OrderItem>(BaseConfig.OrdersCount);
            for (int i = 0; i < BaseConfig.OrdersCount - 1; i++)
            {
                Goods.Add(new OrderItem());
            }
        }



        public int ID { get; set; }
        public Customer Customer { get; set; }
        public List<OrderItem> Goods { get; set; }

        public override string ToString()
        {
            return $"\tOrder:\n\tID:{ID}\n\tCustomer: {Customer}";
        }
    }
}
