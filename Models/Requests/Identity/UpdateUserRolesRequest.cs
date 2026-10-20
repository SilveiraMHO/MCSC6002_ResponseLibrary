using ResponseLibrary.Models.Responses.Identity.ViewModelHelper;

namespace ResponseLibrary.Models.Requests.Identity
{
    public class UpdateUserRolesRequest
    {
        public string UserId { get; set; }
        public List<UserRoleViewModel> Roles { get; set; }
    }
}
