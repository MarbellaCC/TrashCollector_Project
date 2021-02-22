using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class Migration5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a2877fab-bec1-41ef-8d9d-18b1a13c7cd6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c8f6ceee-78c2-4080-91bb-04ed140c45b2");

            migrationBuilder.DropColumn(
                name: "SupensionStartDate",
                table: "Customer");

            migrationBuilder.AddColumn<DateTime>(
                name: "SuspensionStartDate",
                table: "Customer",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "530abfdc-3780-49ac-ab38-ab035f7bec8f", "134fbd9f-780f-4496-9fa8-13133c2e5480", "Customer", "Customer" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4fdc5627-4185-4728-9b98-2855161b55a9", "61ad043c-4068-4290-a598-9e09322daf2a", "Employee", "Employee" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4fdc5627-4185-4728-9b98-2855161b55a9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "530abfdc-3780-49ac-ab38-ab035f7bec8f");

            migrationBuilder.DropColumn(
                name: "SuspensionStartDate",
                table: "Customer");

            migrationBuilder.AddColumn<DateTime>(
                name: "SupensionStartDate",
                table: "Customer",
                type: "datetime2",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a2877fab-bec1-41ef-8d9d-18b1a13c7cd6", "6dcfb038-0786-4a47-99b8-4765e9bd370a", "Customer", "Customer" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c8f6ceee-78c2-4080-91bb-04ed140c45b2", "a6d97a9e-d5a3-4dd0-ac5c-0bc2183d32f6", "Employee", "Employee" });
        }
    }
}
