using Microsoft.EntityFrameworkCore.Migrations;

namespace AsyncInn.Migrations
{
    public partial class RoomAmenitiesDelete : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "ID",
                keyValue: 1,
                column: "Phone",
                value: "(206) 555-1234");

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "ID",
                keyValue: 2,
                column: "Phone",
                value: "(206) 555-5678");

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "ID",
                keyValue: 3,
                column: "Phone",
                value: "(425) 555-1234");

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "ID",
                keyValue: 4,
                column: "Phone",
                value: "(425) 555-5678");

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "ID",
                keyValue: 5,
                column: "Phone",
                value: "(360) 555-1234");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "ID",
                keyValue: 1,
                column: "Phone",
                value: "12065551234");

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "ID",
                keyValue: 2,
                column: "Phone",
                value: "12065551234");

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "ID",
                keyValue: 3,
                column: "Phone",
                value: "12065551234");

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "ID",
                keyValue: 4,
                column: "Phone",
                value: "12065551234");

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "ID",
                keyValue: 5,
                column: "Phone",
                value: "12065551234");
        }
    }
}
