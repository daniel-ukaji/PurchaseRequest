using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PurchaseRequest.Data.Migrations
{
    public partial class AddedDefaultUsersAndRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "cac43a6e-f7bb-4448-baaf-1add431ccbbf", "00cf15f6-9936-490f-bf49-331985085afc", "Administrator", "ADMINISTRATOR" },
                    { "cac43a7e-f7cb-4148-baaf-1acb431eabbf", "6ddc8d6f-5d2d-4b6f-876e-36d367ab6ba2", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "Firstname", "Lastname", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "fa50a7fb-f8fa-45c4-97c6-071adaaf1dc9", 0, "49c4cc21-76ac-42d1-98be-15d8d8281f92", "admin@test.com", false, "Admin", "Test", false, null, "ADMIN@TEST.COM", null, "AQAAAAEAACcQAAAAEOfbTW31nUs3KXQxhlotUWjBDI2BER/SQA/swMCC8yf2zeshHDtmX5dxZGB5NKkxsQ==", null, false, "b6c5117f-2802-4872-9009-067ab50d8c4a", null, false, null },
                    { "fa51a7eb-f8fa-43c4-96c6-071adbaf2db9", 0, "35d84664-c51a-419d-b5e4-a4c0066f3bd0", "admin@user.com", false, "Admin", "User", false, null, "ADMIN@USER.COM", null, "AQAAAAEAACcQAAAAEBCWnRby6+tcsFRlhYvHEnObxp307JoD3y564EmRVQCC3QZ62hHAvUQF5j0IeCHJ2w==", null, false, "d23de48d-262b-46d6-8d23-1ff9579af775", null, false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "cac43a6e-f7bb-4448-baaf-1add431ccbbf", "fa50a7fb-f8fa-45c4-97c6-071adaaf1dc9" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "cac43a7e-f7cb-4148-baaf-1acb431eabbf", "fa51a7eb-f8fa-43c4-96c6-071adbaf2db9" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cac43a6e-f7bb-4448-baaf-1add431ccbbf", "fa50a7fb-f8fa-45c4-97c6-071adaaf1dc9" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cac43a7e-f7cb-4148-baaf-1acb431eabbf", "fa51a7eb-f8fa-43c4-96c6-071adbaf2db9" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4148-baaf-1acb431eabbf");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fa50a7fb-f8fa-45c4-97c6-071adaaf1dc9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fa51a7eb-f8fa-43c4-96c6-071adbaf2db9");
        }
    }
}
