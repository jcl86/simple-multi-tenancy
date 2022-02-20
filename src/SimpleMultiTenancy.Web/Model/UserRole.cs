using Microsoft.AspNetCore.Identity;

namespace SimpleMultiTenancy.Web
{
    public class UserRole : IdentityUserRole<string>
    {
        public string CompanyId { get; set; }
        public Company Company { get; set; }

        //public User User { get; set; }
        //public Role Role { get; set; }
    }
}