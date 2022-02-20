using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SimpleMultiTenancy.Web.Data.Migrations
{
    public partial class CustomizeIdentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                table: "AspNetRoleClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserTokens",
                table: "AspNetUserTokens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUsers",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "UserNameIndex",
                table: "AspNetUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserRoles",
                table: "AspNetUserRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserLogins",
                table: "AspNetUserLogins");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserClaims",
                table: "AspNetUserClaims");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetRoles",
                table: "AspNetRoles");

            migrationBuilder.DropIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetRoleClaims",
                table: "AspNetRoleClaims");

            migrationBuilder.RenameTable(
                name: "AspNetUserTokens",
                newName: "ASPNETUSERTOKENS");

            migrationBuilder.RenameTable(
                name: "AspNetUsers",
                newName: "ASPNETUSERS");

            migrationBuilder.RenameTable(
                name: "AspNetUserRoles",
                newName: "ASPNETUSERROLES");

            migrationBuilder.RenameTable(
                name: "AspNetUserLogins",
                newName: "ASPNETUSERLOGINS");

            migrationBuilder.RenameTable(
                name: "AspNetUserClaims",
                newName: "ASPNETUSERCLAIMS");

            migrationBuilder.RenameTable(
                name: "AspNetRoles",
                newName: "ASPNETROLES");

            migrationBuilder.RenameTable(
                name: "AspNetRoleClaims",
                newName: "ASPNETROLECLAIMS");

            migrationBuilder.RenameColumn(
                name: "Value",
                table: "ASPNETUSERTOKENS",
                newName: "VALUE");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "ASPNETUSERTOKENS",
                newName: "NAME");

            migrationBuilder.RenameColumn(
                name: "LoginProvider",
                table: "ASPNETUSERTOKENS",
                newName: "LOGINPROVIDER");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "ASPNETUSERTOKENS",
                newName: "USERID");

            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "ASPNETUSERS",
                newName: "USERNAME");

            migrationBuilder.RenameColumn(
                name: "TwoFactorEnabled",
                table: "ASPNETUSERS",
                newName: "TWOFACTORENABLED");

            migrationBuilder.RenameColumn(
                name: "SecurityStamp",
                table: "ASPNETUSERS",
                newName: "SECURITYSTAMP");

            migrationBuilder.RenameColumn(
                name: "PhoneNumberConfirmed",
                table: "ASPNETUSERS",
                newName: "PHONENUMBERCONFIRMED");

            migrationBuilder.RenameColumn(
                name: "PhoneNumber",
                table: "ASPNETUSERS",
                newName: "PHONENUMBER");

            migrationBuilder.RenameColumn(
                name: "PasswordHash",
                table: "ASPNETUSERS",
                newName: "PASSWORDHASH");

            migrationBuilder.RenameColumn(
                name: "NormalizedUserName",
                table: "ASPNETUSERS",
                newName: "NORMALIZEDUSERNAME");

            migrationBuilder.RenameColumn(
                name: "NormalizedEmail",
                table: "ASPNETUSERS",
                newName: "NORMALIZEDEMAIL");

            migrationBuilder.RenameColumn(
                name: "LockoutEnd",
                table: "ASPNETUSERS",
                newName: "LOCKOUTEND");

            migrationBuilder.RenameColumn(
                name: "LockoutEnabled",
                table: "ASPNETUSERS",
                newName: "LOCKOUTENABLED");

            migrationBuilder.RenameColumn(
                name: "EmailConfirmed",
                table: "ASPNETUSERS",
                newName: "EMAILCONFIRMED");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "ASPNETUSERS",
                newName: "EMAIL");

            migrationBuilder.RenameColumn(
                name: "ConcurrencyStamp",
                table: "ASPNETUSERS",
                newName: "CONCURRENCYSTAMP");

            migrationBuilder.RenameColumn(
                name: "AccessFailedCount",
                table: "ASPNETUSERS",
                newName: "ACCESSFAILEDCOUNT");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "ASPNETUSERS",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "RoleId",
                table: "ASPNETUSERROLES",
                newName: "ROLEID");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "ASPNETUSERROLES",
                newName: "USERID");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "ASPNETUSERROLES",
                newName: "IX_ASPNETUSERROLES_ROLEID");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "ASPNETUSERLOGINS",
                newName: "USERID");

            migrationBuilder.RenameColumn(
                name: "ProviderDisplayName",
                table: "ASPNETUSERLOGINS",
                newName: "PROVIDERDISPLAYNAME");

            migrationBuilder.RenameColumn(
                name: "ProviderKey",
                table: "ASPNETUSERLOGINS",
                newName: "PROVIDERKEY");

            migrationBuilder.RenameColumn(
                name: "LoginProvider",
                table: "ASPNETUSERLOGINS",
                newName: "LOGINPROVIDER");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "ASPNETUSERLOGINS",
                newName: "IX_ASPNETUSERLOGINS_USERID");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "ASPNETUSERCLAIMS",
                newName: "USERID");

            migrationBuilder.RenameColumn(
                name: "ClaimValue",
                table: "ASPNETUSERCLAIMS",
                newName: "CLAIMVALUE");

            migrationBuilder.RenameColumn(
                name: "ClaimType",
                table: "ASPNETUSERCLAIMS",
                newName: "CLAIMTYPE");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "ASPNETUSERCLAIMS",
                newName: "ID");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "ASPNETUSERCLAIMS",
                newName: "IX_ASPNETUSERCLAIMS_USERID");

            migrationBuilder.RenameColumn(
                name: "NormalizedName",
                table: "ASPNETROLES",
                newName: "NORMALIZEDNAME");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "ASPNETROLES",
                newName: "NAME");

            migrationBuilder.RenameColumn(
                name: "ConcurrencyStamp",
                table: "ASPNETROLES",
                newName: "CONCURRENCYSTAMP");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "ASPNETROLES",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "RoleId",
                table: "ASPNETROLECLAIMS",
                newName: "ROLEID");

            migrationBuilder.RenameColumn(
                name: "ClaimValue",
                table: "ASPNETROLECLAIMS",
                newName: "CLAIMVALUE");

            migrationBuilder.RenameColumn(
                name: "ClaimType",
                table: "ASPNETROLECLAIMS",
                newName: "CLAIMTYPE");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "ASPNETROLECLAIMS",
                newName: "ID");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "ASPNETROLECLAIMS",
                newName: "IX_ASPNETROLECLAIMS_ROLEID");

            migrationBuilder.AlterColumn<string>(
                name: "NAME",
                table: "ASPNETUSERTOKENS",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LOGINPROVIDER",
                table: "ASPNETUSERTOKENS",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AddColumn<int>(
                name: "SCHOOLID",
                table: "ASPNETUSERROLES",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "PROVIDERKEY",
                table: "ASPNETUSERLOGINS",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LOGINPROVIDER",
                table: "ASPNETUSERLOGINS",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ASPNETUSERTOKENS",
                table: "ASPNETUSERTOKENS",
                columns: new[] { "USERID", "LOGINPROVIDER", "NAME" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_ASPNETUSERS",
                table: "ASPNETUSERS",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ASPNETUSERROLES",
                table: "ASPNETUSERROLES",
                columns: new[] { "USERID", "ROLEID", "SCHOOLID" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_ASPNETUSERLOGINS",
                table: "ASPNETUSERLOGINS",
                columns: new[] { "LOGINPROVIDER", "PROVIDERKEY" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_ASPNETUSERCLAIMS",
                table: "ASPNETUSERCLAIMS",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ASPNETROLES",
                table: "ASPNETROLES",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ASPNETROLECLAIMS",
                table: "ASPNETROLECLAIMS",
                column: "ID");

            migrationBuilder.CreateTable(
                name: "SCHOOLS",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NAME = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SCHOOLS", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "ASPNETUSERS",
                column: "NORMALIZEDUSERNAME",
                unique: true,
                filter: "[NORMALIZEDUSERNAME] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ASPNETUSERROLES_SCHOOLID",
                table: "ASPNETUSERROLES",
                column: "SCHOOLID");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "ASPNETROLES",
                column: "NORMALIZEDNAME",
                unique: true,
                filter: "[NORMALIZEDNAME] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_ASPNETROLECLAIMS_ASPNETROLES_ROLEID",
                table: "ASPNETROLECLAIMS",
                column: "ROLEID",
                principalTable: "ASPNETROLES",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ASPNETUSERCLAIMS_ASPNETUSERS_USERID",
                table: "ASPNETUSERCLAIMS",
                column: "USERID",
                principalTable: "ASPNETUSERS",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ASPNETUSERLOGINS_ASPNETUSERS_USERID",
                table: "ASPNETUSERLOGINS",
                column: "USERID",
                principalTable: "ASPNETUSERS",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ASPNETUSERROLES_ASPNETROLES_ROLEID",
                table: "ASPNETUSERROLES",
                column: "ROLEID",
                principalTable: "ASPNETROLES",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ASPNETUSERROLES_ASPNETUSERS_USERID",
                table: "ASPNETUSERROLES",
                column: "USERID",
                principalTable: "ASPNETUSERS",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ASPNETUSERROLES_SCHOOLS_SCHOOLID",
                table: "ASPNETUSERROLES",
                column: "SCHOOLID",
                principalTable: "SCHOOLS",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ASPNETUSERTOKENS_ASPNETUSERS_USERID",
                table: "ASPNETUSERTOKENS",
                column: "USERID",
                principalTable: "ASPNETUSERS",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ASPNETROLECLAIMS_ASPNETROLES_ROLEID",
                table: "ASPNETROLECLAIMS");

            migrationBuilder.DropForeignKey(
                name: "FK_ASPNETUSERCLAIMS_ASPNETUSERS_USERID",
                table: "ASPNETUSERCLAIMS");

            migrationBuilder.DropForeignKey(
                name: "FK_ASPNETUSERLOGINS_ASPNETUSERS_USERID",
                table: "ASPNETUSERLOGINS");

            migrationBuilder.DropForeignKey(
                name: "FK_ASPNETUSERROLES_ASPNETROLES_ROLEID",
                table: "ASPNETUSERROLES");

            migrationBuilder.DropForeignKey(
                name: "FK_ASPNETUSERROLES_ASPNETUSERS_USERID",
                table: "ASPNETUSERROLES");

            migrationBuilder.DropForeignKey(
                name: "FK_ASPNETUSERROLES_SCHOOLS_SCHOOLID",
                table: "ASPNETUSERROLES");

            migrationBuilder.DropForeignKey(
                name: "FK_ASPNETUSERTOKENS_ASPNETUSERS_USERID",
                table: "ASPNETUSERTOKENS");

            migrationBuilder.DropTable(
                name: "SCHOOLS");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ASPNETUSERTOKENS",
                table: "ASPNETUSERTOKENS");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ASPNETUSERS",
                table: "ASPNETUSERS");

            migrationBuilder.DropIndex(
                name: "UserNameIndex",
                table: "ASPNETUSERS");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ASPNETUSERROLES",
                table: "ASPNETUSERROLES");

            migrationBuilder.DropIndex(
                name: "IX_ASPNETUSERROLES_SCHOOLID",
                table: "ASPNETUSERROLES");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ASPNETUSERLOGINS",
                table: "ASPNETUSERLOGINS");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ASPNETUSERCLAIMS",
                table: "ASPNETUSERCLAIMS");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ASPNETROLES",
                table: "ASPNETROLES");

            migrationBuilder.DropIndex(
                name: "RoleNameIndex",
                table: "ASPNETROLES");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ASPNETROLECLAIMS",
                table: "ASPNETROLECLAIMS");

            migrationBuilder.DropColumn(
                name: "SCHOOLID",
                table: "ASPNETUSERROLES");

            migrationBuilder.RenameTable(
                name: "ASPNETUSERTOKENS",
                newName: "AspNetUserTokens");

            migrationBuilder.RenameTable(
                name: "ASPNETUSERS",
                newName: "AspNetUsers");

            migrationBuilder.RenameTable(
                name: "ASPNETUSERROLES",
                newName: "AspNetUserRoles");

            migrationBuilder.RenameTable(
                name: "ASPNETUSERLOGINS",
                newName: "AspNetUserLogins");

            migrationBuilder.RenameTable(
                name: "ASPNETUSERCLAIMS",
                newName: "AspNetUserClaims");

            migrationBuilder.RenameTable(
                name: "ASPNETROLES",
                newName: "AspNetRoles");

            migrationBuilder.RenameTable(
                name: "ASPNETROLECLAIMS",
                newName: "AspNetRoleClaims");

            migrationBuilder.RenameColumn(
                name: "VALUE",
                table: "AspNetUserTokens",
                newName: "Value");

            migrationBuilder.RenameColumn(
                name: "NAME",
                table: "AspNetUserTokens",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "LOGINPROVIDER",
                table: "AspNetUserTokens",
                newName: "LoginProvider");

            migrationBuilder.RenameColumn(
                name: "USERID",
                table: "AspNetUserTokens",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "USERNAME",
                table: "AspNetUsers",
                newName: "UserName");

            migrationBuilder.RenameColumn(
                name: "TWOFACTORENABLED",
                table: "AspNetUsers",
                newName: "TwoFactorEnabled");

            migrationBuilder.RenameColumn(
                name: "SECURITYSTAMP",
                table: "AspNetUsers",
                newName: "SecurityStamp");

            migrationBuilder.RenameColumn(
                name: "PHONENUMBERCONFIRMED",
                table: "AspNetUsers",
                newName: "PhoneNumberConfirmed");

            migrationBuilder.RenameColumn(
                name: "PHONENUMBER",
                table: "AspNetUsers",
                newName: "PhoneNumber");

            migrationBuilder.RenameColumn(
                name: "PASSWORDHASH",
                table: "AspNetUsers",
                newName: "PasswordHash");

            migrationBuilder.RenameColumn(
                name: "NORMALIZEDUSERNAME",
                table: "AspNetUsers",
                newName: "NormalizedUserName");

            migrationBuilder.RenameColumn(
                name: "NORMALIZEDEMAIL",
                table: "AspNetUsers",
                newName: "NormalizedEmail");

            migrationBuilder.RenameColumn(
                name: "LOCKOUTEND",
                table: "AspNetUsers",
                newName: "LockoutEnd");

            migrationBuilder.RenameColumn(
                name: "LOCKOUTENABLED",
                table: "AspNetUsers",
                newName: "LockoutEnabled");

            migrationBuilder.RenameColumn(
                name: "EMAILCONFIRMED",
                table: "AspNetUsers",
                newName: "EmailConfirmed");

            migrationBuilder.RenameColumn(
                name: "EMAIL",
                table: "AspNetUsers",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "CONCURRENCYSTAMP",
                table: "AspNetUsers",
                newName: "ConcurrencyStamp");

            migrationBuilder.RenameColumn(
                name: "ACCESSFAILEDCOUNT",
                table: "AspNetUsers",
                newName: "AccessFailedCount");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "AspNetUsers",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ROLEID",
                table: "AspNetUserRoles",
                newName: "RoleId");

            migrationBuilder.RenameColumn(
                name: "USERID",
                table: "AspNetUserRoles",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_ASPNETUSERROLES_ROLEID",
                table: "AspNetUserRoles",
                newName: "IX_AspNetUserRoles_RoleId");

            migrationBuilder.RenameColumn(
                name: "USERID",
                table: "AspNetUserLogins",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "PROVIDERDISPLAYNAME",
                table: "AspNetUserLogins",
                newName: "ProviderDisplayName");

            migrationBuilder.RenameColumn(
                name: "PROVIDERKEY",
                table: "AspNetUserLogins",
                newName: "ProviderKey");

            migrationBuilder.RenameColumn(
                name: "LOGINPROVIDER",
                table: "AspNetUserLogins",
                newName: "LoginProvider");

            migrationBuilder.RenameIndex(
                name: "IX_ASPNETUSERLOGINS_USERID",
                table: "AspNetUserLogins",
                newName: "IX_AspNetUserLogins_UserId");

            migrationBuilder.RenameColumn(
                name: "USERID",
                table: "AspNetUserClaims",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "CLAIMVALUE",
                table: "AspNetUserClaims",
                newName: "ClaimValue");

            migrationBuilder.RenameColumn(
                name: "CLAIMTYPE",
                table: "AspNetUserClaims",
                newName: "ClaimType");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "AspNetUserClaims",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_ASPNETUSERCLAIMS_USERID",
                table: "AspNetUserClaims",
                newName: "IX_AspNetUserClaims_UserId");

            migrationBuilder.RenameColumn(
                name: "NORMALIZEDNAME",
                table: "AspNetRoles",
                newName: "NormalizedName");

            migrationBuilder.RenameColumn(
                name: "NAME",
                table: "AspNetRoles",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "CONCURRENCYSTAMP",
                table: "AspNetRoles",
                newName: "ConcurrencyStamp");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "AspNetRoles",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ROLEID",
                table: "AspNetRoleClaims",
                newName: "RoleId");

            migrationBuilder.RenameColumn(
                name: "CLAIMVALUE",
                table: "AspNetRoleClaims",
                newName: "ClaimValue");

            migrationBuilder.RenameColumn(
                name: "CLAIMTYPE",
                table: "AspNetRoleClaims",
                newName: "ClaimType");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "AspNetRoleClaims",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_ASPNETROLECLAIMS_ROLEID",
                table: "AspNetRoleClaims",
                newName: "IX_AspNetRoleClaims_RoleId");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserTokens",
                table: "AspNetUserTokens",
                columns: new[] { "UserId", "LoginProvider", "Name" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUsers",
                table: "AspNetUsers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserRoles",
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserLogins",
                table: "AspNetUserLogins",
                columns: new[] { "LoginProvider", "ProviderKey" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserClaims",
                table: "AspNetUserClaims",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetRoles",
                table: "AspNetRoles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetRoleClaims",
                table: "AspNetRoleClaims",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
