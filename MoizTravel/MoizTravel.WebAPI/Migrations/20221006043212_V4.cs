using Microsoft.EntityFrameworkCore.Migrations;

namespace MoizTravel.WebAPI.Migrations
{
    public partial class V4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TourId",
                table: "TourDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_TourDetails_TourId",
                table: "TourDetails",
                column: "TourId");

            migrationBuilder.AddForeignKey(
                name: "FK_TourDetails_Tour_TourId",
                table: "TourDetails",
                column: "TourId",
                principalTable: "Tour",
                principalColumn: "TourId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TourDetails_Tour_TourId",
                table: "TourDetails");

            migrationBuilder.DropIndex(
                name: "IX_TourDetails_TourId",
                table: "TourDetails");

            migrationBuilder.DropColumn(
                name: "TourId",
                table: "TourDetails");
        }
    }
}
