using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PurchaseRequest.Data.Migrations
{
    public partial class AddedPurchasingRequestsComments : Migration
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
                value: "006e49c7-7ce2-4cb3-abe8-f36238b1931b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4148-baaf-1acb431eabbf",
                column: "ConcurrencyStamp",
                value: "d50eec8f-84e9-4ef1-9958-fd5e35b4938b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fa50a7fb-f8fa-45c4-97c6-071adaaf1dc9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ca63fe87-d6ed-4c88-8e71-90e06f857b8c", "AQAAAAEAACcQAAAAECdAH7acwcFJi+oQ25BGwpe1+bYUk2Sq7NUENbs4x40xyg6THBcdDlxF2TAruSNqkw==", "6dcc6378-d56d-4e89-9313-6ab5485086c2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fa51a7eb-f8fa-43c4-96c6-071adbaf2db9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d9c0a733-2c17-4623-a5dd-df4d538c5bea", "AQAAAAEAACcQAAAAEJdg/LHaftLfkC0ZlwmvVu8I391KaMSOkKjcKzIP8MqFgQS1iFFK3iQfwdreKy2KUg==", "d3ce47e4-05ae-46e2-89d8-3a7e2eadb283" });
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
                value: "84bdf227-085b-46bb-b66f-9ab102b1c625");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4148-baaf-1acb431eabbf",
                column: "ConcurrencyStamp",
                value: "9443774c-5803-49c0-8902-eaee6293510c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fa50a7fb-f8fa-45c4-97c6-071adaaf1dc9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "50bbb0be-a744-4071-a464-8d163a3dec3b", "AQAAAAEAACcQAAAAECDV7Tb7oe4IVsjjOp3vWxP1H095dGpbu8Y5+RBJMyb4cDWG0mWeGVfQhDlPZXLnew==", "952b2b32-6481-4a26-ad17-d235e409cabb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fa51a7eb-f8fa-43c4-96c6-071adbaf2db9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4670102c-3eed-4494-bca8-b5bce82f851d", "AQAAAAEAACcQAAAAEPUy7c5Bc/YmnJt6IKJOlcgVRcLDWdhgEI1KsxF5LRk1DBv89/e15fhjQV6yyn2VPQ==", "5d5ca72b-e8e7-4c51-ad11-c6afa986834b" });
        }
    }
}
