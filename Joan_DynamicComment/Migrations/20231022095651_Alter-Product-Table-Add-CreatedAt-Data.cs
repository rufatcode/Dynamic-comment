using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Joan_DynamicComment.Migrations
{
    public partial class AlterProductTableAddCreatedAtData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "getdate()");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2653a245-d343-43ba-bc89-90a64bbbece7", "2653a245-d343-43ba-bc89-90a64bbbece7", "SupperAdmin", "SUPPERADMIN" },
                    { "a6e00b56-cd3c-455f-9ce1-691cfe948bf8", "a6e00b56-cd3c-455f-9ce1-691cfe948bf8", "Admin", "ADMIN" },
                    { "ea25b410-add9-43b0-87f0-a3f6217406cf", "ea25b410-add9-43b0-87f0-a3f6217406cf", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FullName", "IsActive", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfileImgUrl", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "61fdeab8-e5b8-4358-9fac-f54630f05097", 0, "3b81f437-7f2b-4f65-b30f-ca3e0f985466", "AppUser", "rufatri@code.edu.az", false, "RufatIsmayilov", false, false, null, "RUFATRI@CODE.EDU.AZ", "RUFAT123", "AQAAAAEAACcQAAAAEKAT6yzsGWPtcqYjOoeCFJq480MccWIP8nrbI1lnm2UhnYUjlj0fVqMGYq4FLTxXbQ==", null, false, null, "7a5dac0c-cc1d-499f-ae2a-dcb2957bf617", false, "Rufat123" },
                    { "da8cafd2-8097-4dd7-b09c-6b7563b83f97", 0, "dc391245-735d-4f69-ae4b-1584f6512bab", "AppUser", "rft.smayilov@bk.ru", false, "RufatCode", false, false, null, "RFT.SMAYILOV@BK.RU", "RUFAT1122", "AQAAAAEAACcQAAAAEISCuH5PLhvUAcJyltrWslEatbdBs7opiXWe+QBFT1Ek6eOebsniiNp5TKYC5g3yVg==", null, false, null, "467833fa-de7f-4f34-85ae-be3c1138de7b", false, "Rufat1122" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "2653a245-d343-43ba-bc89-90a64bbbece7", "61fdeab8-e5b8-4358-9fac-f54630f05097" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "a6e00b56-cd3c-455f-9ce1-691cfe948bf8", "da8cafd2-8097-4dd7-b09c-6b7563b83f97" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ea25b410-add9-43b0-87f0-a3f6217406cf");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2653a245-d343-43ba-bc89-90a64bbbece7", "61fdeab8-e5b8-4358-9fac-f54630f05097" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a6e00b56-cd3c-455f-9ce1-691cfe948bf8", "da8cafd2-8097-4dd7-b09c-6b7563b83f97" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2653a245-d343-43ba-bc89-90a64bbbece7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a6e00b56-cd3c-455f-9ce1-691cfe948bf8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "61fdeab8-e5b8-4358-9fac-f54630f05097");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "da8cafd2-8097-4dd7-b09c-6b7563b83f97");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Products");

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
    }
}
