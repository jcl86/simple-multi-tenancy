using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SimpleMultiTenancy.Web.Data.Migrations
{
    public partial class CreateSampleData : Migration
    {
        private static Company BrokenMoon => new Company() { Id = "1", Name = "Broken moon SA" };
        private static Company Inversia => new Company() { Id = "2", Name = "Inversia INC" };

        private static Role Admin => new Role() { Id = "6838aa92-9240-4e1c-aae9-1ae842db8953", Name = "Administrator" };
        private static Role Parguelas => new Role() { Id = "c542d0d9-3138-45e4-afef-853888a6d73c", Name = "Parguelas" };

        private static (string id, string user) Mike => ("811eaf89-89cb-46a7-987f-1a5c1ec5e88c", "mike@boss.com"); // Password: Password01-
        private static (string id, string user) Hellen => ("2774a2f3-696d-4531-99cb-34bfaeb75282", "hellen@gmail.com"); // Password: Password01-

        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql($"insert into COMPANIES(id, name) values('{BrokenMoon.Id}', '{BrokenMoon.Name}')");
            migrationBuilder.Sql($"insert into COMPANIES(id, name) values('{Inversia.Id}', '{Inversia.Name}')");

            migrationBuilder.Sql($"insert into ASPNETROLES(id, name, NORMALIZEDNAME, CONCURRENCYSTAMP) values('{Admin.Id}', '{Admin.Name}', 'ADMINISTRATOR', 'S47IV2VXPVS6LHHGXL5HELFYCAQ6CHF2')");
            migrationBuilder.Sql($"insert into ASPNETROLES(id, name, NORMALIZEDNAME, CONCURRENCYSTAMP) values('{Parguelas.Id}', '{Parguelas.Name}', 'PARGUELAS', 'S47IV2VXPVS6LHHGXL5HELFYCAQ6CHF2')");

            migrationBuilder.Sql($"insert into ASPNETUSERS(id, USERNAME, NORMALIZEDUSERNAME, EMAIL, NORMALIZEDEMAIL, PASSWORDHASH, SECURITYSTAMP, CONCURRENCYSTAMP, ACCESSFAILEDCOUNT, " +
                 $"EMAILCONFIRMED, PHONENUMBERCONFIRMED, TWOFACTORENABLED, LOCKOUTENABLED) values('{Mike.id}', '{Mike.user}', '{Mike.user.ToUpper()}', '{Mike.user}', '{Mike.user.ToUpper()}'," +
                $"'AQAAAAEAACcQAAAAEL/8CJ5liJ/0bwiKmUewKjdoSxcb8FAVMuglnGs0q6+EUKpGgNBKSaBB59i5LBzDNw==', " +
                $"'S47IV2VXPVS6LHHGXL5HELFYCAQ6CHF2'," +
                $"'728042df-b48a-45e0-a4b8-c783a79b2cc0', 0, 1, 0, 0, 1)");

            migrationBuilder.Sql($"insert into ASPNETUSERS(id, USERNAME, NORMALIZEDUSERNAME, EMAIL, NORMALIZEDEMAIL, PASSWORDHASH, SECURITYSTAMP, CONCURRENCYSTAMP, ACCESSFAILEDCOUNT, " +
                 $"EMAILCONFIRMED, PHONENUMBERCONFIRMED, TWOFACTORENABLED, LOCKOUTENABLED) values('{Hellen.id}', '{Hellen.user}', '{Hellen.user.ToUpper()}', '{Hellen.user}', '{Hellen.user.ToUpper()}'," +
                 $"'AQAAAAEAACcQAAAAEL/8CJ5liJ/0bwiKmUewKjdoSxcb8FAVMuglnGs0q6+EUKpGgNBKSaBB59i5LBzDNw==', " +
                 $"'S47IV2VXPVS6LHHGXL5HELFYCAQ6CHF2'," +
                 $"'728042df-b48a-45e0-a4b8-c783a79b2cc0', 0, 1, 0, 0, 1)");


            migrationBuilder.Sql($"insert into ASPNETUSERROLES(USERID, ROLEID, COMPANYID) values('{Mike.id}', '{Admin.Id}', {BrokenMoon.Id})");
            migrationBuilder.Sql($"insert into ASPNETUSERROLES(USERID, ROLEID, COMPANYID) values('{Mike.id}', '{Admin.Id}', {Inversia.Id})");
            migrationBuilder.Sql($"insert into ASPNETUSERROLES(USERID, ROLEID, COMPANYID) values('{Hellen.id}', '{Admin.Id}', {BrokenMoon.Id})");
            migrationBuilder.Sql($"insert into ASPNETUSERROLES(USERID, ROLEID, COMPANYID) values('{Hellen.id}', '{Parguelas.Id}', {Inversia.Id})");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql($"delete COMPANIES");
            migrationBuilder.Sql($"delete ASPNETROLES");
            migrationBuilder.Sql($"delete ASPNETUSERS");
            migrationBuilder.Sql($"delete ASPNETUSERROLES");
        }
    }
}
