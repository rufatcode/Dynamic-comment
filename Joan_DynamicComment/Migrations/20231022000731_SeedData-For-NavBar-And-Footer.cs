using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Joan_DynamicComment.Migrations
{
    public partial class SeedDataForNavBarAndFooter : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comment_AspNetUsers_AppUserId",
                table: "Comment");

            migrationBuilder.DropForeignKey(
                name: "FK_Comment_Products_ProductId",
                table: "Comment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Comment",
                table: "Comment");

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

            migrationBuilder.RenameTable(
                name: "Comment",
                newName: "Comments");

            migrationBuilder.RenameIndex(
                name: "IX_Comment_ProductId",
                table: "Comments",
                newName: "IX_Comments_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_Comment_AppUserId",
                table: "Comments",
                newName: "IX_Comments_AppUserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Comments",
                table: "Comments",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "NavBars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Key = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NavBars", x => x.Id);
                });

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
                table: "NavBars",
                columns: new[] { "Id", "Key", "Value" },
                values: new object[,]
                {
                    { 1, "Location", "184 Main Rd E, St Albans VIC 3021, Australia" },
                    { 2, "Mail", "rft.smayilov@bk.com" },
                    { 3, "Phone", "+ 00 254 254565" },
                    { 4, "Instegram", "https://www.integram.com/in/rufat-ismayilov/" },
                    { 5, "Facebook", "https://www.Facebook.com/in/rufat-ismayilov/" },
                    { 6, "Twitter", "https://www.Twitter.com/in/rufat-ismayilov/" },
                    { 7, "LinkendIn", "https://www.linkedin.com/in/rufat-ismayilov/" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "424448b8-c42b-40fa-a254-7a8f05688148", "728e9885-335f-4ccf-85af-2541abe4c41f" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "940b3928-482d-4b24-8f03-a27d81a6d0eb", "a60f973d-9e69-491c-96ba-3c7250cdee70" });

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_AspNetUsers_AppUserId",
                table: "Comments",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Products_ProductId",
                table: "Comments",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_AspNetUsers_AppUserId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Products_ProductId",
                table: "Comments");

            migrationBuilder.DropTable(
                name: "NavBars");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Comments",
                table: "Comments");

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

            migrationBuilder.RenameTable(
                name: "Comments",
                newName: "Comment");

            migrationBuilder.RenameIndex(
                name: "IX_Comments_ProductId",
                table: "Comment",
                newName: "IX_Comment_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_Comments_AppUserId",
                table: "Comment",
                newName: "IX_Comment_AppUserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Comment",
                table: "Comment",
                column: "Id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Comment_AspNetUsers_AppUserId",
                table: "Comment",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Comment_Products_ProductId",
                table: "Comment",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
