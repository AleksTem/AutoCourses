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



        public int ID { get; private set; }
        public Customer Customer { get; private set; }
        public List<OrderItem> Goods { get; private set; }
    }
}
