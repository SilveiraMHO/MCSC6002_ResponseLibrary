namespace ResponseLibrary.Models.Requests.Product.Events
{
    public class ProductCreatedEvent
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public int ReOrderThreshold { get; set; }
    }
}
