using Microsoft.AspNet.Identity.EntityFramework;

namespace keuzewijzer_hbo_deeltijd_ict_API.ViewModels
{
    public class AuthenticationResponse
    {
        public int Status { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Roles { get; set; }
        public AuthenticationResponse(int status, string userId, string userName, string email, string roles)
        {
            Status = status;
            UserId = userId;
            UserName = userName;
            Email = email;
            Roles = roles;
        }
    }
}
