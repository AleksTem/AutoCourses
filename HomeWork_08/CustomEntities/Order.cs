using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HomeWork_08
{
    public class Order
    {
        private static int counterID = 1;

        public Order()
        {
        }

        public Order(bool generate)
        {
            if (generate)
            {
                ID = counterID++;
                int itemsCount = BaseConfig.ItemsCount;
                Goods = new List<OrderItem>(itemsCount);
                for (int i = 0; i < itemsCount; i++)
                {
                    Goods.Add(new OrderItem(true));
                }
            }
        }


        [JsonProperty("order_id")]
        public int ID { get; set; }

        [JsonProperty("goods")]
        public List<OrderItem> Goods { get; set; }

        public override string ToString()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append($"\n\tOrder:\n\tID:{ID}\n");
            Goods.ForEach(good => strBuilder.Append(good));
            decimal totalSum = Goods.Sum(x => x.SumPrice);
            strBuilder.Append($"\t\t\tTotal: {totalSum}");
            return strBuilder.ToString();
        }
    }
}
