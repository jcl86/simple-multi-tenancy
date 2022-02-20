using Microsoft.AspNetCore.Authorization;
using SimpleMultiTenancy.Web.Data;

namespace SimpleMultiTenancy.Web
{
    public class IsTeacherHandler : AuthorizationHandler<HasRoleInSchoolRequirement>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, HasRoleInSchoolRequirement requirement)
        {
            if (context.User is null)
            {
                return Task.CompletedTask;
            }

            if (context.Resource is not HttpContext httpContext)
            {
                return Task.CompletedTask;
            }

            if (!httpContext.Request.RouteValues.TryGetValue("schoolId", out object value))
            {
                return Task.CompletedTask;
            }

            if (value is null || !int.TryParse(value.ToString(), out int schoolId))
            {
                return Task.CompletedTask;
            }

            if (context.User.HasRoleInSchool(schoolId, requirement.RoleName))
            {
                context.Succeed(requirement);
            }
            return Task.CompletedTask;
        }
    }
}