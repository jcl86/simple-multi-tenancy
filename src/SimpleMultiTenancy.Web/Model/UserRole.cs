using Microsoft.AspNetCore.Identity;

namespace SimpleMultiTenancy.Web
{
    public class UserRole : IdentityUserRole<string>
    {
        public User User { get; set; }
        public Role Role { get; set; }

        public int SchoolId { get; set; }
        public School School { get; set; }
    }
}