namespace HomeWork_08
{
    //[Serializable]
    public class Shipment
    {
        public string ID { get; set; }
        public string Address { get; set; }
        public Order Order { get; set; }
    }
}
