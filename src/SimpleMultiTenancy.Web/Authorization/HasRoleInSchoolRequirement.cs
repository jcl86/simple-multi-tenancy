using Microsoft.AspNetCore.Authorization;

namespace SimpleMultiTenancy.Web
{
    public class HasRoleInSchoolRequirement : IAuthorizationRequirement
    {
        public HasRoleInSchoolRequirement(string roleName)
        {
            RoleName = roleName;
        }

        public string RoleName { get; }
    }
}