using Microsoft.EntityFrameworkCore.Migrations;

namespace Charity.Mvc.Migrations
{
    public partial class Donate3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Donations_Categories_CategoriesId",
                table: "Donations");

            migrationBuilder.DropIndex(
                name: "IX_Donations_CategoriesId",
                table: "Donations");

            migrationBuilder.DropColumn(
                name: "CategoriesId",
                table: "Donations");

            migrationBuilder.AddColumn<int>(
                name: "DonationId",
                table: "Categories",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Categories_DonationId",
                table: "Categories",
                column: "DonationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Donations_DonationId",
                table: "Categories",
                column: "DonationId",
                principalTable: "Donations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Donations_DonationId",
                table: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Categories_DonationId",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "DonationId",
                table: "Categories");

            migrationBuilder.AddColumn<int>(
                name: "CategoriesId",
                table: "Donations",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Donations_CategoriesId",
                table: "Donations",
                column: "CategoriesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Donations_Categories_CategoriesId",
                table: "Donations",
                column: "CategoriesId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
