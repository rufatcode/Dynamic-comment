using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Joan_DynamicComment.Migrations
{
    public partial class ProductImagesModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SalePercantage = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    ImgUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsMain = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductImages_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_ProductId",
                table: "ProductImages",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductImages");

            migrationBuilder.DropTable(
                name: "Products");

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
    }
}
