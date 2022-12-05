using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PurchaseRequest.Data.Migrations
{
    public partial class AddedPurchasingNewest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "9bed70d3-f568-4725-9e60-986084d49d5a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4148-baaf-1acb431eabbf",
                column: "ConcurrencyStamp",
                value: "40f0f71d-a982-428c-b6e8-8b49eb52b606");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fa50a7fb-f8fa-45c4-97c6-071adaaf1dc9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5200f6f4-7798-447d-8e05-7083e6fa62bb", "AQAAAAEAACcQAAAAEOaBZUB3M5jgRkdHdpZy+GkPIjiGE/nIsdEBqcXDlkYMOBjqBweKSLcXw16J1H1Zzw==", "54cea9e2-3a57-490a-a010-177c50706dd7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fa51a7eb-f8fa-43c4-96c6-071adbaf2db9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ea77e2b8-7287-4af0-869f-65e5c20aa189", "AQAAAAEAACcQAAAAEJueX/39WObsC4vrHdIwUEtYMtWwtsPCrTqBt8/UZhhUCmz2MwaCGd4DmmDq+2W2EA==", "852e7c48-698e-4440-8a44-ef66ab479060" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
