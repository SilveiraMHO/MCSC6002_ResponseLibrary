namespace ResponseLibrary.Models.Requests.Identity
{
    public class ChangeUserStatusRequest
    {
        public string UserId { get; set; }
        public bool NewIsActiveStatus { get; set; }
    }
}
