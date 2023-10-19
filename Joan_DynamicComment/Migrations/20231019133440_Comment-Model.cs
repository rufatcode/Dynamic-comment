using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Joan_DynamicComment.Migrations
{
    public partial class CommentModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateTable(
                name: "Comment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AppUserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comment_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Comment_Products_ProductId",
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

            migrationBuilder.CreateIndex(
                name: "IX_Comment_AppUserId",
                table: "Comment",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Comment_ProductId",
                table: "Comment",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comment");

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
        }
    }
}
