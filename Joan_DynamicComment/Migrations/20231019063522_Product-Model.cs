using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Joan_DynamicComment.Migrations
{
    public partial class ProductModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "96d1ad38-120b-4897-b207-eed1b5619781", "96d1ad38-120b-4897-b207-eed1b5619781", "SupperAdmin", "SUPPERADMIN" },
                    { "a123e282-8c6e-4cf2-bd0a-558385bd17ab", "a123e282-8c6e-4cf2-bd0a-558385bd17ab", "User", "USER" },
                    { "c9574cb3-c486-4b08-91ed-60c6be55a9f7", "c9574cb3-c486-4b08-91ed-60c6be55a9f7", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "02fd7a6c-3f07-4780-845d-0f5f3a2ffd24", 0, "633c78ce-7b86-48dd-8d2c-95999800b5f8", "AppUser", "rft.smayilov@bk.ru", false, "RufatCode", false, null, "RFT.SMAYILOV@BK.RU", "RUFAT1122", "AQAAAAEAACcQAAAAECP0rimRATjJz6yTzvL1VeP6WCxyaNm9+MIm9wKKofoTL24b/UEaEBTPcNKlQ0iBdQ==", null, false, "0e90bef9-4491-4ed3-b9f0-c692b565ea55", false, "Rufat1122" },
                    { "f6c069fd-4b2a-4eef-baf2-2333710e2a1d", 0, "86727a6f-b5f5-4e9e-adfc-16a7e3901312", "AppUser", "rufatri@code.edu.az", false, "RufatIsmayilov", false, null, "RUFATRI@CODE.EDU.AZ", "RUFAT123", "AQAAAAEAACcQAAAAEJsiIVa6Nde1kWsi2gxR93uHSNh67WkPnvx5Ay477WAWhvy0TPW5qO7c4ZiD8MkmQA==", null, false, "b0d2b944-a9e6-45cd-9c70-112719a5a1f9", false, "Rufat123" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "c9574cb3-c486-4b08-91ed-60c6be55a9f7", "02fd7a6c-3f07-4780-845d-0f5f3a2ffd24" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "96d1ad38-120b-4897-b207-eed1b5619781", "f6c069fd-4b2a-4eef-baf2-2333710e2a1d" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a123e282-8c6e-4cf2-bd0a-558385bd17ab");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c9574cb3-c486-4b08-91ed-60c6be55a9f7", "02fd7a6c-3f07-4780-845d-0f5f3a2ffd24" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "96d1ad38-120b-4897-b207-eed1b5619781", "f6c069fd-4b2a-4eef-baf2-2333710e2a1d" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "96d1ad38-120b-4897-b207-eed1b5619781");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c9574cb3-c486-4b08-91ed-60c6be55a9f7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02fd7a6c-3f07-4780-845d-0f5f3a2ffd24");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f6c069fd-4b2a-4eef-baf2-2333710e2a1d");

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
    }
}
