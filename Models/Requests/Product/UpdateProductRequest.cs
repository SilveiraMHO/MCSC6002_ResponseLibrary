namespace ResponseLibrary.Models.Requests.Product
{
    public class UpdateProductRequest
    {
        public int Id { get; set; }
        public int BrandId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public int ReOrderThreshold { get; set; }
    }
}
