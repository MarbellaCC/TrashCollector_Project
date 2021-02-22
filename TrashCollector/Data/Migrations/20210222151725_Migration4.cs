using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class Migration4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8f5c1932-8a97-44db-ad46-3643a2a271f5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "985a72a4-8d9b-4eec-9cb9-b74877758958");

            migrationBuilder.AddColumn<DateTime>(
                name: "ExtraPickupDate",
                table: "Customer",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "SupensionStartDate",
                table: "Customer",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "SuspensionEndDate",
                table: "Customer",
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                name: "ExtraPickupDate",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "SupensionStartDate",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "SuspensionEndDate",
                table: "Customer");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "985a72a4-8d9b-4eec-9cb9-b74877758958", "237a62b6-6a0b-4588-a557-dd880982afbd", "Customer", "Customer" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8f5c1932-8a97-44db-ad46-3643a2a271f5", "eb7eb372-4f9c-4237-8a04-cd33013640eb", "Employee", "Employee" });
        }
    }
}
