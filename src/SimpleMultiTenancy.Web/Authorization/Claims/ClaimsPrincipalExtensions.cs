using System.Security.Claims;

namespace SimpleMultiTenancy.Web.Data
{
    public static class ClaimsPrincipalExtensions
    {
        public static bool HasRoleInSchool(this ClaimsPrincipal principal, int schoolId, string roleName)
        {
            string value = principal.FindFirst(CustomClaims.RoleInSchool)?.Value;

            if (value is null)
            {
                return false;
            }

            var splitted = value.Split(":");
            if (splitted.Count() != 2) return false;
            if (!int.TryParse(splitted[0], out int claimSchoolId))
            {
                return false;
            }

            return claimSchoolId == schoolId && splitted[0] == roleName;
        }
    }
}