using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace SimpleMultiTenancy.Web.Data
{
    public class DatabaseInitializer
    {
        private const string DefaultPassword = "Password1234-";

        private readonly ApplicationDbContext context;
        private readonly UserManager<User> userManager;
        private readonly RoleManager<Role> roleManager;

        public DatabaseInitializer(ApplicationDbContext context,
            UserManager<User> userManager,
            RoleManager<Role> roleManager)
        {
            this.context = context;
            this.userManager = userManager;
            this.roleManager = roleManager;
        }

        public async Task CreateDefaultData()
        {
            var teacher = await GetOrCreateRole(RoleNames.Teacher);
            var student = await GetOrCreateRole(RoleNames.Student);

            var berkeley = await GetOrCreateSchool("Berkeley");
            var uned = await GetOrCreateSchool("UNED");

            await GetOrCreateUser("bob@boss.com", DefaultPassword, (berkeley.Id, student.Id), (uned.Id, teacher.Id));
            await GetOrCreateUser("alice@berkeley.com", DefaultPassword, (berkeley.Id, student.Id));
        }

        private async Task<School> GetOrCreateSchool(string schoolName)
        {
            var school = await context.Schools.FirstOrDefaultAsync(x => x.Name == schoolName);
            if (school is null)
            {
                school = new School() { Name = schoolName };
                context.Schools.Add(school);
            }
            await context.SaveChangesAsync();
            return school;
        }

        public async Task GetOrCreateUser(string email, string password, params (int schoolId, string roleId)[] roles)
        {
            var user = await userManager.FindByNameAsync(email);
            if (user is null)
            {
                var userRoles = roles.Select(x => new UserRole()
                {
                    SchoolId = x.schoolId,
                    RoleId = x.roleId,
                }).ToList();

                user = new User()
                {
                    UserName = email,
                    Email = email,
                    EmailConfirmed = true,
                    UserRoles = userRoles
                };

                var result = await userManager.CreateAsync(user, password);
            }
        }

        private async Task<Role> GetOrCreateRole(string roleName)
        {
            var role = await roleManager.FindByNameAsync(roleName);
            if (role is null)
            {
                role = new Role() { Name = roleName };
                await roleManager.CreateAsync(role);
            }
            return role;
        }
    }
}