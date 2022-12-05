using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PurchaseRequest.Data.Migrations
{
    public partial class AddedDefaultUsersUsernames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "4cee7126-7859-42c7-9610-ec307e723d14");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4148-baaf-1acb431eabbf",
                column: "ConcurrencyStamp",
                value: "c98180ab-f416-4e96-b069-8bac12cd0670");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fa50a7fb-f8fa-45c4-97c6-071adaaf1dc9",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "caeb29ea-733c-4d97-a16f-d92e113bfab0", true, "ADMIN@TEST.COM", "AQAAAAEAACcQAAAAEJprmMDgBibmTlK9EHfieV+lzUtxur20QPbM/I/dOpBG5f4lvGQa0jcBWLKOmQbaLQ==", "c653d515-4d87-48ee-9040-ab5e2a34afcd", "admin@test.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fa51a7eb-f8fa-43c4-96c6-071adbaf2db9",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "e10ceef8-a8bb-480f-b2fb-b04fc3a94029", true, "ADMIN@USER.COM", "AQAAAAEAACcQAAAAEJDsBmgn2JN8f7cFDkfyUDbeKvM47hguBgQXKD8K7ERwWw80F5e641crDvVkmOaD3g==", "8bea9176-4c21-438e-9c7e-9ca2ac13ecb7", "admin@user.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "00cf15f6-9936-490f-bf49-331985085afc");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4148-baaf-1acb431eabbf",
                column: "ConcurrencyStamp",
                value: "6ddc8d6f-5d2d-4b6f-876e-36d367ab6ba2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fa50a7fb-f8fa-45c4-97c6-071adaaf1dc9",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "49c4cc21-76ac-42d1-98be-15d8d8281f92", false, null, "AQAAAAEAACcQAAAAEOfbTW31nUs3KXQxhlotUWjBDI2BER/SQA/swMCC8yf2zeshHDtmX5dxZGB5NKkxsQ==", "b6c5117f-2802-4872-9009-067ab50d8c4a", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fa51a7eb-f8fa-43c4-96c6-071adbaf2db9",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "35d84664-c51a-419d-b5e4-a4c0066f3bd0", false, null, "AQAAAAEAACcQAAAAEBCWnRby6+tcsFRlhYvHEnObxp307JoD3y564EmRVQCC3QZ62hHAvUQF5j0IeCHJ2w==", "d23de48d-262b-46d6-8d23-1ff9579af775", null });
        }
    }
}
