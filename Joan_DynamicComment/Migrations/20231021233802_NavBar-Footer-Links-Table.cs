using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Joan_DynamicComment.Migrations
{
    public partial class NavBarFooterLinksTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "b2748374-e660-40c6-891b-22029170fced", "b2748374-e660-40c6-891b-22029170fced", "SupperAdmin", "SUPPERADMIN" },
                    { "bed757d1-7862-42d3-be86-86e420e7015f", "bed757d1-7862-42d3-be86-86e420e7015f", "Admin", "ADMIN" },
                    { "fd206b27-e4b9-4714-9855-5b131c7512dc", "fd206b27-e4b9-4714-9855-5b131c7512dc", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FullName", "IsActive", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfileImgUrl", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "181a3d11-7c93-41d3-9c1e-2f134fcc3927", 0, "493e96b4-5708-4eb9-8380-1b7a43aa8428", "AppUser", "rufatri@code.edu.az", false, "RufatIsmayilov", false, false, null, "RUFATRI@CODE.EDU.AZ", "RUFAT123", "AQAAAAEAACcQAAAAEFOxSFGzszolClDaM6vFm3Om+Aq0WdmTQeJ3lUxaFPVvKlWSOntA1uphVUvQ9iJklA==", null, false, null, "ff7154a6-bdaa-4800-8768-57be18e68e87", false, "Rufat123" },
                    { "3f5b763e-b187-4a66-84ba-3ea6543ed9ad", 0, "bc6e2578-916b-474c-bb9d-9551a42c7a7b", "AppUser", "rft.smayilov@bk.ru", false, "RufatCode", false, false, null, "RFT.SMAYILOV@BK.RU", "RUFAT1122", "AQAAAAEAACcQAAAAEDr3eXqY8dMffDVZnAYXRNNanHgqEuB78IwWZRYPFYRxcAv9KbV+FxHYfBdH6bmeoQ==", null, false, null, "cc237e70-3a61-4859-8f0a-9445d5fe81a0", false, "Rufat1122" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "b2748374-e660-40c6-891b-22029170fced", "181a3d11-7c93-41d3-9c1e-2f134fcc3927" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "bed757d1-7862-42d3-be86-86e420e7015f", "3f5b763e-b187-4a66-84ba-3ea6543ed9ad" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fd206b27-e4b9-4714-9855-5b131c7512dc");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b2748374-e660-40c6-891b-22029170fced", "181a3d11-7c93-41d3-9c1e-2f134fcc3927" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "bed757d1-7862-42d3-be86-86e420e7015f", "3f5b763e-b187-4a66-84ba-3ea6543ed9ad" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b2748374-e660-40c6-891b-22029170fced");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bed757d1-7862-42d3-be86-86e420e7015f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "181a3d11-7c93-41d3-9c1e-2f134fcc3927");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f5b763e-b187-4a66-84ba-3ea6543ed9ad");

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
    }
}
