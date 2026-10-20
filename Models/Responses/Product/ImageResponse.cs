namespace ResponseLibrary.Models.Responses.Product
{
    public class ImageResponse
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Data { get; set; }

        public ProductResponse Product { get; set; }
    }
}
