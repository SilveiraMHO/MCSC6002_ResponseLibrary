namespace ResponseLibrary.Models.Responses.Inventory
{
    public class InventoryItemResponse
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string Barcode { get; set; }
        public string Status { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
