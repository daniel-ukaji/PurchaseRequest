using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PurchaseRequest.Data.Migrations
{
    public partial class AddingPeriodToAllocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Period",
                table: "PurchaseAllocations",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Period",
                table: "PurchaseAllocations");

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "caeb29ea-733c-4d97-a16f-d92e113bfab0", "AQAAAAEAACcQAAAAEJprmMDgBibmTlK9EHfieV+lzUtxur20QPbM/I/dOpBG5f4lvGQa0jcBWLKOmQbaLQ==", "c653d515-4d87-48ee-9040-ab5e2a34afcd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fa51a7eb-f8fa-43c4-96c6-071adbaf2db9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e10ceef8-a8bb-480f-b2fb-b04fc3a94029", "AQAAAAEAACcQAAAAEJDsBmgn2JN8f7cFDkfyUDbeKvM47hguBgQXKD8K7ERwWw80F5e641crDvVkmOaD3g==", "8bea9176-4c21-438e-9c7e-9ca2ac13ecb7" });
        }
    }
}
