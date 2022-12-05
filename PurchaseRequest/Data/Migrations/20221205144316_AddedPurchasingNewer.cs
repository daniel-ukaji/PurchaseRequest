using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PurchaseRequest.Data.Migrations
{
    public partial class AddedPurchasingNewer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "PurchasingRequests",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "9554cd75-7946-438a-9aa2-5bf1d90755a0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4148-baaf-1acb431eabbf",
                column: "ConcurrencyStamp",
                value: "8280f104-304f-43b8-a9f0-0f2f806f5d73");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fa50a7fb-f8fa-45c4-97c6-071adaaf1dc9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "835e7903-176d-4b71-8b8c-00456522c32b", "AQAAAAEAACcQAAAAELsxe1OA3ydzEFWLy7/tAN4w76DPmDDZgGOOkVybMCx2KJTJhd1oOyuEWSO+5WT+Yw==", "8d17981e-01f4-404d-98fc-40b652bd3a89" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fa51a7eb-f8fa-43c4-96c6-071adbaf2db9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bf34ed64-42ab-4f1e-8ee9-fd78bcf1b3f4", "AQAAAAEAACcQAAAAEA17FYXHH4CwDD6o+pLHv+MkrKQhQhthsnSJWVf5lNog10XfOuk7tBKLlvyujPykTg==", "e0b1ab90-2ce5-4640-a66a-e6c60c0d0288" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "PurchasingRequests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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
    }
}
