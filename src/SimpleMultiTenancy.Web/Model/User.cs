using Microsoft.AspNetCore.Identity;

namespace SimpleMultiTenancy.Web
{
    public class User : IdentityUser
    {
        public ICollection<UserRole> UserRoles { get; set; }
        public ICollection<Grade> Grades { get; set; }

        public IEnumerable<ViewModels.RoleInCompany> GetCompanyRoles() => UserRoles.Select(x =>
            new ViewModels.RoleInCompany()
            {
                Company = new ViewModels.School()
                {
                    Id = x.School.Id,
                    Name = x.School.Name
                },
                Name = x.Role.Name
            }).ToList();

    }
}