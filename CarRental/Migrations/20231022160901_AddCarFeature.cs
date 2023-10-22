using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRental.Migrations
{
    public partial class AddCarFeature : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "BlueTooth",
                table: "Cars",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Camera360",
                table: "Cars",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "CollisionSensor",
                table: "Cars",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "DashCam",
                table: "Cars",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "GPS",
                table: "Cars",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Map",
                table: "Cars",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "MarginalCamera",
                table: "Cars",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "PickupTruckTrunkCover",
                table: "Cars",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<float>(
                name: "PricePerDay",
                table: "Cars",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<bool>(
                name: "ReversingCamera",
                table: "Cars",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "SpareTire",
                table: "Cars",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "SpeedWarningKit",
                table: "Cars",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Sunroof",
                table: "Cars",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "TireSensor",
                table: "Cars",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "USB",
                table: "Cars",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BlueTooth",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "Camera360",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "CollisionSensor",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "DashCam",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "GPS",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "Map",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "MarginalCamera",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "PickupTruckTrunkCover",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "PricePerDay",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "ReversingCamera",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "SpareTire",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "SpeedWarningKit",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "Sunroof",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "TireSensor",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "USB",
                table: "Cars");
        }
    }
}
