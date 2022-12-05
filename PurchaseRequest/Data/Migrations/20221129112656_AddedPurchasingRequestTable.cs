using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PurchaseRequest.Data.Migrations
{
    public partial class AddedPurchasingRequestTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PurchasingRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PurchaseTypeId = table.Column<int>(type: "int", nullable: false),
                    DateRequested = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RequestComments = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Approved = table.Column<bool>(type: "bit", nullable: true),
                    Cancelled = table.Column<bool>(type: "bit", nullable: false),
                    RequestingEmployeeId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchasingRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PurchasingRequests_PurchaseTypes_PurchaseTypeId",
                        column: x => x.PurchaseTypeId,
                        principalTable: "PurchaseTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_PurchasingRequests_PurchaseTypeId",
                table: "PurchasingRequests",
                column: "PurchaseTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PurchasingRequests");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "17c1133f-7902-4eff-8bf6-3108e2898e38");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4148-baaf-1acb431eabbf",
                column: "ConcurrencyStamp",
                value: "9ce33b6d-359e-4e45-b282-9d9f5ba04755");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fa50a7fb-f8fa-45c4-97c6-071adaaf1dc9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "abe9fce1-76ba-4338-a1e9-03965149448d", "AQAAAAEAACcQAAAAEHyBz/3lJAnTmhuOVyNMm+MPMZCqQxZ+zFyBGvhhwVumKwyACewxg0tCdU5JQbvp/w==", "583da5d4-0178-47cb-9f5a-6266c9e38b68" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fa51a7eb-f8fa-43c4-96c6-071adbaf2db9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "05b6d4ba-1684-4ee2-8b2f-3755b3a0e230", "AQAAAAEAACcQAAAAEN6Pnckx4QkJYkKCuiNI64Cx4rYwUDTYp7tOPEFlpKzUBpmZeWQngOiGQJhP0393cg==", "fd503ff2-c4b1-4a0b-8d86-b97dfad2b50b" });
        }
    }
}
