namespace ResponseLibrary.Models.Requests.Inventory
{
    public class CreateInventoryItemRequest
    {
        public int ProductId { get; set; }
        public string Barcode { get; set; }
        public string Status { get; set; }
    }
}
