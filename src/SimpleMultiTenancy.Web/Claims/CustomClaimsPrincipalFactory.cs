using Microsoft.AspNetCore.Identity;
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

            //user = await ReloadUserInludingNavigationProperty(user);

            ////Search for for the company ids the user has access
            //UserManager.role
            var roles = await UserManager.GetRolesAsync(user);

            foreach (var role in roles)
            {
                identity.AddClaim(new Claim("role", role));
            }

            //if (user.IsAsignedToLegacyLabnetContact())
            //{
            //    identity.AddClaim(new Claim(CustomClaims.LegacyContactId, user.IdContactoLabnet().ToString()));
            //}

            //if (user.IsAsignedToCustomer())
            //{
            //    identity.AddClaim(new Claim(CustomClaims.Customer, user.IdCliente().ToString()));
            //}

            return identity;
        }

        //private async Task<User> ReloadUserInludingNavigationProperty(User user)
        //{
        //    user = await UserManager.Users
        //        .Include(x => x.co)
        //        .SingleAsync(x => x.Id == user.Id);
        //    return user;
        //}
    }
}