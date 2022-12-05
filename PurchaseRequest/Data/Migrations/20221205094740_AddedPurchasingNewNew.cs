using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PurchaseRequest.Data.Migrations
{
    public partial class AddedPurchasingNewNew : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "0140670a-0e60-497e-b53c-c57b070f328f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4148-baaf-1acb431eabbf",
                column: "ConcurrencyStamp",
                value: "aad932c2-913d-491e-8f95-942da60e7f3b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fa50a7fb-f8fa-45c4-97c6-071adaaf1dc9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e381337e-41b6-45ac-bad8-55a13a19921c", "AQAAAAEAACcQAAAAEFBkSB5tVF7/AB94sM9htJsX3Jy3GGXwUQRNtgQJp/mFbsnd3fKylZO27Esq+/d+Aw==", "7c0e0169-35cb-4b24-94d5-fd962c648a10" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fa51a7eb-f8fa-43c4-96c6-071adbaf2db9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "07cdf3e2-1186-4d1e-b7bb-61b6a6d33969", "AQAAAAEAACcQAAAAECQnlkaDealYEz2JaQFloEJ/tToFn/uqXSv8LKJ/js8bHK5zbyiB53Ma/t1UWc7wuQ==", "d895dd90-4a6b-41c8-957a-7d12010360c2" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "c1b7300d-37e3-4221-ad9b-41e09c874074");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4148-baaf-1acb431eabbf",
                column: "ConcurrencyStamp",
                value: "8ed5bc80-dce0-4c9b-9a12-6be2b8cbe2cd");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fa50a7fb-f8fa-45c4-97c6-071adaaf1dc9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "084aec6b-ee92-44ca-b5c3-ce188aee5e11", "AQAAAAEAACcQAAAAEKloAnRhh9cXHok0OoJBMFu5WS0x+2YaxSVioRsinATcKZu7s0UedbHT2V5bYhDL7Q==", "d7e2d78e-62d9-4384-83ab-81d04ecd6f08" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fa51a7eb-f8fa-43c4-96c6-071adbaf2db9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3f59a046-9d53-4040-bd53-86531ff1014d", "AQAAAAEAACcQAAAAEAfEO10C6dZVHwZSDi5qIkayKFicYvUau8e4Uy1xnppn02Y4sIRQVq48jvax4Zo40w==", "d98f38fa-da5f-49cf-b575-f6215d873075" });
        }
    }
}
