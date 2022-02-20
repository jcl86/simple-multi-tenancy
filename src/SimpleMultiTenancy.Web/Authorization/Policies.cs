using Microsoft.AspNetCore.Authorization;
using SimpleMultiTenancy.Web.Data;

namespace SimpleMultiTenancy.Web
{
    public static class Policies
    {
        public const string IsTeacher = nameof(IsTeacher);
        public const string IsStudent = nameof(IsStudent);

        public static void Configure(AuthorizationOptions options)
        {
            options.InvokeHandlersAfterFailure = true;

            options.AddPolicy(IsTeacher, builder => builder.AddRequirements(new HasRoleInSchoolRequirement(RoleNames.Teacher)));
            options.AddPolicy(IsStudent, builder => builder.AddRequirements(new HasRoleInSchoolRequirement(RoleNames.Student)));
        }
    }
}