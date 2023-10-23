using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Joan_DynamicComment.Migrations
{
    public partial class AlterModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f74e70f8-ec63-48a1-998a-0373a38af77c");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "424448b8-c42b-40fa-a254-7a8f05688148", "728e9885-335f-4ccf-85af-2541abe4c41f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "940b3928-482d-4b24-8f03-a27d81a6d0eb", "a60f973d-9e69-491c-96ba-3c7250cdee70" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "424448b8-c42b-40fa-a254-7a8f05688148");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "940b3928-482d-4b24-8f03-a27d81a6d0eb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "728e9885-335f-4ccf-85af-2541abe4c41f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a60f973d-9e69-491c-96ba-3c7250cdee70");

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Products",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "getdate()",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValueSql: "getDate()");

            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "Comments",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Comments",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "16a5771a-474c-4f57-9705-83b9734c6101", "16a5771a-474c-4f57-9705-83b9734c6101", "User", "USER" },
                    { "50b81689-7477-4ded-8705-ac1fa3fe0d41", "50b81689-7477-4ded-8705-ac1fa3fe0d41", "SupperAdmin", "SUPPERADMIN" },
                    { "9069b7a4-6acf-48e6-948c-1c7e65c457fa", "9069b7a4-6acf-48e6-948c-1c7e65c457fa", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FullName", "IsActive", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfileImgUrl", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "a44c6703-a555-4946-9576-d52442fbcbcc", 0, "d9a7e4f5-4643-4cac-a6df-76709c64ea33", "AppUser", "rft.smayilov@bk.ru", false, "RufatCode", false, false, null, "RFT.SMAYILOV@BK.RU", "RUFAT1122", "AQAAAAEAACcQAAAAEC6YLsTa8KVwTv1yn9MqurSSXE0hv4//CajODPtIB7Gl3WXT64CV7fA5I0GDsyq5hA==", null, false, null, "37ad590d-756f-4dac-b239-cfd4a0942fd5", false, "Rufat1122" },
                    { "c506b211-4586-4fd4-84c7-bf17b9494948", 0, "848b3eb3-f1ff-411d-8f2a-73f19324b178", "AppUser", "rufatri@code.edu.az", false, "RufatIsmayilov", false, false, null, "RUFATRI@CODE.EDU.AZ", "RUFAT123", "AQAAAAEAACcQAAAAEGtxCyJEuF/ANANzKbjKu4/1IhoVRkMIBOSkSF4PCdAO+btTlDm++BVrcKx1LHVncg==", null, false, null, "c57a572b-b236-4b75-9d29-74f43fe82fb7", false, "Rufat123" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "9069b7a4-6acf-48e6-948c-1c7e65c457fa", "a44c6703-a555-4946-9576-d52442fbcbcc" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "50b81689-7477-4ded-8705-ac1fa3fe0d41", "c506b211-4586-4fd4-84c7-bf17b9494948" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "16a5771a-474c-4f57-9705-83b9734c6101");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9069b7a4-6acf-48e6-948c-1c7e65c457fa", "a44c6703-a555-4946-9576-d52442fbcbcc" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "50b81689-7477-4ded-8705-ac1fa3fe0d41", "c506b211-4586-4fd4-84c7-bf17b9494948" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "50b81689-7477-4ded-8705-ac1fa3fe0d41");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9069b7a4-6acf-48e6-948c-1c7e65c457fa");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a44c6703-a555-4946-9576-d52442fbcbcc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c506b211-4586-4fd4-84c7-bf17b9494948");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Comments");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "getDate()",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValueSql: "getdate()");

            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "Comments",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "424448b8-c42b-40fa-a254-7a8f05688148", "424448b8-c42b-40fa-a254-7a8f05688148", "SupperAdmin", "SUPPERADMIN" },
                    { "940b3928-482d-4b24-8f03-a27d81a6d0eb", "940b3928-482d-4b24-8f03-a27d81a6d0eb", "Admin", "ADMIN" },
                    { "f74e70f8-ec63-48a1-998a-0373a38af77c", "f74e70f8-ec63-48a1-998a-0373a38af77c", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FullName", "IsActive", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfileImgUrl", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "728e9885-335f-4ccf-85af-2541abe4c41f", 0, "f6798bb3-1654-4d88-ab86-740131b448d4", "AppUser", "rufatri@code.edu.az", false, "RufatIsmayilov", false, false, null, "RUFATRI@CODE.EDU.AZ", "RUFAT123", "AQAAAAEAACcQAAAAEOuCm1GRHQVxnG5/RGcCsSSrDHn+qVaWn79zet7seISwUHrkQLnHbWk0w+Lt601Oqw==", null, false, null, "b2676b9f-720c-4489-834c-c9f1b23a8b1e", false, "Rufat123" },
                    { "a60f973d-9e69-491c-96ba-3c7250cdee70", 0, "99fc5406-421a-45b8-9567-b1e5eda66c17", "AppUser", "rft.smayilov@bk.ru", false, "RufatCode", false, false, null, "RFT.SMAYILOV@BK.RU", "RUFAT1122", "AQAAAAEAACcQAAAAEFWkdCAn6rByI5pv4A6Ljr4T2hNkDuwORQsekF6cDaqKOuF+KWZe+40AySBAMxPvxA==", null, false, null, "e154bd19-57c6-454b-8fdc-648052d24851", false, "Rufat1122" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "424448b8-c42b-40fa-a254-7a8f05688148", "728e9885-335f-4ccf-85af-2541abe4c41f" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "940b3928-482d-4b24-8f03-a27d81a6d0eb", "a60f973d-9e69-491c-96ba-3c7250cdee70" });
        }
    }
}
