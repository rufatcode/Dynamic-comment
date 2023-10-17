using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Joan_DynamicComment.Migrations
{
    public partial class SeedDataForRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FullName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2ee762ec-a6bc-4e2f-8ebf-7782ad92d56f", "2ee762ec-a6bc-4e2f-8ebf-7782ad92d56f", "SupperAdmin", "SUPPERADMIN" },
                    { "607a217e-c168-492f-85ae-8e2195aa7182", "607a217e-c168-492f-85ae-8e2195aa7182", "Admin", "ADMIN" },
                    { "fa9a1063-bbb1-4712-a1fc-df620395204a", "fa9a1063-bbb1-4712-a1fc-df620395204a", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "6e121aff-c2a8-414f-a1d2-04b99a040ccf", 0, "d2ca6981-be5d-4199-9071-9a4b56c41e44", "AppUser", "rufatri@code.edu.az", false, "RufatIsmayilov", false, null, "RUFATRI@CODE.EDU.AZ", "RUFAT123", "AQAAAAEAACcQAAAAEIpCj0ztJkC5j4HZCqq9kvLclfXsXUoKk2nD3yxrcz/q4hT6u09MmiUjJc7vIJ7yNg==", null, false, "b8592727-acbd-42bb-9c9b-1783a2b72d95", false, "Rufat123" },
                    { "830a2325-e784-487a-b654-e6b90e22da03", 0, "4eff8f53-6f7e-4ec9-8b48-f1161464296b", "AppUser", "rft.smayilov@bk.ru", false, "RufatCode", false, null, "RFT.SMAYILOV@BK.RU", "RUFAT1122", "AQAAAAEAACcQAAAAEIIxE1PUswnHeVY6sdDTsrIDXvtXR3GgaNeaHVZnXuqTIxLLFy5l1pJAOkGa1jOnhQ==", null, false, "1617ab74-4d43-41f0-87ad-78b89e545db0", false, "Rufat1122" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "2ee762ec-a6bc-4e2f-8ebf-7782ad92d56f", "6e121aff-c2a8-414f-a1d2-04b99a040ccf" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "607a217e-c168-492f-85ae-8e2195aa7182", "830a2325-e784-487a-b654-e6b90e22da03" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fa9a1063-bbb1-4712-a1fc-df620395204a");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2ee762ec-a6bc-4e2f-8ebf-7782ad92d56f", "6e121aff-c2a8-414f-a1d2-04b99a040ccf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "607a217e-c168-492f-85ae-8e2195aa7182", "830a2325-e784-487a-b654-e6b90e22da03" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2ee762ec-a6bc-4e2f-8ebf-7782ad92d56f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "607a217e-c168-492f-85ae-8e2195aa7182");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6e121aff-c2a8-414f-a1d2-04b99a040ccf");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "830a2325-e784-487a-b654-e6b90e22da03");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FullName",
                table: "AspNetUsers");
        }
    }
}
