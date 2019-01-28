using Microsoft.EntityFrameworkCore.Migrations;

namespace AsyncInn.Migrations
{
    public partial class HotelRoomFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MyProperty",
                table: "HotelRooms",
                newName: "PetFriendly");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Rooms",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Hotels",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Hotels",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Hotels",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Amenities",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PetFriendly",
                table: "HotelRooms",
                newName: "MyProperty");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Rooms",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Hotels",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Hotels",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Hotels",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Amenities",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
