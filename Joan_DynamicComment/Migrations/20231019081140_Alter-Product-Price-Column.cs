using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Joan_DynamicComment.Migrations
{
    public partial class AlterProductPriceColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<int>(
                name: "Price",
                table: "Products",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "07e8b8f0-33b0-4b69-95b3-2ff14e581617", "07e8b8f0-33b0-4b69-95b3-2ff14e581617", "Admin", "ADMIN" },
                    { "c498d2fb-216d-4849-a2f6-eb9ae68d6c6f", "c498d2fb-216d-4849-a2f6-eb9ae68d6c6f", "User", "USER" },
                    { "c79119dc-2781-4f74-90a0-2621a306f3a4", "c79119dc-2781-4f74-90a0-2621a306f3a4", "SupperAdmin", "SUPPERADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "28631122-5d20-4bc7-b1a5-2948fb7acdbb", 0, "dd369d39-4e62-4d6b-9fda-da0cb50537c4", "AppUser", "rufatri@code.edu.az", false, "RufatIsmayilov", false, null, "RUFATRI@CODE.EDU.AZ", "RUFAT123", "AQAAAAEAACcQAAAAEPNJpuyRuyhQzXW0v112QrCT/tdwu8kqQjQopH5wWPpaOwDKBeQSR+n52BCwlfm6fA==", null, false, "05f1d007-2e6c-4ed3-aa83-291c9b8ba749", false, "Rufat123" },
                    { "b1293979-462f-4816-b956-a1a7c66c50fb", 0, "f1fcb5bb-08c4-46f0-8a07-0943dc6c7015", "AppUser", "rft.smayilov@bk.ru", false, "RufatCode", false, null, "RFT.SMAYILOV@BK.RU", "RUFAT1122", "AQAAAAEAACcQAAAAEG0CJrpNUQFqnu7SBVnFqlqTw6ubCqWbb7zBv/A/JG+wPdghOn+s3yE+wqVzqU0B4w==", null, false, "dabaf5f7-21c8-4212-a12c-feaebad74d1d", false, "Rufat1122" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "c79119dc-2781-4f74-90a0-2621a306f3a4", "28631122-5d20-4bc7-b1a5-2948fb7acdbb" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "07e8b8f0-33b0-4b69-95b3-2ff14e581617", "b1293979-462f-4816-b956-a1a7c66c50fb" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c498d2fb-216d-4849-a2f6-eb9ae68d6c6f");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c79119dc-2781-4f74-90a0-2621a306f3a4", "28631122-5d20-4bc7-b1a5-2948fb7acdbb" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "07e8b8f0-33b0-4b69-95b3-2ff14e581617", "b1293979-462f-4816-b956-a1a7c66c50fb" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "07e8b8f0-33b0-4b69-95b3-2ff14e581617");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c79119dc-2781-4f74-90a0-2621a306f3a4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "28631122-5d20-4bc7-b1a5-2948fb7acdbb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b1293979-462f-4816-b956-a1a7c66c50fb");

            migrationBuilder.AlterColumn<string>(
                name: "Price",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

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
    }
}
