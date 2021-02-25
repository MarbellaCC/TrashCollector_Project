using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Migrations
{
    public partial class Migration1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Customers_CustomerId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_CustomerId",
                table: "Employees");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "31004a20-55a3-4a14-89f1-5026172da94e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9acb2860-625b-43f2-8e8a-2a0a083f4436");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "Employees");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "fb4141c0-5356-4ec9-8519-e59fc75b3d81", "29c5c144-ebe0-4efc-b1c3-41616da66479", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8aae34e3-f232-40b1-8264-2da87411350d", "b8b33ba7-905e-4d92-8ce6-c090011507fd", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8aae34e3-f232-40b1-8264-2da87411350d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fb4141c0-5356-4ec9-8519-e59fc75b3d81");

            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9acb2860-625b-43f2-8e8a-2a0a083f4436", "a565034a-ebae-4df1-a2e0-df4da01acf0d", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "31004a20-55a3-4a14-89f1-5026172da94e", "586773b2-9821-4302-87a2-4cf94fab7426", "Employee", "EMPLOYEE" });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_CustomerId",
                table: "Employees",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Customers_CustomerId",
                table: "Employees",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
