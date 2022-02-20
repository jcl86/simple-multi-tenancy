using Microsoft.AspNetCore.Identity;

namespace SimpleMultiTenancy.Web
{
    public class UserRole : IdentityUserRole<string>
    {
        public string SchoolId { get; set; }
        public School School { get; set; }

        public User User { get; set; }
        public Role Role { get; set; }
    }
}