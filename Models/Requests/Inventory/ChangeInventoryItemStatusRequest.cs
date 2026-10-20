namespace ResponseLibrary.Models.Requests.Inventory
{
    public class ChangeInventoryItemStatusRequest
    {
        public int Id { get; set; }
        public string Status { get; set; }
    }
}
