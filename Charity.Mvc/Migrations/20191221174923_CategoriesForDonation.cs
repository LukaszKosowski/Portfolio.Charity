using Microsoft.EntityFrameworkCore.Migrations;

namespace Charity.Mvc.Migrations
{
    public partial class CategoriesForDonation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "CategoryId",
                table: "Donations",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DonationId",
                table: "Donations",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Donations");

            migrationBuilder.DropColumn(
                name: "DonationId",
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
    }
}
