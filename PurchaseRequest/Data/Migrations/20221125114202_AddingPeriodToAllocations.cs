using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PurchaseRequest.Data.Migrations
{
    public partial class AddingPeriodToAllocations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumberOfDays",
                table: "PurchaseAllocations");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NumberOfDays",
                table: "PurchaseAllocations",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "ffdd6348-7ecc-4074-b81e-25a11ffcfc60");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4148-baaf-1acb431eabbf",
                column: "ConcurrencyStamp",
                value: "bc9c83cc-c181-45b2-ab6e-1a12de2d0dc0");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fa50a7fb-f8fa-45c4-97c6-071adaaf1dc9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "95c7f5ae-5b31-4317-a8da-c691fe75d85b", "AQAAAAEAACcQAAAAEHz+v50g6v1y1iecD9wJh+xL7Z7QOCCWoeiRNcooluNc/cIjHcJIs4doTEcgNXuCPg==", "6d8395c8-9082-44c1-abbc-637382b63559" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fa51a7eb-f8fa-43c4-96c6-071adbaf2db9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5d3c2348-6b7d-400a-bf9b-6f9249f45404", "AQAAAAEAACcQAAAAEKcKDEVAcpABXBbEz+QJu3hlCE+PeFHf2fa3gp31ZC4OKR/8xpSg8nrKOK7wl8CX7Q==", "e756941c-79b4-42c7-8b47-5e376de255b8" });
        }
    }
}
