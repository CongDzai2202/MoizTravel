using Microsoft.EntityFrameworkCore.Migrations;

namespace MoizTravel.WebAPI.Migrations
{
    public partial class V5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TourGuiderId",
                table: "TourDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_TourDetails_TourGuiderId",
                table: "TourDetails",
                column: "TourGuiderId");

            migrationBuilder.AddForeignKey(
                name: "FK_TourDetails_TourGuider_TourGuiderId",
                table: "TourDetails",
                column: "TourGuiderId",
                principalTable: "TourGuider",
                principalColumn: "TourGuiderId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TourDetails_TourGuider_TourGuiderId",
                table: "TourDetails");

            migrationBuilder.DropIndex(
                name: "IX_TourDetails_TourGuiderId",
                table: "TourDetails");

            migrationBuilder.DropColumn(
                name: "TourGuiderId",
                table: "TourDetails");
        }
    }
}
