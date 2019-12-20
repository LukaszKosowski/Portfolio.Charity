using Microsoft.EntityFrameworkCore.Migrations;

namespace Charity.Mvc.Migrations
{
    public partial class Donate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Donations_Institutions_InstitutionId",
                table: "Donations");

            migrationBuilder.RenameColumn(
                name: "InstitutionId",
                table: "Donations",
                newName: "InstitutionsId");

            migrationBuilder.RenameIndex(
                name: "IX_Donations_InstitutionId",
                table: "Donations",
                newName: "IX_Donations_InstitutionsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Donations_Institutions_InstitutionsId",
                table: "Donations",
                column: "InstitutionsId",
                principalTable: "Institutions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Donations_Institutions_InstitutionsId",
                table: "Donations");

            migrationBuilder.RenameColumn(
                name: "InstitutionsId",
                table: "Donations",
                newName: "InstitutionId");

            migrationBuilder.RenameIndex(
                name: "IX_Donations_InstitutionsId",
                table: "Donations",
                newName: "IX_Donations_InstitutionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Donations_Institutions_InstitutionId",
                table: "Donations",
                column: "InstitutionId",
                principalTable: "Institutions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
