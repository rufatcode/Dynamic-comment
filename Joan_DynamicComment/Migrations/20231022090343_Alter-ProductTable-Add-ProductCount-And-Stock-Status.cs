using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Joan_DynamicComment.Migrations
{
    public partial class AlterProductTableAddProductCountAndStockStatus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "Count",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IsAvaliable",
                table: "Products",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "dec624fe-5b91-4efa-b680-d24454ec2a65", "dec624fe-5b91-4efa-b680-d24454ec2a65", "SupperAdmin", "SUPPERADMIN" },
                    { "eea3e014-7c4d-4d79-bf17-63ddf5addb3d", "eea3e014-7c4d-4d79-bf17-63ddf5addb3d", "User", "USER" },
                    { "fe7dae1d-8839-48eb-8a4c-0b2322cfa176", "fe7dae1d-8839-48eb-8a4c-0b2322cfa176", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FullName", "IsActive", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfileImgUrl", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "3aa3cacb-36e2-494c-b57a-b1a2c8690d2f", 0, "67a72635-41e9-4a2b-9b6e-30a47a254578", "AppUser", "rft.smayilov@bk.ru", false, "RufatCode", false, false, null, "RFT.SMAYILOV@BK.RU", "RUFAT1122", "AQAAAAEAACcQAAAAEGS660MLh2TN25bvQRtAKvGTQtNN80xSIHc1heTUKKs3iUtjDPaBeySE+WVhWZtYtw==", null, false, null, "7400aeed-8363-49b7-93f4-d50388ad4315", false, "Rufat1122" },
                    { "50aea174-d5cf-4594-a4bf-f07b6a3aa7ac", 0, "c98d1610-b009-41e5-b2f3-9bb6393ed3f1", "AppUser", "rufatri@code.edu.az", false, "RufatIsmayilov", false, false, null, "RUFATRI@CODE.EDU.AZ", "RUFAT123", "AQAAAAEAACcQAAAAEPzHd1M0Up5YHHgYV9e/DP0Zu/vY4IVCi6UuvXTGQmzZOeOjf1RcSfoyjQ1E0iSXgQ==", null, false, null, "8f01b080-a11c-403f-b12f-e22324afc0d2", false, "Rufat123" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "fe7dae1d-8839-48eb-8a4c-0b2322cfa176", "3aa3cacb-36e2-494c-b57a-b1a2c8690d2f" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "dec624fe-5b91-4efa-b680-d24454ec2a65", "50aea174-d5cf-4594-a4bf-f07b6a3aa7ac" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eea3e014-7c4d-4d79-bf17-63ddf5addb3d");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "fe7dae1d-8839-48eb-8a4c-0b2322cfa176", "3aa3cacb-36e2-494c-b57a-b1a2c8690d2f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "dec624fe-5b91-4efa-b680-d24454ec2a65", "50aea174-d5cf-4594-a4bf-f07b6a3aa7ac" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dec624fe-5b91-4efa-b680-d24454ec2a65");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fe7dae1d-8839-48eb-8a4c-0b2322cfa176");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3aa3cacb-36e2-494c-b57a-b1a2c8690d2f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "50aea174-d5cf-4594-a4bf-f07b6a3aa7ac");

            migrationBuilder.DropColumn(
                name: "Count",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "IsAvaliable",
                table: "Products");

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
    }
}
