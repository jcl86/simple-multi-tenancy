using Microsoft.AspNetCore.Identity;

namespace SimpleMultiTenancy.Web
{
    public class Role : IdentityRole
    {
        public ICollection<UserRole> UserRoles { get; set; }
    }
}