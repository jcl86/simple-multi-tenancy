using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SimpleMultiTenancy.Web.Data
{
    public class ApplicationDbContext : IdentityDbContext<User, 
        Role, 
        string, 
        IdentityUserClaim<string>, 
        UserRole, 
        IdentityUserLogin<string>,
        IdentityRoleClaim<string>, 
        IdentityUserToken<string>>
    {
        public DbSet<School> Schools { get; set; }
        public DbSet<Grade> Grades { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {


        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);

            ConvertAllNamesToUppercase(builder);

            builder.Entity<UserRole>().HasOne(u => u.School)
                .WithMany(c => c.UserRoles)
                .HasForeignKey(u => u.SchoolId)
                .OnDelete(DeleteBehavior.Cascade);

            ExtendUserRoles(builder);
        }

        private static void ConvertAllNamesToUppercase(ModelBuilder builder)
        {
            builder.Model.GetEntityTypes().ToList().ForEach(entityType =>
            {
                if (entityType is IReadOnlyEntityType table)
                {
                    entityType.SetTableName(table.GetTableName().ToUpper());
                }

                foreach (var property in entityType.GetProperties())
                {
                    property.SetColumnName(property.GetColumnBaseName().ToUpper());
                }
            });
        }

        private static void ExtendUserRoles(ModelBuilder builder)
        {
            builder.Entity<UserRole>(entity =>
            {
                var index = entity.HasKey(userRole => new { userRole.UserId, userRole.RoleId }).Metadata;
                entity.Metadata.RemoveKey(index.Properties);

                entity.HasKey(a => new { a.UserId, a.RoleId, a.SchoolId });

                entity.HasOne(ur => ur.Role)
                    .WithMany(r => r.UserRoles)
                    .HasForeignKey(ur => ur.RoleId)
                    .IsRequired();

                entity.HasOne(ur => ur.User)
                    .WithMany(r => r.UserRoles)
                    .HasForeignKey(ur => ur.UserId)
                    .IsRequired();
            });
        }
    }
}