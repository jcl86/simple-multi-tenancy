using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.Security.Claims;

namespace SimpleMultiTenancy.Web.Data
{
    public class CustomClaimsPrincipalFactory : UserClaimsPrincipalFactory<User, Role>
    {
        public CustomClaimsPrincipalFactory(UserManager<User> userManager,
            RoleManager<Role> roleManager,
            IOptions<IdentityOptions> optionsAccessor) :
            base(userManager, roleManager, optionsAccessor)
        { }

        protected override async Task<ClaimsIdentity> GenerateClaimsAsync(User user)
        {
            var identity = await base.GenerateClaimsAsync(user);

            user = await ReloadUserInludingNavigationProperty(user);

            foreach (var roleInSchool in user.GetCompanyRoles())
            {
                identity.AddClaim(new Claim(CustomClaims.RoleInSchool, roleInSchool.ToString()));
            }

            return identity;
        }

        private async Task<User> ReloadUserInludingNavigationProperty(User user)
        {
            user = await UserManager.Users
                .Include(x => x.UserRoles).ThenInclude(x => x.Role)
                .Include(x => x.UserRoles).ThenInclude(x => x.School)
                .SingleAsync(x => x.Id == user.Id);
            return user;
        }
    }
}