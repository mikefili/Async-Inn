using Microsoft.EntityFrameworkCore.Migrations;

namespace AsyncInn.Migrations
{
    public partial class DependencyInjection : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Address",
                table: "Hotels",
                newName: "StreetAddress");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Hotels",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "Hotels",
                maxLength: 2,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ZipCode",
                table: "Hotels",
                maxLength: 2,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "City",
                table: "Hotels");

            migrationBuilder.DropColumn(
                name: "State",
                table: "Hotels");

            migrationBuilder.DropColumn(
                name: "ZipCode",
                table: "Hotels");

            migrationBuilder.RenameColumn(
                name: "StreetAddress",
                table: "Hotels",
                newName: "Address");
        }
    }
}
