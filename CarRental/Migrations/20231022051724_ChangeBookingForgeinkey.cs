using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRental.Migrations
{
    public partial class ChangeBookingForgeinkey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookingNotes_AppUsers_UserId",
                table: "BookingNotes");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "BookingNotes",
                newName: "CustomerId");

            migrationBuilder.RenameIndex(
                name: "IX_BookingNotes_UserId",
                table: "BookingNotes",
                newName: "IX_BookingNotes_CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_BookingNotes_Customers_CustomerId",
                table: "BookingNotes",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookingNotes_Customers_CustomerId",
                table: "BookingNotes");

            migrationBuilder.RenameColumn(
                name: "CustomerId",
                table: "BookingNotes",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_BookingNotes_CustomerId",
                table: "BookingNotes",
                newName: "IX_BookingNotes_UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_BookingNotes_AppUsers_UserId",
                table: "BookingNotes",
                column: "UserId",
                principalTable: "AppUsers",
                principalColumn: "Id");
        }
    }
}
