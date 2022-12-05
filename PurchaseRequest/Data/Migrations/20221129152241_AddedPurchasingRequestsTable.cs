using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PurchaseRequest.Data.Migrations
{
    public partial class AddedPurchasingRequestsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AdviceOnCost",
                table: "PurchasingRequests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "AmountProduction",
                table: "PurchasingRequests",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BalancePayment",
                table: "PurchasingRequests",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeliveryDate",
                table: "PurchasingRequests",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "PurchasingRequests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Items",
                table: "PurchasingRequests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Manufacturer",
                table: "PurchasingRequests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Model",
                table: "PurchasingRequests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Power",
                table: "PurchasingRequests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Prepayment",
                table: "PurchasingRequests",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "PurchasingRequests",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Rating",
                table: "PurchasingRequests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Unit",
                table: "PurchasingRequests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "VendorAddress",
                table: "PurchasingRequests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "VendorName",
                table: "PurchasingRequests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AdviceOnCost",
                table: "PurchasingRequests");

            migrationBuilder.DropColumn(
                name: "AmountProduction",
                table: "PurchasingRequests");

            migrationBuilder.DropColumn(
                name: "BalancePayment",
                table: "PurchasingRequests");

            migrationBuilder.DropColumn(
                name: "DeliveryDate",
                table: "PurchasingRequests");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "PurchasingRequests");

            migrationBuilder.DropColumn(
                name: "Items",
                table: "PurchasingRequests");

            migrationBuilder.DropColumn(
                name: "Manufacturer",
                table: "PurchasingRequests");

            migrationBuilder.DropColumn(
                name: "Model",
                table: "PurchasingRequests");

            migrationBuilder.DropColumn(
                name: "Power",
                table: "PurchasingRequests");

            migrationBuilder.DropColumn(
                name: "Prepayment",
                table: "PurchasingRequests");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "PurchasingRequests");

            migrationBuilder.DropColumn(
                name: "Rating",
                table: "PurchasingRequests");

            migrationBuilder.DropColumn(
                name: "Unit",
                table: "PurchasingRequests");

            migrationBuilder.DropColumn(
                name: "VendorAddress",
                table: "PurchasingRequests");

            migrationBuilder.DropColumn(
                name: "VendorName",
                table: "PurchasingRequests");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "ad9afe46-8754-4f42-a2bc-52eaeb399a46");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4148-baaf-1acb431eabbf",
                column: "ConcurrencyStamp",
                value: "18b6a048-c8c5-40b3-a5a1-1caa8cb90f71");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fa50a7fb-f8fa-45c4-97c6-071adaaf1dc9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7808dd6e-ac20-482e-98f2-64daef5acabb", "AQAAAAEAACcQAAAAEGkFVyiE+IX+CSF473FiQn3YtPRJ9h+ieHIOMwbp8Jxs+kit8/LV2VNb/AbP8qpGaw==", "e506987b-7789-4481-b848-cacdd83177fa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fa51a7eb-f8fa-43c4-96c6-071adbaf2db9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "89eb1293-c390-4cc1-b8e3-9f6ba7897f29", "AQAAAAEAACcQAAAAEIKWdnJkLN34wPcHSEzYM2VXOzDSmDcRNOTbGxB+kFXt6YQ9nKI52LJGG7vlWKkA3g==", "891699de-9e4a-42cb-ad3c-ef3ecbf9d594" });
        }
    }
}
