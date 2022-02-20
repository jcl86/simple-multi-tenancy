using Microsoft.AspNetCore.Authorization;

namespace SimpleMultiTenancy.Web
{
    public class IsStudentRequirement : IAuthorizationRequirement
    {
    }
}