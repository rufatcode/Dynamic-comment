using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Joan_DynamicComment.Migrations
{
    public partial class AlterAppUserTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Comment",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "getDate()",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "Comment",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "AspNetUsers",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProfileImgUrl",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "87758756-3f05-4e48-b30e-e0bec78f24c5", "87758756-3f05-4e48-b30e-e0bec78f24c5", "Admin", "ADMIN" },
                    { "bddbab4d-e22a-47cc-b6ec-4dbd959abe45", "bddbab4d-e22a-47cc-b6ec-4dbd959abe45", "SupperAdmin", "SUPPERADMIN" },
                    { "d29f23a1-ce8b-4ae9-b152-ca0084e001be", "d29f23a1-ce8b-4ae9-b152-ca0084e001be", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FullName", "IsActive", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfileImgUrl", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0c26e9c5-e7d9-42bc-87ce-432e9af4b423", 0, "32e854ce-eff0-4525-b5d6-79064a89e699", "AppUser", "rft.smayilov@bk.ru", false, "RufatCode", false, false, null, "RFT.SMAYILOV@BK.RU", "RUFAT1122", "AQAAAAEAACcQAAAAEDzh2nBiCOhU2xJBSH7+JkjGiyEGasOq2+mazY578RcVcsfI0ynn4Q+uQz8uN2jYXw==", null, false, null, "452d0313-ac77-4ef8-89e4-a0ad49873687", false, "Rufat1122" },
                    { "764e41be-3ace-4f92-b889-2c8aefcca270", 0, "198761d7-fb94-4d77-b22a-7dd12b95c8cc", "AppUser", "rufatri@code.edu.az", false, "RufatIsmayilov", false, false, null, "RUFATRI@CODE.EDU.AZ", "RUFAT123", "AQAAAAEAACcQAAAAEIpruEEHQtFXpwrmwVXtslwzC8QQrsrTTkTWdyKvQ/wsPN9ZygWOQ+RvrMNymC7NcA==", null, false, null, "f0293e63-2ff5-46ff-bc79-b0bd9c01ead3", false, "Rufat123" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "87758756-3f05-4e48-b30e-e0bec78f24c5", "0c26e9c5-e7d9-42bc-87ce-432e9af4b423" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "bddbab4d-e22a-47cc-b6ec-4dbd959abe45", "764e41be-3ace-4f92-b889-2c8aefcca270" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d29f23a1-ce8b-4ae9-b152-ca0084e001be");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "87758756-3f05-4e48-b30e-e0bec78f24c5", "0c26e9c5-e7d9-42bc-87ce-432e9af4b423" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "bddbab4d-e22a-47cc-b6ec-4dbd959abe45", "764e41be-3ace-4f92-b889-2c8aefcca270" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "87758756-3f05-4e48-b30e-e0bec78f24c5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bddbab4d-e22a-47cc-b6ec-4dbd959abe45");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0c26e9c5-e7d9-42bc-87ce-432e9af4b423");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "764e41be-3ace-4f92-b889-2c8aefcca270");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ProfileImgUrl",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Comment",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValueSql: "getDate()");

            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "Comment",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250);

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
    }
}
