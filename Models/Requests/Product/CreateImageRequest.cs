namespace ResponseLibrary.Models.Requests.Product
{
    public class CreateImageRequest
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Data { get; set; }
    }
}
