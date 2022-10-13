using Microsoft.EntityFrameworkCore.Migrations;

namespace MoizTravel.WebAPI.Migrations
{
    public partial class UpdateMigrationV1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "TourDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "AirlineTicketDetail",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "TourDetails");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "AirlineTicketDetail");
        }
    }
}
