using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Data.Migrations
{
    public partial class Migration3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6d220589-9f48-4785-bd5f-63e559ec2b5b");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "Customer");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Employee",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Employee",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Customer",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "Customer",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StreetAddress",
                table: "Customer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ZipCode",
                table: "Customer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "985a72a4-8d9b-4eec-9cb9-b74877758958", "237a62b6-6a0b-4588-a557-dd880982afbd", "Customer", "Customer" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8f5c1932-8a97-44db-ad46-3643a2a271f5", "eb7eb372-4f9c-4237-8a04-cd33013640eb", "Employee", "Employee" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8f5c1932-8a97-44db-ad46-3643a2a271f5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "985a72a4-8d9b-4eec-9cb9-b74877758958");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "State",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "StreetAddress",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "ZipCode",
                table: "Customer");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Customer",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6d220589-9f48-4785-bd5f-63e559ec2b5b", "e3026660-1cba-41eb-86c5-9ddbe0d3295c", "Admin", "ADMIN" });
        }
    }
}
