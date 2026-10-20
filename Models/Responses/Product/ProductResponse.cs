namespace ResponseLibrary.Models.Responses.Product
{
    public class ProductResponse
    {
        public int Id { get; set; }
        public int BrandId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public int ReOrderThreshold { get; set; }

        public BrandResponse Brand { get; set; }
        public List<ImageResponse> Images { get; set; } = [];
    }
}
