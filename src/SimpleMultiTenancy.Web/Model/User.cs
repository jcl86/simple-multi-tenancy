using Microsoft.AspNetCore.Identity;

namespace SimpleMultiTenancy.Web
{
    public class User : IdentityUser
    {
        //Fill for customize the user entity. If there is no need for it, just remove this class and use everywhere IdentityUser

        //public ICollection<UserRole> UserRoles { get; set; }
    }
}