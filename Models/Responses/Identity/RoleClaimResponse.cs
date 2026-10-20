using ResponseLibrary.Models.Responses.Identity.ViewModelHelper;

namespace ResponseLibrary.Models.Responses.Identity
{
    public class RoleClaimResponse
    {
        public RoleResponse Role { get; set; }
        public List<RoleClaimViewModel> RoleClaims { get; set; }
    }
}
