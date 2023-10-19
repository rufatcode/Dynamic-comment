using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Joan_DynamicComment.Migrations
{
    public partial class AlterProductModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "df7841de-229f-436b-b899-3efb2763c720");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f3e6791f-42af-46a3-9ef8-dfc9121ac540", "425ce4c3-2f1e-471d-b662-459df48793c7" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "432f76a7-b6e4-415f-8165-7e10cbef2462", "cfa5d316-d6ad-4f69-a179-b914dff0130e" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "432f76a7-b6e4-415f-8165-7e10cbef2462");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f3e6791f-42af-46a3-9ef8-dfc9121ac540");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "425ce4c3-2f1e-471d-b662-459df48793c7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cfa5d316-d6ad-4f69-a179-b914dff0130e");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "70724ad9-b80f-49ef-bde5-b08d6d3c1666", "70724ad9-b80f-49ef-bde5-b08d6d3c1666", "Admin", "ADMIN" },
                    { "b26a2904-81d4-41cf-b76d-fc185aa73820", "b26a2904-81d4-41cf-b76d-fc185aa73820", "SupperAdmin", "SUPPERADMIN" },
                    { "d312803e-40a4-4084-b41e-8fe47bcc94e3", "d312803e-40a4-4084-b41e-8fe47bcc94e3", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "5c61721d-fce0-48d2-91bd-963513bd0740", 0, "28594819-726a-400e-9f8b-65c684d22e4a", "AppUser", "rufatri@code.edu.az", false, "RufatIsmayilov", false, null, "RUFATRI@CODE.EDU.AZ", "RUFAT123", "AQAAAAEAACcQAAAAEAIyl/YJVgXFA7KjqNJPpettNbftAS3DJjMOpN3gco4PPr1/o+4hwmFQgrhYEcsSXw==", null, false, "77f68d74-2fcd-4195-b071-552c7dc7b073", false, "Rufat123" },
                    { "5dfd6a36-e738-4b06-aa75-d546ab9babfd", 0, "4617fe51-3d8e-404f-9259-6c1b3fda673b", "AppUser", "rft.smayilov@bk.ru", false, "RufatCode", false, null, "RFT.SMAYILOV@BK.RU", "RUFAT1122", "AQAAAAEAACcQAAAAEKb04HDqQn3g9XdqJBO1Ft5IGumhQIHouES6O1K9/BdS/UUh6x9NEvZMbTgzEXKOug==", null, false, "86c045ce-e3bc-4752-8784-54c91722779d", false, "Rufat1122" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "b26a2904-81d4-41cf-b76d-fc185aa73820", "5c61721d-fce0-48d2-91bd-963513bd0740" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "70724ad9-b80f-49ef-bde5-b08d6d3c1666", "5dfd6a36-e738-4b06-aa75-d546ab9babfd" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d312803e-40a4-4084-b41e-8fe47bcc94e3");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b26a2904-81d4-41cf-b76d-fc185aa73820", "5c61721d-fce0-48d2-91bd-963513bd0740" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "70724ad9-b80f-49ef-bde5-b08d6d3c1666", "5dfd6a36-e738-4b06-aa75-d546ab9babfd" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "70724ad9-b80f-49ef-bde5-b08d6d3c1666");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b26a2904-81d4-41cf-b76d-fc185aa73820");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5c61721d-fce0-48d2-91bd-963513bd0740");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5dfd6a36-e738-4b06-aa75-d546ab9babfd");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Products");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "432f76a7-b6e4-415f-8165-7e10cbef2462", "432f76a7-b6e4-415f-8165-7e10cbef2462", "SupperAdmin", "SUPPERADMIN" },
                    { "df7841de-229f-436b-b899-3efb2763c720", "df7841de-229f-436b-b899-3efb2763c720", "User", "USER" },
                    { "f3e6791f-42af-46a3-9ef8-dfc9121ac540", "f3e6791f-42af-46a3-9ef8-dfc9121ac540", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "425ce4c3-2f1e-471d-b662-459df48793c7", 0, "433d83b2-7a09-4cc3-835d-e7228d9bf2cc", "AppUser", "rft.smayilov@bk.ru", false, "RufatCode", false, null, "RFT.SMAYILOV@BK.RU", "RUFAT1122", "AQAAAAEAACcQAAAAEDQM6xSNzM38FzLGkL/hLYjLZqgScNvF65t2mrzpGmM4lRTlSbFH/u9gRX4A4jKCXg==", null, false, "8f8274bb-1745-48bc-ac38-50af9c6570d1", false, "Rufat1122" },
                    { "cfa5d316-d6ad-4f69-a179-b914dff0130e", 0, "e8693a55-ff04-46f4-b337-97d0699c8566", "AppUser", "rufatri@code.edu.az", false, "RufatIsmayilov", false, null, "RUFATRI@CODE.EDU.AZ", "RUFAT123", "AQAAAAEAACcQAAAAEFYbLQ7Hu66CFpqjPGJ4DfgO6EFGdGC9yjBoIsbUIcqUQxvBvqQS6Wt8+KVBz1bk2w==", null, false, "38e25878-e29d-4884-b130-f1074e20c5f6", false, "Rufat123" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "f3e6791f-42af-46a3-9ef8-dfc9121ac540", "425ce4c3-2f1e-471d-b662-459df48793c7" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "432f76a7-b6e4-415f-8165-7e10cbef2462", "cfa5d316-d6ad-4f69-a179-b914dff0130e" });
        }
    }
}
