using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Charity.Mvc.Migrations
{
    public partial class CategoriesForDonation2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Donations");

            migrationBuilder.DropColumn(
                name: "DonationId",
                table: "Donations");

            migrationBuilder.AddColumn<bool>(
                name: "IsChecked",
                table: "Categories",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "CategoriesForDonation",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CategoryId = table.Column<int>(nullable: false),
                    DonationId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoriesForDonation", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoriesForDonation");

            migrationBuilder.DropColumn(
                name: "IsChecked",
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
    }
}
