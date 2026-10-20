using ResponseLibrary.Models.Responses.Identity.ViewModelHelper;

namespace ResponseLibrary.Models.Requests.Identity
{
    public class UpdateRoleClaimsRequest
    {
        public string RoleId { get; set; }
        public List<RoleClaimViewModel> RoleClaims { get; set; }
    }
}
