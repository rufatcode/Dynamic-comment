using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Joan_DynamicComment.Migrations
{
    public partial class AlterCommentModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c6a34c0b-d310-4457-9cbf-b1685d3c61d2");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "83bd1ae3-889d-456a-a274-726fd9e477cd", "93bedec5-9fd3-4e1f-aa40-c45270c2a9b8" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9f942948-d9d2-4f37-b3ae-e5ae22a6d772", "db5fff23-04fe-4d52-95fe-283b66795002" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "83bd1ae3-889d-456a-a274-726fd9e477cd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9f942948-d9d2-4f37-b3ae-e5ae22a6d772");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "93bedec5-9fd3-4e1f-aa40-c45270c2a9b8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "db5fff23-04fe-4d52-95fe-283b66795002");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "47314eeb-7be5-4469-b3f0-79a68e38ac22", "47314eeb-7be5-4469-b3f0-79a68e38ac22", "SupperAdmin", "SUPPERADMIN" },
                    { "54a25f0a-a424-4f5c-899e-625318cb5422", "54a25f0a-a424-4f5c-899e-625318cb5422", "User", "USER" },
                    { "8aba25a5-9425-4e83-b2cd-ec464222ebea", "8aba25a5-9425-4e83-b2cd-ec464222ebea", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "215b4ba2-b1ef-4fa1-a0af-96774daeacec", 0, "d7e10652-0d45-4fb0-818d-db47cc9b131d", "AppUser", "rft.smayilov@bk.ru", false, "RufatCode", false, null, "RFT.SMAYILOV@BK.RU", "RUFAT1122", "AQAAAAEAACcQAAAAENWrUtBSpMqBUwf1MJM4VLzyKJdg4Iyzcuyedzmg5Byu1fJloiPocW7bKbRhlerSsg==", null, false, "63ffa3c9-e83a-44c6-be06-d9d1e225b873", false, "Rufat1122" },
                    { "56646946-3ee5-4782-b87c-5d103a700069", 0, "f09fee25-cb32-447a-95e9-b8e3ca211d2b", "AppUser", "rufatri@code.edu.az", false, "RufatIsmayilov", false, null, "RUFATRI@CODE.EDU.AZ", "RUFAT123", "AQAAAAEAACcQAAAAEAefjsbOouLnHZ3268yG6Q4ugV9TdfO3ZUGfkGv8dU4J51C6FCsIv7pPhoI2gQiz6A==", null, false, "3020dc6c-81a7-43cc-be09-2dfba6fab147", false, "Rufat123" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "8aba25a5-9425-4e83-b2cd-ec464222ebea", "215b4ba2-b1ef-4fa1-a0af-96774daeacec" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "47314eeb-7be5-4469-b3f0-79a68e38ac22", "56646946-3ee5-4782-b87c-5d103a700069" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "54a25f0a-a424-4f5c-899e-625318cb5422");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8aba25a5-9425-4e83-b2cd-ec464222ebea", "215b4ba2-b1ef-4fa1-a0af-96774daeacec" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "47314eeb-7be5-4469-b3f0-79a68e38ac22", "56646946-3ee5-4782-b87c-5d103a700069" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "47314eeb-7be5-4469-b3f0-79a68e38ac22");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8aba25a5-9425-4e83-b2cd-ec464222ebea");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "215b4ba2-b1ef-4fa1-a0af-96774daeacec");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "56646946-3ee5-4782-b87c-5d103a700069");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "83bd1ae3-889d-456a-a274-726fd9e477cd", "83bd1ae3-889d-456a-a274-726fd9e477cd", "SupperAdmin", "SUPPERADMIN" },
                    { "9f942948-d9d2-4f37-b3ae-e5ae22a6d772", "9f942948-d9d2-4f37-b3ae-e5ae22a6d772", "Admin", "ADMIN" },
                    { "c6a34c0b-d310-4457-9cbf-b1685d3c61d2", "c6a34c0b-d310-4457-9cbf-b1685d3c61d2", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "93bedec5-9fd3-4e1f-aa40-c45270c2a9b8", 0, "d21b1be4-c724-4ac4-bec5-5e3b1af4d4b8", "AppUser", "rufatri@code.edu.az", false, "RufatIsmayilov", false, null, "RUFATRI@CODE.EDU.AZ", "RUFAT123", "AQAAAAEAACcQAAAAEFgWMX98UkXZLMtdZdNSD9oGR+xE9xezyUNbqO8IWTPUN6UD4WYBMKyEWkHehiLIVA==", null, false, "48dea0c7-157e-471b-9614-42d58801f50a", false, "Rufat123" },
                    { "db5fff23-04fe-4d52-95fe-283b66795002", 0, "38bf0741-26d7-48ab-afb9-afc9a8e0b8bc", "AppUser", "rft.smayilov@bk.ru", false, "RufatCode", false, null, "RFT.SMAYILOV@BK.RU", "RUFAT1122", "AQAAAAEAACcQAAAAEE+uoqSFs/rzOEMc3Mbe/H04yKURreIXuWR8j4rKxE/w0idH/4QZLogFhf3jlsw8Dg==", null, false, "d6013780-b1da-4038-a5e6-7b584522339b", false, "Rufat1122" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "83bd1ae3-889d-456a-a274-726fd9e477cd", "93bedec5-9fd3-4e1f-aa40-c45270c2a9b8" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "9f942948-d9d2-4f37-b3ae-e5ae22a6d772", "db5fff23-04fe-4d52-95fe-283b66795002" });
        }
    }
}
