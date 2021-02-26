using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Migrations
{
    public partial class Migration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8aae34e3-f232-40b1-8264-2da87411350d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fb4141c0-5356-4ec9-8519-e59fc75b3d81");

            migrationBuilder.AddColumn<bool>(
                name: "TrashPickedUp",
                table: "Customers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1d4cf8e4-aca1-449f-b77b-1b98ed898d73", "82b113ac-d397-4e1d-b667-dba9ca04cbfd", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d7508cb8-253e-4411-a9b9-3e1eb22f6264", "66745609-e9e2-4b9e-b409-45825042a754", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1d4cf8e4-aca1-449f-b77b-1b98ed898d73");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d7508cb8-253e-4411-a9b9-3e1eb22f6264");

            migrationBuilder.DropColumn(
                name: "TrashPickedUp",
                table: "Customers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "fb4141c0-5356-4ec9-8519-e59fc75b3d81", "29c5c144-ebe0-4efc-b1c3-41616da66479", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8aae34e3-f232-40b1-8264-2da87411350d", "b8b33ba7-905e-4d92-8ce6-c090011507fd", "Employee", "EMPLOYEE" });
        }
    }
}
