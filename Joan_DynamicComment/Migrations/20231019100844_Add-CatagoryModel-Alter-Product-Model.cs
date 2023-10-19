using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Joan_DynamicComment.Migrations
{
    public partial class AddCatagoryModelAlterProductModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "6b534e9b-161d-4dcb-bf85-9eb5d998978e", "6b534e9b-161d-4dcb-bf85-9eb5d998978e", "SupperAdmin", "SUPPERADMIN" },
                    { "c0031f15-b7d2-48e8-9ad8-287f7d799e33", "c0031f15-b7d2-48e8-9ad8-287f7d799e33", "User", "USER" },
                    { "ee1c9731-f59d-4a09-b4c2-b55bca998f2f", "ee1c9731-f59d-4a09-b4c2-b55bca998f2f", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "5c930fd9-44c7-47ff-b84c-824c9b43000a", 0, "e422c622-7e79-48ec-95da-4447af0cdef9", "AppUser", "rufatri@code.edu.az", false, "RufatIsmayilov", false, null, "RUFATRI@CODE.EDU.AZ", "RUFAT123", "AQAAAAEAACcQAAAAEPhF0qw6sNW5DO8aEKfeaL+p25e+NwRrWGoT6oJINwVTxpP+fksE3rMsx24wiWaNOw==", null, false, "2f02c4b2-fb95-4486-94ca-d00573f38c82", false, "Rufat123" },
                    { "7119ac5f-6067-48a1-b1dc-63bd47fc9b4f", 0, "35c397a1-7c08-4dcf-9122-3a561af95961", "AppUser", "rft.smayilov@bk.ru", false, "RufatCode", false, null, "RFT.SMAYILOV@BK.RU", "RUFAT1122", "AQAAAAEAACcQAAAAEIuwEJLMVtTImtBoY88XRJ6rQ673j2YJNMMQl9ei7vPKBX8Zm9eB3teJ0rxKCwBCbA==", null, false, "ea4c5ad3-fdba-41b9-8d0f-da8234ad97ee", false, "Rufat1122" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "6b534e9b-161d-4dcb-bf85-9eb5d998978e", "5c930fd9-44c7-47ff-b84c-824c9b43000a" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ee1c9731-f59d-4a09-b4c2-b55bca998f2f", "7119ac5f-6067-48a1-b1dc-63bd47fc9b4f" });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Products_CategoryId",
                table: "Products");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c0031f15-b7d2-48e8-9ad8-287f7d799e33");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6b534e9b-161d-4dcb-bf85-9eb5d998978e", "5c930fd9-44c7-47ff-b84c-824c9b43000a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ee1c9731-f59d-4a09-b4c2-b55bca998f2f", "7119ac5f-6067-48a1-b1dc-63bd47fc9b4f" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6b534e9b-161d-4dcb-bf85-9eb5d998978e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ee1c9731-f59d-4a09-b4c2-b55bca998f2f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5c930fd9-44c7-47ff-b84c-824c9b43000a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7119ac5f-6067-48a1-b1dc-63bd47fc9b4f");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Products");

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
    }
}
